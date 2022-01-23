using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ProductsForm : Form
    {
        public event Action<Product> AddProductEvent;
        private IReadOnlyList<Product> products;
        private IReadOnlyList<Category> categories;
        private IReadOnlyList<Store> stores;
        public ProductsForm(IReadOnlyList<Product> _products,IReadOnlyList<Category> _categories, IReadOnlyList<Store> _stores)
        {
            InitializeComponent();
            products = _products;
            categories = _categories;
            stores = _stores;

            if (_products.Count > 0)
            {
                productDataGridView.DataSource = null;
                productDataGridView.DataSource = _products;
            }
            if (_categories.Count > 0)
            {
                foreach (Category item in categories)
                {
                    categoryComBoxCategort.Items.Add(item.Name);
                }
            }
            if (_stores.Count > 0)
            {
                foreach (Store item in stores)
                {
                    storeComBoxCategort.Items.Add(item.Name);
                }
            }
        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = productTextBoxname.Text;
            //product.Price =double.TryParse(productTextBoxprice.Text);
            double priceTest;
            int QuantityTest;
            int GuaranteeTest;
            bool flagePrice = double.TryParse(productTextBoxprice.Text, out priceTest);
            bool flageQuantity =int.TryParse( productTextBoxQuantity.Text,out QuantityTest);
            bool flageGuarantee = int.TryParse(productTextBoxGuarantee.Text,out GuaranteeTest);
            if (flagePrice && flageQuantity &&
                flageGuarantee && productTextBoxname.Text.Length > 0 &&
                categoryComBoxCategort.SelectedIndex != -1 && storeComBoxCategort.SelectedIndex != -1
                )
            {
                product.Price = priceTest;
                product.Quantity = QuantityTest;
                product.Guarantee = GuaranteeTest;
                product.Category = categoryComBoxCategort.SelectedItem.ToString();
                product.Store = storeComBoxCategort.SelectedItem.ToString();
                if (AddProductEvent != null)
                {
                    AddProductEvent(product);
                }
                productDataGridView.DataSource = null;

                productDataGridView.DataSource = products;
            }
            else
            {
                MessageBox.Show("Insert Valid Data.............");
            }
        }

    }
    
}
