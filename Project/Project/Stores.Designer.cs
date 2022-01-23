namespace Project
{
    partial class Stores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.storeName = new System.Windows.Forms.TextBox();
            this.storeAddress = new System.Windows.Forms.TextBox();
            this.lableNameStore = new System.Windows.Forms.Label();
            this.labelAddressStore = new System.Windows.Forms.Label();
            this.Add_Stor_Btn = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.storeOfProductGridView = new System.Windows.Forms.DataGridView();
            this.storeGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.storeOfProductGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // storeName
            // 
            this.storeName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeName.Location = new System.Drawing.Point(239, 121);
            this.storeName.Name = "storeName";
            this.storeName.Size = new System.Drawing.Size(223, 26);
            this.storeName.TabIndex = 0;
            // 
            // storeAddress
            // 
            this.storeAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeAddress.Location = new System.Drawing.Point(239, 213);
            this.storeAddress.Name = "storeAddress";
            this.storeAddress.Size = new System.Drawing.Size(223, 26);
            this.storeAddress.TabIndex = 1;
            // 
            // lableNameStore
            // 
            this.lableNameStore.AutoSize = true;
            this.lableNameStore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableNameStore.ForeColor = System.Drawing.SystemColors.Control;
            this.lableNameStore.Location = new System.Drawing.Point(102, 121);
            this.lableNameStore.Name = "lableNameStore";
            this.lableNameStore.Size = new System.Drawing.Size(50, 18);
            this.lableNameStore.TabIndex = 2;
            this.lableNameStore.Text = "Name";
            // 
            // labelAddressStore
            // 
            this.labelAddressStore.AutoSize = true;
            this.labelAddressStore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddressStore.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAddressStore.Location = new System.Drawing.Point(102, 213);
            this.labelAddressStore.Name = "labelAddressStore";
            this.labelAddressStore.Size = new System.Drawing.Size(67, 18);
            this.labelAddressStore.TabIndex = 3;
            this.labelAddressStore.Text = "Address";
            // 
            // Add_Stor_Btn
            // 
            this.Add_Stor_Btn.AnimationHoverSpeed = 0.07F;
            this.Add_Stor_Btn.AnimationSpeed = 0.03F;
            this.Add_Stor_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Add_Stor_Btn.BorderColor = System.Drawing.Color.Black;
            this.Add_Stor_Btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.Add_Stor_Btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.Add_Stor_Btn.CheckedForeColor = System.Drawing.Color.White;
            this.Add_Stor_Btn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("Add_Stor_Btn.CheckedImage")));
            this.Add_Stor_Btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.Add_Stor_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_Stor_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Add_Stor_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.Add_Stor_Btn.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.Add_Stor_Btn.ForeColor = System.Drawing.Color.White;
            this.Add_Stor_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Add_Stor_Btn.Image")));
            this.Add_Stor_Btn.ImageSize = new System.Drawing.Size(60, 60);
            this.Add_Stor_Btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Add_Stor_Btn.Location = new System.Drawing.Point(525, 121);
            this.Add_Stor_Btn.Name = "Add_Stor_Btn";
            this.Add_Stor_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Add_Stor_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Add_Stor_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.Add_Stor_Btn.OnHoverImage = null;
            this.Add_Stor_Btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Add_Stor_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.Add_Stor_Btn.Size = new System.Drawing.Size(160, 172);
            this.Add_Stor_Btn.TabIndex = 6;
            this.Add_Stor_Btn.Text = "Add Store";
            this.Add_Stor_Btn.Click += new System.EventHandler(this.Add_Stor_Btn_Click_1);
            // 
            // storeOfProductGridView
            // 
            this.storeOfProductGridView.AllowUserToAddRows = false;
            this.storeOfProductGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeOfProductGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.storeOfProductGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.storeOfProductGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.storeOfProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storeOfProductGridView.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.storeOfProductGridView.Location = new System.Drawing.Point(275, 288);
            this.storeOfProductGridView.Name = "storeOfProductGridView";
            this.storeOfProductGridView.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeOfProductGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.storeOfProductGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.storeOfProductGridView.Size = new System.Drawing.Size(640, 162);
            this.storeOfProductGridView.TabIndex = 7;
            // 
            // storeGridView2
            // 
            this.storeGridView2.AllowUserToAddRows = false;
            this.storeGridView2.AllowUserToDeleteRows = false;
            this.storeGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.storeGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.storeGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storeGridView2.Location = new System.Drawing.Point(1, 288);
            this.storeGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.storeGridView2.Name = "storeGridView2";
            this.storeGridView2.ReadOnly = true;
            this.storeGridView2.Size = new System.Drawing.Size(274, 162);
            this.storeGridView2.TabIndex = 8;
            this.storeGridView2.SelectionChanged += new System.EventHandler(this.storeGridView2_SelectionChanged);
            // 
            // Stores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.storeGridView2);
            this.Controls.Add(this.storeOfProductGridView);
            this.Controls.Add(this.Add_Stor_Btn);
            this.Controls.Add(this.labelAddressStore);
            this.Controls.Add(this.lableNameStore);
            this.Controls.Add(this.storeAddress);
            this.Controls.Add(this.storeName);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stores";
            ((System.ComponentModel.ISupportInitialize)(this.storeOfProductGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox storeName;
        private System.Windows.Forms.TextBox storeAddress;
        private System.Windows.Forms.Label lableNameStore;
        private System.Windows.Forms.Label labelAddressStore;
        private Guna.UI.WinForms.GunaAdvenceTileButton Add_Stor_Btn;
        private System.Windows.Forms.DataGridView storeOfProductGridView;
        private System.Windows.Forms.DataGridView storeGridView2;
    }
}