namespace kiosk
{
    partial class Sales
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
            this.SaleslistView = new System.Windows.Forms.ListView();
            this.menu_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menu_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.order_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menu_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTot = new System.Windows.Forms.Label();
            this.txtHead = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaleslistView
            // 
            this.SaleslistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.menu_id,
            this.menu_name,
            this.order_count,
            this.menu_price});
            this.SaleslistView.FullRowSelect = true;
            this.SaleslistView.HideSelection = false;
            this.SaleslistView.Location = new System.Drawing.Point(48, 84);
            this.SaleslistView.Margin = new System.Windows.Forms.Padding(2);
            this.SaleslistView.Name = "SaleslistView";
            this.SaleslistView.Size = new System.Drawing.Size(421, 280);
            this.SaleslistView.TabIndex = 21;
            this.SaleslistView.UseCompatibleStateImageBehavior = false;
            this.SaleslistView.View = System.Windows.Forms.View.Details;
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
            // order_count
            // 
            this.order_count.Text = "판매수량";
            this.order_count.Width = 210;
            // 
            // menu_price
            // 
            this.menu_price.Text = "금액";
            // 
            // txtTot
            // 
            this.txtTot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTot.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTot.Location = new System.Drawing.Point(45, 395);
            this.txtTot.Name = "txtTot";
            this.txtTot.Size = new System.Drawing.Size(424, 42);
            this.txtTot.TabIndex = 33;
            this.txtTot.Text = "총 금액:";
            this.txtTot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHead
            // 
            this.txtHead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHead.Font = new System.Drawing.Font("Calibri", 25F);
            this.txtHead.Location = new System.Drawing.Point(48, 24);
            this.txtHead.Name = "txtHead";
            this.txtHead.Size = new System.Drawing.Size(421, 41);
            this.txtHead.TabIndex = 34;
            this.txtHead.Text = "매출기록";
            this.txtHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(123, 520);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(266, 57);
            this.btnBack.TabIndex = 35;
            this.btnBack.Text = "뒤로가기";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.SkyBlue;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.btnNext.Location = new System.Drawing.Point(428, 25);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(41, 43);
            this.btnNext.TabIndex = 37;
            this.btnNext.Text = "▷";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.SkyBlue;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.btnPrevious.Location = new System.Drawing.Point(49, 25);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(41, 43);
            this.btnPrevious.TabIndex = 36;
            this.btnPrevious.Text = "◁";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 625);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtHead);
            this.Controls.Add(this.txtTot);
            this.Controls.Add(this.SaleslistView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView SaleslistView;
        private System.Windows.Forms.ColumnHeader menu_id;
        private System.Windows.Forms.ColumnHeader menu_name;
        private System.Windows.Forms.ColumnHeader order_count;
        private System.Windows.Forms.ColumnHeader menu_price;
        private System.Windows.Forms.Label txtTot;
        private System.Windows.Forms.Label txtHead;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
    }
}