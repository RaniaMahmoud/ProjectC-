namespace Project
{
    partial class SupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierForm));
            this.Supplier = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.AddressLabel = new Guna.UI.WinForms.GunaLabel();
            this.PhoneSupplier = new Guna.UI.WinForms.GunaLabel();
            this.nameSupplier = new Guna.UI.WinForms.GunaLabel();
            this.SupplierTextBoxAddress = new Guna.UI.WinForms.GunaLineTextBox();
            this.SupplierTextBoxphone = new Guna.UI.WinForms.GunaLineTextBox();
            this.SupplierBoxname = new Guna.UI.WinForms.GunaLineTextBox();
            this.SupplierDataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Supplier
            // 
            this.Supplier.AnimationHoverSpeed = 0.07F;
            this.Supplier.AnimationSpeed = 0.03F;
            this.Supplier.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Supplier.BorderColor = System.Drawing.Color.Black;
            this.Supplier.CheckedBaseColor = System.Drawing.Color.Gray;
            this.Supplier.CheckedBorderColor = System.Drawing.Color.Black;
            this.Supplier.CheckedForeColor = System.Drawing.Color.White;
            this.Supplier.CheckedImage = ((System.Drawing.Image)(resources.GetObject("Supplier.CheckedImage")));
            this.Supplier.CheckedLineColor = System.Drawing.Color.DimGray;
            this.Supplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Supplier.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Supplier.FocusedColor = System.Drawing.Color.Empty;
            this.Supplier.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.Supplier.ForeColor = System.Drawing.Color.White;
            this.Supplier.Image = ((System.Drawing.Image)(resources.GetObject("Supplier.Image")));
            this.Supplier.ImageSize = new System.Drawing.Size(60, 60);
            this.Supplier.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Supplier.Location = new System.Drawing.Point(571, 77);
            this.Supplier.Name = "Supplier";
            this.Supplier.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Supplier.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Supplier.OnHoverForeColor = System.Drawing.Color.White;
            this.Supplier.OnHoverImage = null;
            this.Supplier.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Supplier.OnPressedColor = System.Drawing.Color.Black;
            this.Supplier.Size = new System.Drawing.Size(156, 166);
            this.Supplier.TabIndex = 30;
            this.Supplier.Text = "Add Supplier";
            this.Supplier.Click += new System.EventHandler(this.Supplier_Click);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.AddressLabel.Location = new System.Drawing.Point(50, 203);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(82, 28);
            this.AddressLabel.TabIndex = 28;
            this.AddressLabel.Text = "Address";
            // 
            // PhoneSupplier
            // 
            this.PhoneSupplier.AutoSize = true;
            this.PhoneSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneSupplier.ForeColor = System.Drawing.SystemColors.Control;
            this.PhoneSupplier.Location = new System.Drawing.Point(50, 147);
            this.PhoneSupplier.Name = "PhoneSupplier";
            this.PhoneSupplier.Size = new System.Drawing.Size(67, 28);
            this.PhoneSupplier.TabIndex = 27;
            this.PhoneSupplier.Text = "Phone";
            // 
            // nameSupplier
            // 
            this.nameSupplier.AutoSize = true;
            this.nameSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSupplier.ForeColor = System.Drawing.SystemColors.Control;
            this.nameSupplier.Location = new System.Drawing.Point(50, 92);
            this.nameSupplier.Name = "nameSupplier";
            this.nameSupplier.Size = new System.Drawing.Size(64, 28);
            this.nameSupplier.TabIndex = 26;
            this.nameSupplier.Text = "Name";
            // 
            // SupplierTextBoxAddress
            // 
            this.SupplierTextBoxAddress.BackColor = System.Drawing.Color.White;
            this.SupplierTextBoxAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SupplierTextBoxAddress.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SupplierTextBoxAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SupplierTextBoxAddress.LineColor = System.Drawing.Color.Gainsboro;
            this.SupplierTextBoxAddress.Location = new System.Drawing.Point(222, 203);
            this.SupplierTextBoxAddress.Name = "SupplierTextBoxAddress";
            this.SupplierTextBoxAddress.PasswordChar = '\0';
            this.SupplierTextBoxAddress.SelectedText = "";
            this.SupplierTextBoxAddress.Size = new System.Drawing.Size(215, 30);
            this.SupplierTextBoxAddress.TabIndex = 24;
            // 
            // SupplierTextBoxphone
            // 
            this.SupplierTextBoxphone.BackColor = System.Drawing.Color.White;
            this.SupplierTextBoxphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SupplierTextBoxphone.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SupplierTextBoxphone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SupplierTextBoxphone.LineColor = System.Drawing.Color.Gainsboro;
            this.SupplierTextBoxphone.Location = new System.Drawing.Point(222, 147);
            this.SupplierTextBoxphone.Name = "SupplierTextBoxphone";
            this.SupplierTextBoxphone.PasswordChar = '\0';
            this.SupplierTextBoxphone.SelectedText = "";
            this.SupplierTextBoxphone.Size = new System.Drawing.Size(215, 30);
            this.SupplierTextBoxphone.TabIndex = 23;
            // 
            // SupplierBoxname
            // 
            this.SupplierBoxname.BackColor = System.Drawing.Color.White;
            this.SupplierBoxname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SupplierBoxname.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SupplierBoxname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SupplierBoxname.LineColor = System.Drawing.Color.Gainsboro;
            this.SupplierBoxname.Location = new System.Drawing.Point(222, 92);
            this.SupplierBoxname.Name = "SupplierBoxname";
            this.SupplierBoxname.PasswordChar = '\0';
            this.SupplierBoxname.SelectedText = "";
            this.SupplierBoxname.Size = new System.Drawing.Size(215, 30);
            this.SupplierBoxname.TabIndex = 22;
            // 
            // SupplierDataGridView2
            // 
            this.SupplierDataGridView2.AllowUserToAddRows = false;
            this.SupplierDataGridView2.AllowUserToDeleteRows = false;
            this.SupplierDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SupplierDataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SupplierDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SupplierDataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.SupplierDataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.SupplierDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplierDataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SupplierDataGridView2.EnableHeadersVisualStyles = false;
            this.SupplierDataGridView2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.SupplierDataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SupplierDataGridView2.Location = new System.Drawing.Point(0, 300);
            this.SupplierDataGridView2.Name = "SupplierDataGridView2";
            this.SupplierDataGridView2.ReadOnly = true;
            this.SupplierDataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.SupplierDataGridView2.RowHeadersWidth = 51;
            this.SupplierDataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SupplierDataGridView2.Size = new System.Drawing.Size(800, 150);
            this.SupplierDataGridView2.TabIndex = 31;
            this.SupplierDataGridView2.SelectionChanged += new System.EventHandler(this.categoryGridView_SelectionChanged_1);
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.SupplierDataGridView2);
            this.Controls.Add(this.Supplier);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.PhoneSupplier);
            this.Controls.Add(this.nameSupplier);
            this.Controls.Add(this.SupplierTextBoxAddress);
            this.Controls.Add(this.SupplierTextBoxphone);
            this.Controls.Add(this.SupplierBoxname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            ((System.ComponentModel.ISupportInitialize)(this.SupplierDataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceTileButton Supplier;
        private Guna.UI.WinForms.GunaLabel AddressLabel;
        private Guna.UI.WinForms.GunaLabel PhoneSupplier;
        private Guna.UI.WinForms.GunaLabel nameSupplier;
        private Guna.UI.WinForms.GunaLineTextBox SupplierTextBoxAddress;
        private Guna.UI.WinForms.GunaLineTextBox SupplierTextBoxphone;
        private Guna.UI.WinForms.GunaLineTextBox SupplierBoxname;
        private System.Windows.Forms.DataGridView SupplierDataGridView2;
    }
}