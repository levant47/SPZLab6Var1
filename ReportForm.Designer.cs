namespace SPZLab6Var1
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cashTextBox = new System.Windows.Forms.TextBox();
            this.purchaseCountTextBox = new System.Windows.Forms.TextBox();
            this.totalProductCountTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Прибыль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество покупок";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество товаров";
            // 
            // cashTextBox
            // 
            this.cashTextBox.Enabled = false;
            this.cashTextBox.Location = new System.Drawing.Point(137, 12);
            this.cashTextBox.Name = "cashTextBox";
            this.cashTextBox.Size = new System.Drawing.Size(100, 23);
            this.cashTextBox.TabIndex = 3;
            // 
            // purchaseCountTextBox
            // 
            this.purchaseCountTextBox.Enabled = false;
            this.purchaseCountTextBox.Location = new System.Drawing.Point(137, 41);
            this.purchaseCountTextBox.Name = "purchaseCountTextBox";
            this.purchaseCountTextBox.Size = new System.Drawing.Size(100, 23);
            this.purchaseCountTextBox.TabIndex = 4;
            // 
            // totalProductCountTextBox
            // 
            this.totalProductCountTextBox.Enabled = false;
            this.totalProductCountTextBox.Location = new System.Drawing.Point(137, 70);
            this.totalProductCountTextBox.Name = "totalProductCountTextBox";
            this.totalProductCountTextBox.Size = new System.Drawing.Size(100, 23);
            this.totalProductCountTextBox.TabIndex = 5;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 107);
            this.Controls.Add(this.totalProductCountTextBox);
            this.Controls.Add(this.purchaseCountTextBox);
            this.Controls.Add(this.cashTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cashTextBox;
        private System.Windows.Forms.TextBox purchaseCountTextBox;
        private System.Windows.Forms.TextBox totalProductCountTextBox;
    }
}