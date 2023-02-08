namespace kiosk
{
    partial class MenuList
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
            this.StocklistView = new System.Windows.Forms.ListView();
            this.menu_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menu_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menu_quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteMenu = new System.Windows.Forms.Button();
            this.btnEditMenu = new System.Windows.Forms.Button();
            this.btnLookUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StocklistView
            // 
            this.StocklistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.menu_id,
            this.menu_name,
            this.menu_quantity});
            this.StocklistView.FullRowSelect = true;
            this.StocklistView.HideSelection = false;
            this.StocklistView.Location = new System.Drawing.Point(41, 26);
            this.StocklistView.Margin = new System.Windows.Forms.Padding(2);
            this.StocklistView.Name = "StocklistView";
            this.StocklistView.Size = new System.Drawing.Size(421, 280);
            this.StocklistView.TabIndex = 0;
            this.StocklistView.UseCompatibleStateImageBehavior = false;
            this.StocklistView.View = System.Windows.Forms.View.Details;
            this.StocklistView.SelectedIndexChanged += new System.EventHandler(this.StocklistView_SelectedIndexChanged);
            // 
            // menu_id
            // 
            this.menu_id.Text = "상품번호";
            this.menu_id.Width = 150;
            // 
            // menu_name
            // 
            this.menu_name.Text = "메뉴명";
            this.menu_name.Width = 189;
            // 
            // menu_quantity
            // 
            this.menu_quantity.Text = "재고";
            this.menu_quantity.Width = 210;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(124, 531);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(266, 57);
            this.btnBack.TabIndex = 46;
            this.btnBack.Text = "뒤로가기";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeleteMenu
            // 
            this.btnDeleteMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDeleteMenu.FlatAppearance.BorderSize = 0;
            this.btnDeleteMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMenu.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteMenu.Location = new System.Drawing.Point(339, 339);
            this.btnDeleteMenu.Name = "btnDeleteMenu";
            this.btnDeleteMenu.Size = new System.Drawing.Size(123, 57);
            this.btnDeleteMenu.TabIndex = 49;
            this.btnDeleteMenu.Text = "메뉴삭제";
            this.btnDeleteMenu.UseVisualStyleBackColor = false;
            this.btnDeleteMenu.Click += new System.EventHandler(this.btnDeleteMenu_Click);
            // 
            // btnEditMenu
            // 
            this.btnEditMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEditMenu.FlatAppearance.BorderSize = 0;
            this.btnEditMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMenu.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditMenu.Location = new System.Drawing.Point(191, 339);
            this.btnEditMenu.Name = "btnEditMenu";
            this.btnEditMenu.Size = new System.Drawing.Size(125, 57);
            this.btnEditMenu.TabIndex = 48;
            this.btnEditMenu.Text = "메뉴수정";
            this.btnEditMenu.UseVisualStyleBackColor = false;
            this.btnEditMenu.Click += new System.EventHandler(this.btnEditQuantity_Click);
            // 
            // btnLookUp
            // 
            this.btnLookUp.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLookUp.FlatAppearance.BorderSize = 0;
            this.btnLookUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLookUp.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookUp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLookUp.Location = new System.Drawing.Point(43, 339);
            this.btnLookUp.Name = "btnLookUp";
            this.btnLookUp.Size = new System.Drawing.Size(122, 57);
            this.btnLookUp.TabIndex = 47;
            this.btnLookUp.Text = "메뉴조회";
            this.btnLookUp.UseVisualStyleBackColor = false;
            this.btnLookUp.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 625);
            this.Controls.Add(this.btnDeleteMenu);
            this.Controls.Add(this.btnEditMenu);
            this.Controls.Add(this.btnLookUp);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.StocklistView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManageStock";
            this.Load += new System.EventHandler(this.ManageStock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView StocklistView;
        private System.Windows.Forms.ColumnHeader menu_name;
        private System.Windows.Forms.ColumnHeader menu_quantity;
        private System.Windows.Forms.ColumnHeader menu_id;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDeleteMenu;
        private System.Windows.Forms.Button btnEditMenu;
        private System.Windows.Forms.Button btnLookUp;
    }
}