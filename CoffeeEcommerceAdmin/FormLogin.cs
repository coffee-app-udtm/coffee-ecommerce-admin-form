using CoffeeLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeEcommerceAdmin
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            ucLoginAdmin1.LoginSuccessfulEvent += OnLoginSuccessful;
        }

        private void OnLoginSuccessful(object sender, User e)
        {
            // Handle the login data here
            string userId = e.id;
            string userName = e.user_name;

            // Set to properties
            Properties.Settings.Default.user_id = userId;
            Properties.Settings.Default.user_name = userName;

            // Save the properties
            Properties.Settings.Default.Save();

            MessageBox.Show("Đăng nhập thành công vào");

            // Close the login form
            this.Hide();

            // Show the main form
            FormLayout formLayout = new FormLayout(null);
            formLayout.Show();
        }
    }
}
