namespace QuanLyQuanCafe
{
    partial class fTableManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nmFoodCount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnAddFood = new Guna.UI2.WinForms.Guna2CircleButton();
            this.cbFood = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.cbSwitchTable = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSwitchTable = new Guna.UI2.WinForms.Guna2Button();
            this.txbTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.nmDisCount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDisCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1228, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(637, 160);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(582, 523);
            this.panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(8, 4);
            this.lsvBill.Margin = new System.Windows.Forms.Padding(4);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(570, 514);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            this.lsvBill.SelectedIndexChanged += new System.EventHandler(this.lsvBill_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 133;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 54;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 81;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCheckOut);
            this.panel3.Controls.Add(this.nmDisCount);
            this.panel3.Controls.Add(this.txbTotalPrice);
            this.panel3.Controls.Add(this.btnSwitchTable);
            this.panel3.Controls.Add(this.cbSwitchTable);
            this.panel3.Location = new System.Drawing.Point(637, 686);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(582, 88);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nmFoodCount);
            this.panel4.Controls.Add(this.btnAddFood);
            this.panel4.Controls.Add(this.cbFood);
            this.panel4.Controls.Add(this.cbCategory);
            this.panel4.Location = new System.Drawing.Point(637, 37);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(578, 119);
            this.panel4.TabIndex = 4;
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.BackColor = System.Drawing.Color.Transparent;
            this.nmFoodCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmFoodCount.DisabledState.Parent = this.nmFoodCount;
            this.nmFoodCount.FocusedState.Parent = this.nmFoodCount;
            this.nmFoodCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nmFoodCount.ForeColor = System.Drawing.Color.Black;
            this.nmFoodCount.Location = new System.Drawing.Point(470, 34);
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.ShadowDecoration.Parent = this.nmFoodCount;
            this.nmFoodCount.Size = new System.Drawing.Size(103, 36);
            this.nmFoodCount.TabIndex = 7;
            this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddFood
            // 
            this.btnAddFood.CheckedState.Parent = this.btnAddFood;
            this.btnAddFood.CustomImages.Parent = this.btnAddFood;
            this.btnAddFood.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFood.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddFood.DisabledState.Parent = this.btnAddFood;
            this.btnAddFood.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.ForeColor = System.Drawing.Color.White;
            this.btnAddFood.HoverState.Parent = this.btnAddFood;
            this.btnAddFood.Location = new System.Drawing.Point(316, 4);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddFood.ShadowDecoration.Parent = this.btnAddFood;
            this.btnAddFood.Size = new System.Drawing.Size(148, 94);
            this.btnAddFood.TabIndex = 6;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click_1);
            // 
            // cbFood
            // 
            this.cbFood.BackColor = System.Drawing.Color.Transparent;
            this.cbFood.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFood.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFood.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFood.FocusedState.Parent = this.cbFood;
            this.cbFood.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFood.HoverState.Parent = this.cbFood;
            this.cbFood.ItemHeight = 30;
            this.cbFood.ItemsAppearance.Parent = this.cbFood;
            this.cbFood.Location = new System.Drawing.Point(4, 62);
            this.cbFood.Name = "cbFood";
            this.cbFood.ShadowDecoration.Parent = this.cbFood;
            this.cbFood.Size = new System.Drawing.Size(306, 36);
            this.cbFood.TabIndex = 5;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategory.FocusedState.Parent = this.cbCategory;
            this.cbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCategory.HoverState.Parent = this.cbCategory;
            this.cbCategory.ItemHeight = 30;
            this.cbCategory.ItemsAppearance.Parent = this.cbCategory;
            this.cbCategory.Location = new System.Drawing.Point(4, 4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.ShadowDecoration.Parent = this.cbCategory;
            this.cbCategory.Size = new System.Drawing.Size(306, 36);
            this.cbCategory.TabIndex = 4;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged_1);
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(20, 33);
            this.flpTable.Margin = new System.Windows.Forms.Padding(4);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(609, 741);
            this.flpTable.TabIndex = 5;
            this.flpTable.Paint += new System.Windows.Forms.PaintEventHandler(this.flpTable_Paint);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cbSwitchTable
            // 
            this.cbSwitchTable.BackColor = System.Drawing.Color.Transparent;
            this.cbSwitchTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSwitchTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSwitchTable.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSwitchTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSwitchTable.FocusedState.Parent = this.cbSwitchTable;
            this.cbSwitchTable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSwitchTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSwitchTable.HoverState.Parent = this.cbSwitchTable;
            this.cbSwitchTable.ItemHeight = 30;
            this.cbSwitchTable.ItemsAppearance.Parent = this.cbSwitchTable;
            this.cbSwitchTable.Location = new System.Drawing.Point(8, 46);
            this.cbSwitchTable.Name = "cbSwitchTable";
            this.cbSwitchTable.ShadowDecoration.Parent = this.cbSwitchTable;
            this.cbSwitchTable.Size = new System.Drawing.Size(184, 36);
            this.cbSwitchTable.TabIndex = 8;
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.AutoRoundedCorners = true;
            this.btnSwitchTable.BackColor = System.Drawing.Color.Transparent;
            this.btnSwitchTable.BorderRadius = 17;
            this.btnSwitchTable.CheckedState.Parent = this.btnSwitchTable;
            this.btnSwitchTable.CustomImages.Parent = this.btnSwitchTable;
            this.btnSwitchTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSwitchTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSwitchTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSwitchTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSwitchTable.DisabledState.Parent = this.btnSwitchTable;
            this.btnSwitchTable.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitchTable.ForeColor = System.Drawing.Color.White;
            this.btnSwitchTable.HoverState.Parent = this.btnSwitchTable;
            this.btnSwitchTable.Location = new System.Drawing.Point(8, 4);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.ShadowDecoration.Parent = this.btnSwitchTable;
            this.btnSwitchTable.Size = new System.Drawing.Size(184, 36);
            this.btnSwitchTable.TabIndex = 9;
            this.btnSwitchTable.Text = "Chuyển bàn";
            this.btnSwitchTable.Click += new System.EventHandler(this.btnSwitchTable_Click_1);
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTotalPrice.DefaultText = "0";
            this.txbTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTotalPrice.DisabledState.Parent = this.txbTotalPrice;
            this.txbTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTotalPrice.Enabled = false;
            this.txbTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTotalPrice.FocusedState.Parent = this.txbTotalPrice;
            this.txbTotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTotalPrice.HoverState.Parent = this.txbTotalPrice;
            this.txbTotalPrice.Location = new System.Drawing.Point(218, 4);
            this.txbTotalPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.PasswordChar = '\0';
            this.txbTotalPrice.PlaceholderText = "";
            this.txbTotalPrice.SelectedText = "";
            this.txbTotalPrice.SelectionStart = 1;
            this.txbTotalPrice.ShadowDecoration.Parent = this.txbTotalPrice;
            this.txbTotalPrice.Size = new System.Drawing.Size(191, 36);
            this.txbTotalPrice.TabIndex = 10;
            // 
            // nmDisCount
            // 
            this.nmDisCount.BackColor = System.Drawing.Color.Transparent;
            this.nmDisCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmDisCount.DisabledState.Parent = this.nmDisCount;
            this.nmDisCount.FocusedState.Parent = this.nmDisCount;
            this.nmDisCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nmDisCount.ForeColor = System.Drawing.Color.Black;
            this.nmDisCount.Location = new System.Drawing.Point(218, 47);
            this.nmDisCount.Name = "nmDisCount";
            this.nmDisCount.ShadowDecoration.Parent = this.nmDisCount;
            this.nmDisCount.Size = new System.Drawing.Size(191, 36);
            this.nmDisCount.TabIndex = 11;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.AutoRoundedCorners = true;
            this.btnCheckOut.BorderRadius = 38;
            this.btnCheckOut.CheckedState.Parent = this.btnCheckOut;
            this.btnCheckOut.CustomImages.Parent = this.btnCheckOut;
            this.btnCheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckOut.DisabledState.Parent = this.btnCheckOut;
            this.btnCheckOut.FillColor = System.Drawing.Color.Tomato;
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.HoverState.Parent = this.btnCheckOut;
            this.btnCheckOut.Location = new System.Drawing.Point(416, 9);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.ShadowDecoration.Parent = this.btnCheckOut;
            this.btnCheckOut.Size = new System.Drawing.Size(157, 79);
            this.btnCheckOut.TabIndex = 12;
            this.btnCheckOut.Text = "Thanh toán";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click_1);
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1228, 780);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán cafe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDisCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2ComboBox cbCategory;
        private Guna.UI2.WinForms.Guna2ComboBox cbFood;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddFood;
        private Guna.UI2.WinForms.Guna2NumericUpDown nmFoodCount;
        private Guna.UI2.WinForms.Guna2ComboBox cbSwitchTable;
        private Guna.UI2.WinForms.Guna2Button btnSwitchTable;
        private Guna.UI2.WinForms.Guna2TextBox txbTotalPrice;
        private Guna.UI2.WinForms.Guna2NumericUpDown nmDisCount;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
    }
}