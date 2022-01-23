namespace Project
{
    partial class CategoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            this.labllNameCategory = new Guna.UI.WinForms.GunaLabel();
            this.nameTextBoxCategory = new Guna.UI.WinForms.GunaTextBox();
            this.categoryBtnAdd = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.categoryGridView = new System.Windows.Forms.DataGridView();
            this.productOfCategoryGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productOfCategoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labllNameCategory
            // 
            this.labllNameCategory.AutoSize = true;
            this.labllNameCategory.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labllNameCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.labllNameCategory.Location = new System.Drawing.Point(105, 126);
            this.labllNameCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labllNameCategory.Name = "labllNameCategory";
            this.labllNameCategory.Size = new System.Drawing.Size(44, 20);
            this.labllNameCategory.TabIndex = 1;
            this.labllNameCategory.Text = "Name";
            // 
            // nameTextBoxCategory
            // 
            this.nameTextBoxCategory.BaseColor = System.Drawing.Color.White;
            this.nameTextBoxCategory.BorderColor = System.Drawing.Color.Silver;
            this.nameTextBoxCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBoxCategory.FocusedBaseColor = System.Drawing.Color.White;
            this.nameTextBoxCategory.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.nameTextBoxCategory.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.nameTextBoxCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameTextBoxCategory.Location = new System.Drawing.Point(238, 126);
            this.nameTextBoxCategory.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBoxCategory.Name = "nameTextBoxCategory";
            this.nameTextBoxCategory.PasswordChar = '\0';
            this.nameTextBoxCategory.SelectedText = "";
            this.nameTextBoxCategory.Size = new System.Drawing.Size(248, 32);
            this.nameTextBoxCategory.TabIndex = 2;
            // 
            // categoryBtnAdd
            // 
            this.categoryBtnAdd.AnimationHoverSpeed = 0.07F;
            this.categoryBtnAdd.AnimationSpeed = 0.03F;
            this.categoryBtnAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.categoryBtnAdd.BorderColor = System.Drawing.Color.Black;
            this.categoryBtnAdd.CheckedBaseColor = System.Drawing.Color.Gray;
            this.categoryBtnAdd.CheckedBorderColor = System.Drawing.Color.Black;
            this.categoryBtnAdd.CheckedForeColor = System.Drawing.Color.White;
            this.categoryBtnAdd.CheckedImage = ((System.Drawing.Image)(resources.GetObject("categoryBtnAdd.CheckedImage")));
            this.categoryBtnAdd.CheckedLineColor = System.Drawing.Color.DimGray;
            this.categoryBtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryBtnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.categoryBtnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.categoryBtnAdd.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.categoryBtnAdd.ForeColor = System.Drawing.Color.White;
            this.categoryBtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("categoryBtnAdd.Image")));
            this.categoryBtnAdd.ImageSize = new System.Drawing.Size(60, 60);
            this.categoryBtnAdd.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.categoryBtnAdd.Location = new System.Drawing.Point(573, 126);
            this.categoryBtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.categoryBtnAdd.Name = "categoryBtnAdd";
            this.categoryBtnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.categoryBtnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.categoryBtnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.categoryBtnAdd.OnHoverImage = null;
            this.categoryBtnAdd.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.categoryBtnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.categoryBtnAdd.Size = new System.Drawing.Size(144, 144);
            this.categoryBtnAdd.TabIndex = 3;
            this.categoryBtnAdd.Text = "Add Category";
            this.categoryBtnAdd.Click += new System.EventHandler(this.categoryBtnAdd_Click);
            // 
            // categoryGridView
            // 
            this.categoryGridView.AllowUserToAddRows = false;
            this.categoryGridView.AllowUserToDeleteRows = false;
            this.categoryGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.categoryGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryGridView.Location = new System.Drawing.Point(0, 317);
            this.categoryGridView.Margin = new System.Windows.Forms.Padding(4);
            this.categoryGridView.Name = "categoryGridView";
            this.categoryGridView.ReadOnly = true;
            this.categoryGridView.Size = new System.Drawing.Size(217, 133);
            this.categoryGridView.TabIndex = 4;
            this.categoryGridView.SelectionChanged += new System.EventHandler(this.categoryGridView_SelectionChanged);
            // 
            // productOfCategoryGridView
            // 
            this.productOfCategoryGridView.AllowUserToAddRows = false;
            this.productOfCategoryGridView.AllowUserToDeleteRows = false;
            this.productOfCategoryGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.productOfCategoryGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productOfCategoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productOfCategoryGridView.Location = new System.Drawing.Point(217, 317);
            this.productOfCategoryGridView.Name = "productOfCategoryGridView";
            this.productOfCategoryGridView.ReadOnly = true;
            this.productOfCategoryGridView.Size = new System.Drawing.Size(584, 133);
            this.productOfCategoryGridView.TabIndex = 5;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.productOfCategoryGridView);
            this.Controls.Add(this.categoryGridView);
            this.Controls.Add(this.categoryBtnAdd);
            this.Controls.Add(this.nameTextBoxCategory);
            this.Controls.Add(this.labllNameCategory);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productOfCategoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel labllNameCategory;
        private Guna.UI.WinForms.GunaTextBox nameTextBoxCategory;
        private Guna.UI.WinForms.GunaAdvenceTileButton categoryBtnAdd;
        private System.Windows.Forms.DataGridView categoryGridView;
        private System.Windows.Forms.DataGridView productOfCategoryGridView;
    }
}