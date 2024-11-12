using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeEcommerceAdmin._Form.Revenue
{
    public partial class FormRevenue : Form
    {
        public FormRevenue()
        {
            InitializeComponent();

            ucRevenueList1.RenderAdminRevenue();
        }
    }
}
