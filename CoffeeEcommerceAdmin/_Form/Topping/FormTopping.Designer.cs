namespace CoffeeEcommerceAdmin._Form.Topping
{
    partial class FormTopping
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_back_product = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucToppingList1 = new UCTopping.UCToppingList();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_back_product);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 69);
            this.panel1.TabIndex = 1;
            // 
            // button_back_product
            // 
            this.button_back_product.Location = new System.Drawing.Point(13, 13);
            this.button_back_product.Name = "button_back_product";
            this.button_back_product.Size = new System.Drawing.Size(170, 39);
            this.button_back_product.TabIndex = 0;
            this.button_back_product.Text = "Quay lại";
            this.button_back_product.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucToppingList1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1206, 584);
            this.panel2.TabIndex = 2;
            // 
            // ucToppingList1
            // 
            this.ucToppingList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucToppingList1.Location = new System.Drawing.Point(0, 0);
            this.ucToppingList1.Name = "ucToppingList1";
            this.ucToppingList1.Size = new System.Drawing.Size(1206, 584);
            this.ucToppingList1.TabIndex = 0;
            // 
            // FormTopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTopping";
            this.Text = "FormTopping";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_back_product;
        private System.Windows.Forms.Panel panel2;
        private UCTopping.UCToppingList ucToppingList1;
    }
}