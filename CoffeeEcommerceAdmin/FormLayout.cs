using CoffeeEcommerceAdmin._Form.Product;
using CoffeeEcommerceAdmin._Form.User;
using CoffeeEcommerceAdmin._Form.Revenue;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeEcommerceAdmin._Form.Account;

namespace CoffeeEcommerceAdmin
{
    public partial class FormLayout : Form
    {
        private List<Button> navButtons;
        public FormLayout(Form form)
        {
            InitializeComponent();

            initNavButtons();
            setActiveButton(button_nav_dashboard);

            // Thiết lập form toàn màn hình
            this.WindowState = FormWindowState.Maximized;  // Phóng to form
            this.TopMost = true;                           // Đặt form luôn trên các cửa sổ khác

            // 
            string currentUserName = Properties.Settings.Default.user_name;

            // Xử lý thêm ... nếu tên quá dài
            if (currentUserName.Length > 12)
            {
                currentUserName = currentUserName.Substring(0, 12) + "...";
            }

            this.button_current_user.Text = " " + currentUserName;

            // Check if form is not null
            if (form != null)
            {
                loadForm(form);
            }
            else // Load default form
            {
                loadForm(new FormDashboard());
            }

            this.button_logout.Click += button_logout_Click;
            this.FormClosing += FormLayout_FormClosing;
        }

        private void FormLayout_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng không?",
                                          "Xác nhận thoát",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            // Nếu người dùng chọn "No", hủy việc đóng form
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void initNavButtons()
        {
            navButtons = new List<Button>();

            navButtons.Add(button_nav_dashboard);
            navButtons.Add(button_nav_product);
            navButtons.Add(button_nav_user);
            navButtons.Add(button_nav_revenue);
            navButtons.Add(button_nav_account);

            foreach (var btn in navButtons)
            {
                btn.Click += button_nav_Click;
            }

            // Disable by role_id

            // Role id = 2 -> ( Nhân viên quản trị hệ thống ) -> Quản lý tài khoản -> Các button khác bị disable
            if (Properties.Settings.Default.role_id == 2)
            {
                button_nav_product.Enabled = false;
                button_nav_user.Enabled = false;
                button_nav_revenue.Enabled = false;
            }

            // Role id = 4 -> ( Nhân viên quản lý sản phẩm ) -> Quản lý sản phẩm -> Các button khác bị disable
            if (Properties.Settings.Default.role_id == 4)
            {
                button_nav_user.Enabled = false;
                button_nav_revenue.Enabled = false;
                button_nav_account.Enabled = false;
            }

            // Role id = 5 -> ( Nhân viên quản lý tài chính ) -> Quản lý khách hàng, quản lý doanh thu -> Các button khác bị disable
            if (Properties.Settings.Default.role_id == 5)
            {
                button_nav_product.Enabled = false;
                button_nav_account.Enabled = false;
            }
        }

        private void setActiveButton(Button activeButton)
        {
            // Reset all buttons to default color
            foreach (var btn in navButtons)
            {
                btn.ForeColor = Color.Black; // Default color
            }

            activeButton.ForeColor = Color.FromArgb(255, 161, 108);
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn đăng xuất không?", "Logout", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {

                // Clear settings
                Properties.Settings.Default.user_id = "";
                Properties.Settings.Default.user_name = "";
                Properties.Settings.Default.role_id = 0;

                Properties.Settings.Default.Save();


                this.Hide();

                FormLogin formLogin = new FormLogin();
                formLogin.Show();
            }
        }

        private void button_nav_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            setActiveButton(clickedButton);

            handleNavigateForm(clickedButton);
        }

        // Handle navigation form
        private void handleNavigateForm(Button clickedButton)
        {
            switch (clickedButton.Name)
            {
                case "button_nav_dashboard":
                    this.Text = "Dashboard";
                    loadForm(new FormDashboard());
                    break;
                case "button_nav_product":
                    this.Text = "Sản phẩm";
                    loadForm(new FormProduct());
                    break;
                case "button_nav_user":
                    this.Text = "Khách hàng";
                    loadForm(new FormUser());
                    break;
                case "button_nav_revenue":
                    this.Text = "Doanh thu";
                    loadForm(new FormRevenue());
                    break;
                case "button_nav_account":
                    this.Text = "Tài khoản";
                    loadForm(new FormAccount());
                    break;
                default:
                    break;
            }
        }

        public void loadForm(object form)
        {
            if (this.panel_main.Controls.Count > 0)
            {
                this.panel_main.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel_main.Controls.Add(f);
            this.panel_main.Tag = f;
            f.Show();
        }
    }
}
