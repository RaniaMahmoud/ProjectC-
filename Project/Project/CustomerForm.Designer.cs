namespace Project
{
    partial class CustomerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.CustomerDataGridView2 = new System.Windows.Forms.DataGridView();
            this.AddressLabel = new Guna.UI.WinForms.GunaLabel();
            this.PhoneCustomer = new Guna.UI.WinForms.GunaLabel();
            this.nameCustomer = new Guna.UI.WinForms.GunaLabel();
            this.CustomerTextBoxAddress = new Guna.UI.WinForms.GunaLineTextBox();
            this.CustomerTextBoxphone = new Guna.UI.WinForms.GunaLineTextBox();
            this.CustomerBoxname = new Guna.UI.WinForms.GunaLineTextBox();
            this.CustomerBtn = new Guna.UI.WinForms.GunaAdvenceTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerDataGridView2
            // 
            this.CustomerDataGridView2.AllowUserToAddRows = false;
            this.CustomerDataGridView2.AllowUserToDeleteRows = false;
            this.CustomerDataGridView2.AllowUserToResizeColumns = false;
            this.CustomerDataGridView2.AllowUserToResizeRows = false;
            this.CustomerDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerDataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CustomerDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CustomerDataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.CustomerDataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CustomerDataGridView2.EnableHeadersVisualStyles = false;
            this.CustomerDataGridView2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CustomerDataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerDataGridView2.Location = new System.Drawing.Point(0, 324);
            this.CustomerDataGridView2.Name = "CustomerDataGridView2";
            this.CustomerDataGridView2.ReadOnly = true;
            this.CustomerDataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.CustomerDataGridView2.RowHeadersWidth = 51;
            this.CustomerDataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.CustomerDataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerDataGridView2.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CustomerDataGridView2.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.CustomerDataGridView2.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CustomerDataGridView2.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.CustomerDataGridView2.Size = new System.Drawing.Size(879, 150);
            this.CustomerDataGridView2.TabIndex = 39;
            this.CustomerDataGridView2.SelectionChanged += new System.EventHandler(this.CustomerDataGridView2_SelectionChanged);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.AddressLabel.Location = new System.Drawing.Point(62, 226);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(82, 28);
            this.AddressLabel.TabIndex = 37;
            this.AddressLabel.Text = "Address";
            // 
            // PhoneCustomer
            // 
            this.PhoneCustomer.AutoSize = true;
            this.PhoneCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneCustomer.ForeColor = System.Drawing.SystemColors.Control;
            this.PhoneCustomer.Location = new System.Drawing.Point(62, 170);
            this.PhoneCustomer.Name = "PhoneCustomer";
            this.PhoneCustomer.Size = new System.Drawing.Size(67, 28);
            this.PhoneCustomer.TabIndex = 36;
            this.PhoneCustomer.Text = "Phone";
            // 
            // nameCustomer
            // 
            this.nameCustomer.AutoSize = true;
            this.nameCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameCustomer.ForeColor = System.Drawing.SystemColors.Control;
            this.nameCustomer.Location = new System.Drawing.Point(62, 115);
            this.nameCustomer.Name = "nameCustomer";
            this.nameCustomer.Size = new System.Drawing.Size(64, 28);
            this.nameCustomer.TabIndex = 35;
            this.nameCustomer.Text = "Name";
            // 
            // CustomerTextBoxAddress
            // 
            this.CustomerTextBoxAddress.BackColor = System.Drawing.Color.White;
            this.CustomerTextBoxAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerTextBoxAddress.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CustomerTextBoxAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CustomerTextBoxAddress.LineColor = System.Drawing.Color.Gainsboro;
            this.CustomerTextBoxAddress.Location = new System.Drawing.Point(234, 226);
            this.CustomerTextBoxAddress.Name = "CustomerTextBoxAddress";
            this.CustomerTextBoxAddress.PasswordChar = '\0';
            this.CustomerTextBoxAddress.SelectedText = "";
            this.CustomerTextBoxAddress.Size = new System.Drawing.Size(215, 30);
            this.CustomerTextBoxAddress.TabIndex = 34;
            // 
            // CustomerTextBoxphone
            // 
            this.CustomerTextBoxphone.BackColor = System.Drawing.Color.White;
            this.CustomerTextBoxphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerTextBoxphone.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CustomerTextBoxphone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CustomerTextBoxphone.LineColor = System.Drawing.Color.Gainsboro;
            this.CustomerTextBoxphone.Location = new System.Drawing.Point(234, 170);
            this.CustomerTextBoxphone.Name = "CustomerTextBoxphone";
            this.CustomerTextBoxphone.PasswordChar = '\0';
            this.CustomerTextBoxphone.SelectedText = "";
            this.CustomerTextBoxphone.Size = new System.Drawing.Size(215, 30);
            this.CustomerTextBoxphone.TabIndex = 33;
            // 
            // CustomerBoxname
            // 
            this.CustomerBoxname.BackColor = System.Drawing.Color.White;
            this.CustomerBoxname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerBoxname.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CustomerBoxname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CustomerBoxname.LineColor = System.Drawing.Color.Gainsboro;
            this.CustomerBoxname.Location = new System.Drawing.Point(234, 115);
            this.CustomerBoxname.Name = "CustomerBoxname";
            this.CustomerBoxname.PasswordChar = '\0';
            this.CustomerBoxname.SelectedText = "";
            this.CustomerBoxname.Size = new System.Drawing.Size(215, 30);
            this.CustomerBoxname.TabIndex = 32;
            // 
            // CustomerBtn
            // 
            this.CustomerBtn.AnimationHoverSpeed = 0.07F;
            this.CustomerBtn.AnimationSpeed = 0.03F;
            this.CustomerBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CustomerBtn.BorderColor = System.Drawing.Color.Black;
            this.CustomerBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.CustomerBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.CustomerBtn.CheckedForeColor = System.Drawing.Color.White;
            this.CustomerBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("CustomerBtn.CheckedImage")));
            this.CustomerBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.CustomerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CustomerBtn.FocusedColor = System.Drawing.Color.Empty;
            this.CustomerBtn.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.CustomerBtn.ForeColor = System.Drawing.Color.White;
            this.CustomerBtn.Image = ((System.Drawing.Image)(resources.GetObject("CustomerBtn.Image")));
            this.CustomerBtn.ImageSize = new System.Drawing.Size(60, 60);
            this.CustomerBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CustomerBtn.Location = new System.Drawing.Point(583, 100);
            this.CustomerBtn.Name = "CustomerBtn";
            this.CustomerBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CustomerBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CustomerBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.CustomerBtn.OnHoverImage = null;
            this.CustomerBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CustomerBtn.OnPressedColor = System.Drawing.Color.Black;
            this.CustomerBtn.Size = new System.Drawing.Size(156, 166);
            this.CustomerBtn.TabIndex = 38;
            this.CustomerBtn.Text = "Add Customer";
            this.CustomerBtn.Click += new System.EventHandler(this.CustomerBtn_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(879, 474);
            this.ControlBox = false;
            this.Controls.Add(this.CustomerDataGridView2);
            this.Controls.Add(this.CustomerBtn);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.PhoneCustomer);
            this.Controls.Add(this.nameCustomer);
            this.Controls.Add(this.CustomerTextBoxAddress);
            this.Controls.Add(this.CustomerTextBoxphone);
            this.Controls.Add(this.CustomerBoxname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerDataGridView2;
        private Guna.UI.WinForms.GunaAdvenceTileButton CustomerBtn;
        private Guna.UI.WinForms.GunaLabel AddressLabel;
        private Guna.UI.WinForms.GunaLabel PhoneCustomer;
        private Guna.UI.WinForms.GunaLabel nameCustomer;
        private Guna.UI.WinForms.GunaLineTextBox CustomerTextBoxAddress;
        private Guna.UI.WinForms.GunaLineTextBox CustomerTextBoxphone;
        private Guna.UI.WinForms.GunaLineTextBox CustomerBoxname;
    }
}