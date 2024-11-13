using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeLibrary;
using CoffeeLibrary.Model;
using CoffeeLibrary.Request;

namespace CoffeeEcommerceAdmin
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();

            RenderCardWidgets();
        }

        private async void RenderCardWidgets()
        {
            RevenueRequest revenueRequest = new RevenueRequest();

            // Get current day, month, year 
            int currentDay = DateTime.Now.Day;
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;

            List<Revenue> revenues = await revenueRequest.GetRevenuesAsync(currentDay, currentMonth, currentYear, 0);

            // Get total revenue
            decimal totalRevenue = 0;
            foreach (Revenue revenue in revenues)
            {
                totalRevenue += revenue.total_revenue ?? 0;
            }

            label_total_revenue_today.Text = Util.FormatVNCurrency(totalRevenue);


            // Get total order
            OrderRequest orderRequest = new OrderRequest();
            List<Order> orders = await orderRequest.GetOrdersAsync();

            label_total_order.Text = orders.Count.ToString();

            // Get total customer

            UserRequest userRequest = new UserRequest();
            List<User> users = await userRequest.GetUsersAsync();

            label_total_customer.Text = users.Count.ToString();

        }
    }
}
