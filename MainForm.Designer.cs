namespace SPZLab6Var1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductBuyingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.reportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductNameColumn
            // 
            this.ProductNameColumn.HeaderText = "Название";
            this.ProductNameColumn.Name = "ProductNameColumn";
            this.ProductNameColumn.ReadOnly = true;
            // 
            // ProductQuantityColumn
            // 
            this.ProductQuantityColumn.HeaderText = "Колчество";
            this.ProductQuantityColumn.Name = "ProductQuantityColumn";
            this.ProductQuantityColumn.ReadOnly = true;
            // 
            // ProductBuyingPrice
            // 
            this.ProductBuyingPrice.HeaderText = "Цена покупки";
            this.ProductBuyingPrice.Name = "ProductBuyingPrice";
            this.ProductBuyingPrice.ReadOnly = true;
            // 
            // ProductSellingPrice
            // 
            this.ProductSellingPrice.HeaderText = "Цена продажи";
            this.ProductSellingPrice.Name = "ProductSellingPrice";
            this.ProductSellingPrice.ReadOnly = true;
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.AllowUserToDeleteRows = false;
            this.productDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductNameColumn,
            this.ProductQuantityColumn,
            this.ProductBuyingPrice,
            this.ProductSellingPrice});
            this.productDataGridView.Location = new System.Drawing.Point(12, 37);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            this.productDataGridView.Size = new System.Drawing.Size(643, 150);
            this.productDataGridView.TabIndex = 0;
            this.productDataGridView.Text = "dataGridView1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Склад";
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(576, 8);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(75, 23);
            this.reportButton.TabIndex = 2;
            this.reportButton.Text = "Отчет";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 194);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productDataGridView);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductBuyingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSellingPrice;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reportButton;
    }
}

