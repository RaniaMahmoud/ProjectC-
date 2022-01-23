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
    public partial class Stores : Form
    {
        public event Action<Store> AddStoreEvent;
        private IReadOnlyList<Store> stores ;
        //private IReadOnlyList<Product> products;
        public Stores(IReadOnlyList<Store> _stores)
        {
            InitializeComponent();
            stores = _stores;
            if(_stores.Count > 0)
            {
                storeGridView2.DataSource = null;
                storeGridView2.DataSource = _stores;
            }
        }
        private void Add_Stor_Btn_Click_1(object sender, EventArgs e)
        {
            Store store = new Store();
            store.Name = storeName.Text.ToString();
            store.Address = storeAddress.Text.ToString();
            if (storeName.Text.Length > 0 && storeAddress.Text.Length > 0)
            {
                if (AddStoreEvent != null)
                {
                    AddStoreEvent(store);
                }
                storeGridView2.DataSource = null;
                storeGridView2.DataSource = stores;
            }
            else
            {
                MessageBox.Show("Name Or Address Emptyee......");
            }
        }

        private void storeGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (storeGridView2.SelectedRows.Count > 0)
            {
                //MessageBox.Show(categoryGridView.SelectedRows[0].Index.ToString());
                storeOfProductGridView.DataSource = null;
                if (stores[storeGridView2.SelectedRows[0].Index].Products.Count > 0)
                {
                    storeOfProductGridView.DataSource = stores[storeGridView2.SelectedRows[0].Index].Products;
                }
                else
                {
                    MessageBox.Show("No Product In This Category......");
                }
            }
        }
    }
}
