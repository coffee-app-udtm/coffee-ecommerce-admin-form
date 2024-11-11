using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoffeeLibrary.Request;
using CoffeeLibrary;

using ToppingModel = CoffeeLibrary.Model.Topping;
using SizeModel = CoffeeLibrary.Model.Size;
using CategoryModel = CoffeeLibrary.Model.Category;
using CreateProductModel = CoffeeLibrary.Model.CreateProduct;
using ProductModel = CoffeeLibrary.Model.Product;

using CoffeeLibrary.Model;

namespace CoffeeEcommerceAdmin._Form.Product
{
    public partial class FormCreateProduct : Form
    {
        string productImageFilePath = "";
        List<int> product_toppings = new List<int>();
        List<ProductSize> product_sizes = new List<ProductSize>();

        ToppingRequest toppingRequest = new ToppingRequest();
        SizeRequest sizeRequest = new SizeRequest();
        CategoryRequest categoryRequest = new CategoryRequest();
        ProductRequest productRequest = new ProductRequest();

        public FormCreateProduct()
        {
            InitializeComponent(); 
            
            this.button_back_product.Click += Button_back_product_Click;
            this.button_upload_image.Click += Button_upload_image_Click;

            this.button_add_size.Click += Button_add_size_Click;

            this.listBox_product_sizes.KeyDown += listBox_product_sizes_KeyDown;

            this.button_submit.Click += Button_submit_Click;

            RenderToppingsCheckboxList();
            RenderSizesComboBox();
            RenderStatusComboBox();
            RenderCategoriesComboBox();

        }

        // Submit form
        private async void Button_submit_Click(object sender, EventArgs e)
        {
            try
            {
                bool isValid = CheckFormValid();

                if (!isValid)
                {
                    return;
                }

                // Display loading text on button
                button_submit.Text = "Đang tải...";
                button_submit.Enabled = false;

                // Get product name, category, status, price, description
                string productName = textBox_name.Text;
                int categoryId = comboBox_category.SelectedItem != null ? (comboBox_category.SelectedItem as CategoryModel).id : 0;
                string statusName = comboBox_status.SelectedItem.ToString();
                int status = statusName == "Đang bán" ? 0 : 1;
                decimal price = Decimal.Parse(textBox_price.Text);
                string description = textBox_description.Text;

                // Get checked checkboxes in toppings checkbox list
                product_toppings.Clear();

                for (int i = 0; i < checkedListBox_toppings.Items.Count; i++)
                {
                    if (checkedListBox_toppings.GetItemChecked(i))
                    {
                        string toppingId = checkedListBox_toppings.Items[i].ToString().Split('-')[0].Trim();
                        product_toppings.Add(int.Parse(toppingId));
                    }
                }


                // Create product model
                CreateProductModel product = new CreateProductModel
                {
                    name = productName,
                    category_id = categoryId,
                    status = status,
                    price = price,
                    description = description
                };

                // Check if the product has toppings
                if (product_toppings.Count > 0)
                {
                    product.product_toppings = product_toppings;
                }

                // Check if the product has sizes

                if (product_sizes.Count > 0)
                {
                    product.product_sizes = product_sizes;
                }

                // Upload product image
                string image = await productRequest.uploadProductImageAsync(productImageFilePath);

                if (image == null)
                {
                    throw new Exception("Có lỗi xảy ra khi tải ảnh lên");
                }

                product.image = image;

                // Create product
                ProductModel newProduct = await productRequest.CreateProductAsync(product);

                if (newProduct == null)
                {
                    throw new Exception("Có lỗi xảy ra khi thêm sản phẩm");
                }

                // Back to product form
                MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                button_submit.Text = "Thêm sản phẩm";
                button_submit.Enabled = true;

                FormLayout parentFormLayout = this.ParentForm as FormLayout;

                if (parentFormLayout != null)
                {
                    parentFormLayout.loadForm(new FormProduct());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                button_submit.Text = "Thêm sản phẩm";
                button_submit.Enabled = true;
            }
        }

        private void Button_upload_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Title = "Chọn hình sản phẩm"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(openFileDialog.FileName);

                productImageFilePath = openFileDialog.FileName;

            }
        }

        private void Button_back_product_Click(object sender, EventArgs e)
        {

            FormLayout parentFormLayout = this.ParentForm as FormLayout;

            if (parentFormLayout != null)
            {
                parentFormLayout.loadForm(new FormProduct());
            }
        }

        private void Button_add_size_Click(object sender, EventArgs e)
        {
            // Check if the size price is empty
            if (textBox_size_price.Text == "")
            {
                MessageBox.Show("Giá tiền không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the size price is a number
            if (!Decimal.TryParse(textBox_size_price.Text, out _))
            {
                MessageBox.Show("Giá tiền phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal sizePrice = Decimal.Parse(textBox_size_price.Text);

            // Check if the size price is valid
            if (sizePrice < 0)
            {
                MessageBox.Show("Giá tiền phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get sise id and size name from combobox
            int sizeId = (comboBox_sizes.SelectedItem as SizeModel).id;
            string sizeName = (comboBox_sizes.SelectedItem as SizeModel).size_name;


            // Check if the size is already in the list, update size price else add new size
            bool isSizeExist = false;
            foreach (ProductSize productSize in product_sizes)
            {
                if (productSize.size_id == sizeId)
                {
                    isSizeExist = true;
                    break;
                }
            }

            if (!isSizeExist)
            {
                product_sizes.Add(new ProductSize
                {
                    size_id = sizeId,
                    size_price = sizePrice
                });

                listBox_product_sizes.Items.Add(sizeName + " - " + Util.FormatVNCurrency(sizePrice));
            } else
            {
                MessageBox.Show("Kích thước đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void listBox_product_sizes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int selectedIndex = listBox_product_sizes.SelectedIndex;

                if (selectedIndex != -1)
                {
                    product_sizes.RemoveAt(selectedIndex);
                    listBox_product_sizes.Items.RemoveAt(selectedIndex);
                }
            }
        }


        private void FormCreateProduct_Load(object sender, EventArgs e)
        {

        }

        private bool CheckFormValid()
        {
            // Check if the product name, category, status, image, price, description is empty

            if (textBox_name.Text == "")
            {
                MessageBox.Show("Tên sản phẩm không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (comboBox_category.SelectedIndex == -1)
            {
                MessageBox.Show("Danh mục không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (comboBox_status.SelectedIndex == -1)
            {
                MessageBox.Show("Trạng thái không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (productImageFilePath == "")
            {
                MessageBox.Show("Hình ảnh không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (textBox_price.Text == "")
            {
                MessageBox.Show("Giá tiền không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Decimal.TryParse(textBox_price.Text, out _))
            {
                MessageBox.Show("Giá tiền phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (textBox_description.Text == "")
            {
                MessageBox.Show("Mô tả không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            return true;
        }

        private async void RenderToppingsCheckboxList()
        {
            // Get all toppings
            List<ToppingModel> toppings = await toppingRequest.GetToppingsAsync();

            // Render toppings checkbox list
            checkedListBox_toppings.Items.Clear();

            foreach (ToppingModel topping in toppings)
            {
                // Add the topping name to the CheckedListBox
                string displayText = topping.id + " - " + topping.topping_name + " - " + Util.FormatVNCurrency(topping.topping_price);
                
                checkedListBox_toppings.Items.Add(displayText);
            }
        }

        private async void RenderSizesComboBox()
        {
            // Get all sizes
            List<SizeModel> sizes = await sizeRequest.GetSizesAsync();

            // Render sizes combobox by data source
            comboBox_sizes.DataSource = sizes;
            comboBox_sizes.DisplayMember = "size_name";
            comboBox_sizes.ValueMember = "id";

        }

        private async void RenderStatusComboBox()
        {
            // Có 2 trạng thái 0 và 1

            // 0: Đang bán

            // 1: Ngừng bán

            comboBox_status.Items.Add("Đang bán");
            comboBox_status.Items.Add("Ngừng bán");

            comboBox_status.SelectedIndex = 0;

        }

        private async void RenderCategoriesComboBox()
        {
            // Get all categories
            List<CategoryModel> categories = await categoryRequest.GetCategoriesAsync();

            // Render categories combobox by data source
            comboBox_category.DataSource = categories;
            comboBox_category.DisplayMember = "category_name";
            comboBox_category.ValueMember = "id";

        }
    }
}
