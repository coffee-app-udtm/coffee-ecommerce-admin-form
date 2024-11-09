using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoffeeEcommerceAdmin._Form.Category;

namespace CoffeeEcommerceAdmin._Form.Product
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();

            this.button_category_form.Click += Button_category_form_Click;
        }

        private void Button_category_form_Click(object sender, EventArgs e)
        {

            FormLayout parentFormLayout = this.ParentForm as FormLayout;

            if (parentFormLayout != null)
            {
                parentFormLayout.loadForm(new FormCategory());
            }
        }
    }
}
