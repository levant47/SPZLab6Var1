using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SPZLab6Var1
{
    public partial class MainForm : Form
    {
        private const string _reportPath = "report.xml";
        private bool _isRunning = true;
        private ManualResetEvent _manualResetEvent = new ManualResetEvent(false);
        private Thread _clientModeThread;
        private Thread _restockModeThread;

        public MainForm()
        {
            InitializeComponent();

            UpdateProductView();

            StartClientMode();
            StartRestockMode();
        }

        private void UpdateProductView()
        {
            productDataGridView.Rows.Clear();
            Shop.ProductTypes.ForEach(productType => productDataGridView.Rows.Add(productType.Name, productType.Quantity, productType.BuyingPrice, productType.SellingPrice));
        }

        private void StartClientMode()
        {
            _clientModeThread = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        _manualResetEvent.WaitOne(TimeSpan.FromSeconds(1));
                        if (!_isRunning)
                        {
                            return;
                        }
                        var productType = Shop.ProductTypes.Where(productType => productType.Quantity != 0).ToList().GetRandomElement();
                        var quantity = new Random().Next(1, productType.Quantity);
                        Shop.Purchase(productType.Id, quantity);
                        productDataGridView.Invoke(new Action(UpdateProductView));
                    }
                }
                catch
                { }
            });
            _clientModeThread.Start();
        }

        private void StartRestockMode()
        {
            _restockModeThread = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        _manualResetEvent.WaitOne(TimeSpan.FromSeconds(10));
                        if (!_isRunning)
                        {
                            return;
                        }
                        WriteReport();
                        foreach (var _ in Enumerable.Range(0, Shop.ProductTypes.Count))
                        {
                            Shop.Restock(Shop.ProductTypes.GetRandomElement().Id, new Random().Next(0, 100));
                        }
                    }
                }
                catch
                { }
            });
            _restockModeThread.Start();
        }

        private void WriteReport()
        {
            var report = new Report
            {
                Cash = Shop.Cash,
                PurchaseCount = Shop.PurchaseCount,
                TotalProductCount = Shop.ProductTypes.Sum(productType => productType.Quantity),
            };
            File.WriteAllText(_reportPath, Utilities.SerializeToXML(report));
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _isRunning = false;
            _manualResetEvent.Set();
            _clientModeThread.Join();
            _restockModeThread.Join();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(_reportPath))
            {
                return;
            }
            var report = Utilities.DeserializeFromXML<Report>(File.ReadAllText(_reportPath));
            new ReportForm(report).Show();
        }
    }
}

