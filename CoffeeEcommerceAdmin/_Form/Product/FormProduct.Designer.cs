namespace CoffeeEcommerceAdmin._Form.Product
{
    partial class FormProduct
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
            this.button_topping_form = new System.Windows.Forms.Button();
            this.button_size_form = new System.Windows.Forms.Button();
            this.button_category_form = new System.Windows.Forms.Button();
            this.button_delete_product = new System.Windows.Forms.Button();
            this.button_update_form = new System.Windows.Forms.Button();
            this.button_create_product_form = new System.Windows.Forms.Button();
            this.panel_frame = new System.Windows.Forms.Panel();
            this.dataGridView_products = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel_frame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_topping_form);
            this.panel1.Controls.Add(this.button_size_form);
            this.panel1.Controls.Add(this.button_category_form);
            this.panel1.Controls.Add(this.button_delete_product);
            this.panel1.Controls.Add(this.button_update_form);
            this.panel1.Controls.Add(this.button_create_product_form);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 95);
            this.panel1.TabIndex = 0;
            // 
            // button_topping_form
            // 
            this.button_topping_form.Location = new System.Drawing.Point(286, 29);
            this.button_topping_form.Name = "button_topping_form";
            this.button_topping_form.Size = new System.Drawing.Size(131, 44);
            this.button_topping_form.TabIndex = 1;
            this.button_topping_form.Text = "Quản lý topping";
            this.button_topping_form.UseVisualStyleBackColor = true;
            // 
            // button_size_form
            // 
            this.button_size_form.Location = new System.Drawing.Point(149, 29);
            this.button_size_form.Name = "button_size_form";
            this.button_size_form.Size = new System.Drawing.Size(131, 44);
            this.button_size_form.TabIndex = 2;
            this.button_size_form.Text = "Quản lý size";
            this.button_size_form.UseVisualStyleBackColor = true;
            // 
            // button_category_form
            // 
            this.button_category_form.Location = new System.Drawing.Point(12, 29);
            this.button_category_form.Name = "button_category_form";
            this.button_category_form.Size = new System.Drawing.Size(131, 44);
            this.button_category_form.TabIndex = 3;
            this.button_category_form.Text = "Quản lý danh mục";
            this.button_category_form.UseVisualStyleBackColor = true;
            // 
            // button_delete_product
            // 
            this.button_delete_product.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_delete_product.BackColor = System.Drawing.Color.Red;
            this.button_delete_product.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_delete_product.Location = new System.Drawing.Point(923, 29);
            this.button_delete_product.Name = "button_delete_product";
            this.button_delete_product.Size = new System.Drawing.Size(109, 44);
            this.button_delete_product.TabIndex = 4;
            this.button_delete_product.Text = "Xóa";
            this.button_delete_product.UseVisualStyleBackColor = false;
            // 
            // button_update_form
            // 
            this.button_update_form.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_update_form.Location = new System.Drawing.Point(812, 29);
            this.button_update_form.Name = "button_update_form";
            this.button_update_form.Size = new System.Drawing.Size(105, 44);
            this.button_update_form.TabIndex = 5;
            this.button_update_form.Text = "Sửa";
            this.button_update_form.UseVisualStyleBackColor = true;
            // 
            // button_create_product_form
            // 
            this.button_create_product_form.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_create_product_form.Location = new System.Drawing.Point(677, 29);
            this.button_create_product_form.Name = "button_create_product_form";
            this.button_create_product_form.Size = new System.Drawing.Size(129, 44);
            this.button_create_product_form.TabIndex = 6;
            this.button_create_product_form.Text = "Thêm";
            this.button_create_product_form.UseVisualStyleBackColor = true;
            // 
            // panel_frame
            // 
            this.panel_frame.Controls.Add(this.dataGridView_products);
            this.panel_frame.Controls.Add(this.panel2);
            this.panel_frame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_frame.Location = new System.Drawing.Point(0, 95);
            this.panel_frame.Name = "panel_frame";
            this.panel_frame.Size = new System.Drawing.Size(1044, 507);
            this.panel_frame.TabIndex = 1;
            // 
            // dataGridView_products
            // 
            this.dataGridView_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_products.Location = new System.Drawing.Point(0, 100);
            this.dataGridView_products.Name = "dataGridView_products";
            this.dataGridView_products.RowHeadersWidth = 51;
            this.dataGridView_products.RowTemplate.Height = 24;
            this.dataGridView_products.Size = new System.Drawing.Size(1044, 407);
            this.dataGridView_products.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button_search);
            this.panel2.Controls.Add(this.comboBox_category);
            this.panel2.Controls.Add(this.textBox_search);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 100);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Danh mục";
            // 
            // button_search
            // 
            this.button_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_search.Location = new System.Drawing.Point(391, 30);
            this.button_search.Name = "button_search";
            this.button_search.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_search.Size = new System.Drawing.Size(134, 45);
            this.button_search.TabIndex = 6;
            this.button_search.Text = "Tìm kiếm";
            this.button_search.UseVisualStyleBackColor = true;
            // 
            // comboBox_category
            // 
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.ItemHeight = 16;
            this.comboBox_category.Location = new System.Drawing.Point(16, 51);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(165, 24);
            this.comboBox_category.TabIndex = 5;
            // 
            // textBox_search
            // 
            this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_search.Location = new System.Drawing.Point(187, 30);
            this.textBox_search.Multiline = true;
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(198, 45);
            this.textBox_search.TabIndex = 4;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 602);
            this.Controls.Add(this.panel_frame);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProduct";
            this.Text = "FormProduct";
            this.panel1.ResumeLayout(false);
            this.panel_frame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_topping_form;
        private System.Windows.Forms.Button button_size_form;
        private System.Windows.Forms.Button button_category_form;
        private System.Windows.Forms.Button button_delete_product;
        private System.Windows.Forms.Button button_update_form;
        private System.Windows.Forms.Button button_create_product_form;
        private System.Windows.Forms.Panel panel_frame;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.DataGridView dataGridView_products;
    }
}