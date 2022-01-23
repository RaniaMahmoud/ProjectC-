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
    public partial class SupplierForm : Form
    {
        public event Action<Supplier> AddSupplier;
        IReadOnlyList<Supplier> suppliers;
        public SupplierForm(IReadOnlyList<Supplier> _suppliers)
        {
            InitializeComponent();
            suppliers = _suppliers;
            if (_suppliers.Count > 0)
            {
                SupplierDataGridView2.DataSource = null;
                SupplierDataGridView2.DataSource = _suppliers;
            }
        }

        private void Supplier_Click(object sender, EventArgs e)
        {
            int PhoneNumber;
            bool PhoneCheck = int.TryParse(SupplierTextBoxphone.Text, out PhoneNumber);
            if(PhoneCheck 
                && SupplierTextBoxphone.Text[0] == '0'
                && SupplierTextBoxphone.Text[1] == '1'
                && (SupplierTextBoxphone.Text[2] == '0'|| SupplierTextBoxphone.Text[2] == '5'|| SupplierTextBoxphone.Text[2] == '1')
                && SupplierTextBoxphone.TextLength == 3
                && SupplierTextBoxAddress.TextLength > 3
                && SupplierBoxname.TextLength > 3)
            {
                Supplier supplier = new Supplier(SupplierBoxname.Text, SupplierTextBoxphone.Text, SupplierTextBoxAddress.Text);
                if(AddSupplier != null)
                {
                    AddSupplier(supplier);
                }
                SupplierDataGridView2.DataSource = null;
                SupplierDataGridView2.DataSource = suppliers;
            }
            else
            {
                MessageBox.Show("Insert Valid Data.............");
            }
        }

        private void categoryGridView_SelectionChanged_1(object sender, EventArgs e)
        {
        }

    }
}
