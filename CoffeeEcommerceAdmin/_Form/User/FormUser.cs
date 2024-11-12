using CoffeeLibrary.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UserModel = CoffeeLibrary.Model.User;

namespace CoffeeEcommerceAdmin._Form.User
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();

            RenderUsersGridView();
        }

        private async void RenderUsersGridView()
        {
            UserRequest userRequest = new UserRequest();
            List<UserModel> users = await userRequest.GetUsersAsync();

            dataGridView_users.DataSource = users;

            // Đổi tên cột
            dataGridView_users.Columns["id"].HeaderText = "ID";
            dataGridView_users.Columns["user_name"].HeaderText = "Tên người dùng";
            dataGridView_users.Columns["email"].HeaderText = "Email";
            dataGridView_users.Columns["phone_number"].HeaderText = "Số điện thoại";


            // Ẩn cột
            dataGridView_users.Columns["password"].Visible = false;
            dataGridView_users.Columns["avatar"].Visible = false;
            dataGridView_users.Columns["role_id"].Visible = false;
            dataGridView_users.Columns["account_type"].Visible = false;
        }
    }
}
