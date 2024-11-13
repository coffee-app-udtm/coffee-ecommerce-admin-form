namespace CoffeeEcommerceAdmin._Form.Account
{
    partial class FormAccount
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
            this.dataGridView_accounts = new System.Windows.Forms.DataGridView();
            this.textBox_store_login_nane = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_toggle_password = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_account_type = new System.Windows.Forms.ComboBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_stores = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_accounts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_accounts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 587);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView_accounts
            // 
            this.dataGridView_accounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_accounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_accounts.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_accounts.Name = "dataGridView_accounts";
            this.dataGridView_accounts.RowHeadersWidth = 51;
            this.dataGridView_accounts.RowTemplate.Height = 24;
            this.dataGridView_accounts.Size = new System.Drawing.Size(562, 587);
            this.dataGridView_accounts.TabIndex = 0;
            // 
            // textBox_store_login_nane
            // 
            this.textBox_store_login_nane.Location = new System.Drawing.Point(623, 41);
            this.textBox_store_login_nane.Name = "textBox_store_login_nane";
            this.textBox_store_login_nane.Size = new System.Drawing.Size(457, 22);
            this.textBox_store_login_nane.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên đăng nhập";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(623, 128);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(375, 22);
            this.textBox_password.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // button_toggle_password
            // 
            this.button_toggle_password.Location = new System.Drawing.Point(1005, 124);
            this.button_toggle_password.Name = "button_toggle_password";
            this.button_toggle_password.Size = new System.Drawing.Size(75, 30);
            this.button_toggle_password.TabIndex = 4;
            this.button_toggle_password.Text = "Ẩn";
            this.button_toggle_password.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(620, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loại tài khoản";
            // 
            // comboBox_account_type
            // 
            this.comboBox_account_type.FormattingEnabled = true;
            this.comboBox_account_type.Location = new System.Drawing.Point(623, 222);
            this.comboBox_account_type.Name = "comboBox_account_type";
            this.comboBox_account_type.Size = new System.Drawing.Size(457, 24);
            this.comboBox_account_type.TabIndex = 5;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(623, 369);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(457, 54);
            this.button_add.TabIndex = 6;
            this.button_add.Text = "Thêm";
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(623, 444);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(457, 54);
            this.button_edit.TabIndex = 6;
            this.button_edit.Text = "Sửa";
            this.button_edit.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Red;
            this.button_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_delete.Location = new System.Drawing.Point(623, 513);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(457, 54);
            this.button_delete.TabIndex = 6;
            this.button_delete.Text = "Xóa";
            this.button_delete.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(620, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cửa hàng";
            // 
            // comboBox_stores
            // 
            this.comboBox_stores.FormattingEnabled = true;
            this.comboBox_stores.Location = new System.Drawing.Point(623, 308);
            this.comboBox_stores.Name = "comboBox_stores";
            this.comboBox_stores.Size = new System.Drawing.Size(457, 24);
            this.comboBox_stores.TabIndex = 5;
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 587);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.comboBox_stores);
            this.Controls.Add(this.comboBox_account_type);
            this.Controls.Add(this.button_toggle_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_store_login_nane);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAccount";
            this.Text = "FormAccount";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_accounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_accounts;
        private System.Windows.Forms.TextBox textBox_store_login_nane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_toggle_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_account_type;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_stores;
    }
}