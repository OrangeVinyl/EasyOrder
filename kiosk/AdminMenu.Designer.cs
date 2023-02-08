namespace kiosk
{
    partial class AdminMenu
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStock = new System.Windows.Forms.Button();
            this.btnAddMenu = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnManageOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.SkyBlue;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStock.Location = new System.Drawing.Point(128, 176);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(262, 57);
            this.btnStock.TabIndex = 30;
            this.btnStock.Text = "메뉴관리";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAddMenu.FlatAppearance.BorderSize = 0;
            this.btnAddMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMenu.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddMenu.Location = new System.Drawing.Point(128, 259);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(262, 57);
            this.btnAddMenu.TabIndex = 31;
            this.btnAddMenu.Text = "메뉴추가";
            this.btnAddMenu.UseVisualStyleBackColor = false;
            this.btnAddMenu.Click += new System.EventHandler(this.btnAddMenu_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSales.Location = new System.Drawing.Point(128, 342);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(262, 57);
            this.btnSales.TabIndex = 32;
            this.btnSales.Text = "매출관리";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(128, 476);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(262, 57);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "뒤로가기";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnManageOrder
            // 
            this.btnManageOrder.BackColor = System.Drawing.Color.SkyBlue;
            this.btnManageOrder.FlatAppearance.BorderSize = 0;
            this.btnManageOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageOrder.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnManageOrder.Location = new System.Drawing.Point(128, 97);
            this.btnManageOrder.Name = "btnManageOrder";
            this.btnManageOrder.Size = new System.Drawing.Size(262, 57);
            this.btnManageOrder.TabIndex = 34;
            this.btnManageOrder.Text = "주문관리";
            this.btnManageOrder.UseVisualStyleBackColor = false;
            this.btnManageOrder.Click += new System.EventHandler(this.btnManageOrder_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 625);
            this.Controls.Add(this.btnManageOrder);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnAddMenu);
            this.Controls.Add(this.btnStock);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnAddMenu;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnManageOrder;
    }
}

