using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SPZLab6Var1
{
    public partial class MainForm : Form
    {
        private Thread _clientModeThread;

        public MainForm()
        {
            InitializeComponent();

            UpdateProductView();

            StartClientMode();
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
                    foreach (var _ in Enumerable.Range(0, 10))
                    {
                        Thread.Sleep(1000);
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

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _clientModeThread.Interrupt();
        }
    }
}

