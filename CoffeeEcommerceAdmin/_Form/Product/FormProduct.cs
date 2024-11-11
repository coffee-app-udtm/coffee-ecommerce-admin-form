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
using CoffeeEcommerceAdmin._Form.Size;
using CoffeeEcommerceAdmin._Form.Topping;

using CoffeeLibrary.Request;
using ProductModel = CoffeeLibrary.Model.Product;
using CategoryModel = CoffeeLibrary.Model.Category;

namespace CoffeeEcommerceAdmin._Form.Product
{
    public partial class FormProduct : Form
    {
        ProductRequest productRequest = new ProductRequest();
        CategoryRequest categoryRequest = new CategoryRequest();

        List<ProductModel> products = new List<ProductModel>();

        public FormProduct()
        {
            InitializeComponent();

            this.button_category_form.Click += Button_category_form_Click;
            this.button_size_form.Click += Button_size_form_Click;
            this.button_topping_form.Click += Button_topping_form_Click;
            this.button_create_product_form.Click += Button_create_product_form_Click;

            this.button_search.Click += Button_search_Click;

            RenderProductsGridView();
            RenderCategoryCombobox();
        }

        private async void RenderProductsGridView()
        {
            products = await productRequest.GetProductsAsync(null, 0);

            dataGridView_products.DataSource = products;

            // Đổi tên cột
            dataGridView_products.Columns["id"].HeaderText = "ID";
            dataGridView_products.Columns["name"].HeaderText = "Tên";
            dataGridView_products.Columns["price"].HeaderText = "Giá";
            dataGridView_products.Columns["category_name"].HeaderText = "Danh mục";
            dataGridView_products.Columns["status"].HeaderText = "Trạng thái";


            // Ẩn cột
            dataGridView_products.Columns["category_id"].Visible = false;
            dataGridView_products.Columns["description"].Visible = false;

        }

        private async void RenderCategoryCombobox()
        {
            comboBox_category.Items.Clear();


            List<CategoryModel> categories = await categoryRequest.GetCategoriesAsync();

            categories.Insert(0, new CategoryModel
            {
                id = 0,
                category_name = "Tất cả"
            });



            comboBox_category.DataSource = categories;
            comboBox_category.DisplayMember = "category_name";
            comboBox_category.ValueMember = "id";
        }

        private void FilterProducts()
        {
            string searchValue = textBox_search.Text.Trim();
            int selectedCategoryId = comboBox_category.SelectedValue != null ? (int)comboBox_category.SelectedValue : 0;

            List<ProductModel> filteredProducts = products;

            if (!string.IsNullOrEmpty(searchValue))
            {
                filteredProducts = filteredProducts
                    .Where(product => product.name.ToLower().Contains(searchValue.ToLower()))
                    .ToList();
            }

            if (selectedCategoryId > 0)
            {
                filteredProducts = filteredProducts
                    .Where(product => product.category_id == selectedCategoryId)
                    .ToList();
            }

            dataGridView_products.DataSource = filteredProducts;

            // Đổi tên cột
            dataGridView_products.Columns["id"].HeaderText = "ID";
            dataGridView_products.Columns["name"].HeaderText = "Tên";
            dataGridView_products.Columns["price"].HeaderText = "Giá";
            dataGridView_products.Columns["category_name"].HeaderText = "Danh mục";
            dataGridView_products.Columns["status"].HeaderText = "Trạng thái";


            // Ẩn cột
            dataGridView_products.Columns["category_id"].Visible = false;
            dataGridView_products.Columns["description"].Visible = false;



        }

        private void Button_search_Click(object sender, EventArgs e)
        {
            FilterProducts();
        }

        private void Button_create_product_form_Click(object sender, EventArgs e)
        {
            FormLayout parentFormLayout = this.ParentForm as FormLayout;

            if (parentFormLayout != null)
            {
                parentFormLayout.loadForm(new FormCreateProduct());
            }
        }

        private void Button_topping_form_Click(object sender, EventArgs e)
        {
            FormLayout parentFormLayout = this.ParentForm as FormLayout;

            if (parentFormLayout != null)
            {
                parentFormLayout.loadForm(new FormTopping());
            }
        }

        private void Button_size_form_Click(object sender, EventArgs e)
        {
            FormLayout parentFormLayout = this.ParentForm as FormLayout;

            if (parentFormLayout != null)
            {
                parentFormLayout.loadForm(new FormSize());
            }
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
