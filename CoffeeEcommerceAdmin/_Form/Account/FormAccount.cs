using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoffeeLibrary.Model;
using CoffeeLibrary.Request;

namespace CoffeeEcommerceAdmin._Form.Account
{
    public partial class FormAccount : Form
    {
        private StoreAccount storeAccountClicked = null;
        public FormAccount()
        {
            InitializeComponent();

            this.button_toggle_password.Click += Button_toggle_password_Click;
            this.button_add.Click += Button_add_Click;
            this.dataGridView_accounts.CellClick += DataGridView_accounts_CellClick;
            this.button_delete.Click += Button_delete_Click;
            this.button_edit.Click += Button_edit_Click;

            RenderAccountTypeCombobox();
            RenderStoresCombobox();

            RenderStoresGridView();
        }

        private async void Button_edit_Click(object sender, EventArgs e)
        {
            if (storeAccountClicked == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridView_accounts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            bool isValid = ValidateForm();

            if (!isValid)
            {
                return;
            }
            
            if (this.textBox_password.Text.Length > 0)
            {
                if (this.textBox_password.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Yêu cầu mật khẩu phải có ít nhất 6 ký tự
                if (this.textBox_password.Text.Length < 6)
                {
                    MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Yêu cầu mật khẩu phải có tối đa 20 ký tự
                if (this.textBox_password.Text.Length > 20)
                {
                    MessageBox.Show("Mật khẩu phải có tối đa 20 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                button_edit.Enabled = false;
                button_edit.Text = "Đang xử lý...";

                string storeLoginName = this.textBox_store_login_nane.Text;
                string accountType = this.comboBox_account_type.SelectedItem.ToString();
                int storeId = int.Parse(this.comboBox_stores.SelectedValue.ToString());

                StoreAccount account = new StoreAccount()
                {
                    id = storeAccountClicked.id,
                    store_login_name = storeLoginName,
                    account_type = accountType,
                    store_id = storeId
                };
                if (this.textBox_password.Text.Trim().Length > 0)
                {
                    account.password = this.textBox_password.Text;
                }
                

                AuthRequest storeAccountRequest = new AuthRequest();
                StoreAccount storeAccount = await storeAccountRequest.UpdateStoreAccountAsync(account);

                if (storeAccount == null)
                {
                    MessageBox.Show("Sửa tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("Sửa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.textBox_store_login_nane.Text = "";
                this.textBox_password.Text = "";
                this.comboBox_account_type.SelectedIndex = 0;
                this.comboBox_stores.SelectedIndex = 0;

                RenderStoresGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                button_edit.Enabled = true;
                button_edit.Text = "Sửa";
            }
        }

        private async void Button_delete_Click(object sender, EventArgs e)
        {
            if (storeAccountClicked == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridView_accounts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Hiển thị thông báo xác nhận xóa
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            try
            {
                button_delete.Enabled = false;
                button_delete.Text = "Đang xử lý...";

                AuthRequest storeAccountRequest = new AuthRequest();
                bool result = await storeAccountRequest.DeleteStoreAccountAsync(storeAccountClicked.id);

                if (!result)
                {
                    MessageBox.Show("Xóa tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("Xóa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.textBox_store_login_nane.Text = "";
                this.textBox_password.Text = "";
                this.comboBox_account_type.SelectedIndex = 0;
                this.comboBox_stores.SelectedIndex = 0;

                RenderStoresGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                button_delete.Enabled = true;
                button_delete.Text = "Xóa";
            }
        }

        private void DataGridView_accounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có dong nào được chọn không

            if (dataGridView_accounts.SelectedRows.Count > 0)
            {
                // Lấy store account từ dòng được chọn
                StoreAccount storeAccount = (StoreAccount)dataGridView_accounts.SelectedRows[0].DataBoundItem;

                // Đổ dữ liệu vào form
                this.textBox_store_login_nane.Text = storeAccount.store_login_name;
                //this.textBox_password.Text = storeAccount.password;
                this.comboBox_account_type.SelectedItem = storeAccount.account_type;
                this.comboBox_stores.SelectedValue = storeAccount.store_id;

                storeAccountClicked = storeAccount;
            }

        }


        private async void Button_add_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateForm();

            if (!isValid)
            {
                return;
            }

            if (this.textBox_password.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Yêu cầu mật khẩu phải có ít nhất 6 ký tự
            if (this.textBox_password.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Yêu cầu mật khẩu phải có tối đa 20 ký tự
            if (this.textBox_password.Text.Length > 20)
            {
                MessageBox.Show("Mật khẩu phải có tối đa 20 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                button_add.Enabled = false;
                button_add.Text = "Đang xử lý...";

                string storeLoginName = this.textBox_store_login_nane.Text;
                string password = this.textBox_password.Text;
                string accountType = this.comboBox_account_type.SelectedItem.ToString();
                int storeId = int.Parse(this.comboBox_stores.SelectedValue.ToString());

                StoreAccount account = new StoreAccount()
                {
                    store_login_name = storeLoginName,
                    password = password,
                    account_type = accountType,
                    store_id = storeId
                };

                AuthRequest storeAccountRequest = new AuthRequest();
                StoreAccount storeAccount = await storeAccountRequest.CreateStoreAccountAsync(account);

                if (storeAccount == null)
                {
                    MessageBox.Show("Tạo tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.textBox_store_login_nane.Text = "";
                this.textBox_password.Text = "";
                this.comboBox_account_type.SelectedIndex = 0;
                this.comboBox_stores.SelectedIndex = 0;

                RenderStoresGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                button_add.Enabled = true;
                button_add.Text = "Thêm";

            }
        }

        private void Button_toggle_password_Click(object sender, EventArgs e)
        {
            // Handle toggle password button
            if (this.textBox_password.UseSystemPasswordChar)
            {
                this.textBox_password.UseSystemPasswordChar = false;
                button_toggle_password.Text = "Ẩn";
            }
            else
            {
                this.textBox_password.UseSystemPasswordChar = true;
                button_toggle_password.Text = "Hiện";
            }
        }

        private bool ValidateForm()
        {
            if (this.textBox_store_login_nane.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            

            return true;
        }

        private void RenderAccountTypeCombobox()
        {
            // Render account type combobox
            this.comboBox_account_type.Items.Add("Nhân viên");
            this.comboBox_account_type.Items.Add("Quản lý");

            // Set default value
            this.comboBox_account_type.SelectedIndex = 0;
        }

        private async void RenderStoresCombobox()
        {

            StoreRequest storeRequest = new StoreRequest();
            List<Store> stores = await storeRequest.GetStoresAsync();

            this.comboBox_stores.DataSource = stores;

            this.comboBox_stores.DisplayMember = "store_name";
            this.comboBox_stores.ValueMember = "id";
        }

        private async void RenderStoresGridView()
        {
            AuthRequest authRequest = new AuthRequest();
            List<StoreAccount> storeAccounts = await authRequest.GetStoreAccountsAsync();

            this.dataGridView_accounts.DataSource = storeAccounts;

            // Đổi tên cột
            this.dataGridView_accounts.Columns["id"].HeaderText = "ID";
            this.dataGridView_accounts.Columns["store_login_name"].HeaderText = "Tên tài khoản";
            this.dataGridView_accounts.Columns["account_type"].HeaderText = "Loại tài khoản";
            this.dataGridView_accounts.Columns["store_id"].HeaderText = "ID cửa hàng";

            // Ẩn cột
            this.dataGridView_accounts.Columns["password"].Visible = false;
        }
    }
}
