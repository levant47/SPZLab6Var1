using System.Windows.Forms;

namespace SPZLab6Var1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            UpdateProductView();
        }

        public void UpdateProductView()
        {
            productDataGridView.Rows.Clear();
            Shop.ProductTypes.ForEach(productType => productDataGridView.Rows.Add(productType.Name, productType.Quantity, productType.BuyingPrice, productType.SellingPrice));
        }
    }
}

