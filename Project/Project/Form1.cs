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
    public partial class Form1 : Form
    {
        int move, movex, movey;
        List<Category> categories = new List<Category>();
        List<Product> products = new List<Product>();
        List<Store> stores = new List<Store>();
        List<Supplier> suppliers = new List<Supplier>();
        List<Customer> customers = new List<Customer>();
        public Form1()
        {
            InitializeComponent();
        }
        private void AddCategory(Category obj)
        {
            categories.Add(obj);
        }

        private void AddStore(Store obj)
        {
            stores.Add(obj);
            //MessageBox.Show(stores[0].Name);
        }
        private void AddProduct(Product obj)
        {
            products.Add(obj);
            foreach (Store item in stores)
            {
                if(item.Name == obj.Store)
                {
                    item.Products.Add(obj);
                }
            }
            foreach (Category item in categories)
            {
                if (item.Name == obj.Category)
                {
                    item.Products.Add(obj);
                }
            }
        }

        private void AddSupplier(Supplier supplier)
        {
            suppliers.Add(supplier);
        }

        private void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        #region HeadBar
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized; 
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movex = e.X;
            movey = e.Y;
        }

        private void storeBtnOpen_Click(object sender, EventArgs e)
        {
            Stores store = new Stores(stores);
            store.MdiParent = this;
            store.Show();
            store.Dock = DockStyle.Fill;
            store.AddStoreEvent += AddStore;
        }


        private void productBtn_Click(object sender, EventArgs e)
        {
            ProductsForm productform = new ProductsForm(products,categories,stores);
            productform.MdiParent = this;
            productform.Show();
            productform.Dock = DockStyle.Fill;
            productform.AddProductEvent += AddProduct;
        }

        private void categorybtnForm_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm(categories);
            categoryForm.MdiParent = this;
            categoryForm.Show();
            categoryForm.Dock = DockStyle.Fill;
            categoryForm.AddCategoryEvent += AddCategory;
        }

        private void SupplierButton_Click(object sender, EventArgs e)
        {
            SupplierForm Supplierform = new SupplierForm(suppliers);
            Supplierform.MdiParent = this;
            Supplierform.Show();
            Supplierform.Dock = DockStyle.Fill;
            Supplierform.AddSupplier += AddSupplier;
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            CustomerForm Supplierform = new CustomerForm(customers);
            Supplierform.MdiParent = this;
            Supplierform.Show();
            Supplierform.Dock = DockStyle.Fill;
            Supplierform.AddCustomer += AddCustomer;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movex, MousePosition.Y - movey);
            }
        }
        #endregion
   
    }
}
