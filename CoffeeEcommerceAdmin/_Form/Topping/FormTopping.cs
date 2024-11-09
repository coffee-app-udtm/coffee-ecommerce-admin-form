using CoffeeEcommerceAdmin._Form.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeEcommerceAdmin._Form.Topping
{
    public partial class FormTopping : Form
    {
        public FormTopping()
        {
            InitializeComponent(); 
            this.button_back_product.Click += Button_back_product_Click;
        }

        private void Button_back_product_Click(object sender, EventArgs e)
        {

            FormLayout parentFormLayout = this.ParentForm as FormLayout;

            if (parentFormLayout != null)
            {
                parentFormLayout.loadForm(new FormProduct());
            }
        }
    }
}
