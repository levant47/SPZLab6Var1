using System.Windows.Forms;

namespace SPZLab6Var1
{
    public partial class ReportForm : Form
    {
        public ReportForm(Report report)
        {
            InitializeComponent();

            cashTextBox.Text = report.Cash.ToString();
            purchaseCountTextBox.Text = report.PurchaseCount.ToString();
            totalProductCountTextBox.Text = report.TotalProductCount.ToString();
        }
    }
}

