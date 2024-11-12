namespace CoffeeEcommerceAdmin._Form.Revenue
{
    partial class FormRevenue
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
            this.ucRevenueList1 = new UCRevenue.UCRevenueList();
            this.SuspendLayout();
            // 
            // ucRevenueList1
            // 
            this.ucRevenueList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucRevenueList1.Location = new System.Drawing.Point(0, 0);
            this.ucRevenueList1.Name = "ucRevenueList1";
            this.ucRevenueList1.Size = new System.Drawing.Size(1140, 550);
            this.ucRevenueList1.TabIndex = 0;
            // 
            // FormRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 550);
            this.Controls.Add(this.ucRevenueList1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRevenue";
            this.Text = "FormRevenue";
            this.ResumeLayout(false);

        }

        #endregion

        private UCRevenue.UCRevenueList ucRevenueList1;
    }
}