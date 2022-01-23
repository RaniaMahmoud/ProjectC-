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
    public partial class CategoryForm : Form
    {
        public event Action<Category> AddCategoryEvent;
        private IReadOnlyList<Category> categories;
        public CategoryForm(IReadOnlyList<Category> _categories)
        {
            InitializeComponent();
            categories = _categories;
            if (_categories.Count > 0)
            {
                categoryGridView.DataSource = null;
                categoryGridView.DataSource = categories;
            }
        }
        private void categoryBtnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Name = nameTextBoxCategory.Text;
            if (nameTextBoxCategory.Text.Length > 0)
            {
                if (AddCategoryEvent != null)
                {
                    AddCategoryEvent(category);
                }
                categoryGridView.DataSource = null;
                categoryGridView.DataSource = categories;
            }
            else
            {
                MessageBox.Show("plz Enter Name of Category......");
            }
        }

        private void categoryGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (categoryGridView.SelectedRows.Count > 0)
            {
                //MessageBox.Show(categoryGridView.SelectedRows[0].Index.ToString());
                productOfCategoryGridView.DataSource = null;
                if (categories[categoryGridView.SelectedRows[0].Index].Products.Count > 0)
                {
                    productOfCategoryGridView.DataSource = categories[categoryGridView.SelectedRows[0].Index].Products;
                }
                else
                {
                    MessageBox.Show("No Product In This Category......");
                }
            }
        }

    }
}
