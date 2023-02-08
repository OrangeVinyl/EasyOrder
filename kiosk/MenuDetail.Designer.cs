namespace kiosk
{
    partial class MenuDetail
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddMenu = new System.Windows.Forms.Button();
            this.MenuImage = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMenuType = new System.Windows.Forms.ComboBox();
            this.txtMenuPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMenuDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMenuName = new System.Windows.Forms.TextBox();
            this.labelMenuName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MenuImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(195, 469);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(132, 32);
            this.btnBack.TabIndex = 43;
            this.btnBack.Text = "뒤로가기";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAddMenu.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.btnAddMenu.Location = new System.Drawing.Point(175, 394);
            this.btnAddMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(266, 57);
            this.btnAddMenu.TabIndex = 42;
            this.btnAddMenu.Text = "메뉴추가";
            this.btnAddMenu.UseVisualStyleBackColor = false;
            // 
            // MenuImage
            // 
            this.MenuImage.Location = new System.Drawing.Point(46, 80);
            this.MenuImage.Margin = new System.Windows.Forms.Padding(2);
            this.MenuImage.Name = "MenuImage";
            this.MenuImage.Size = new System.Drawing.Size(262, 201);
            this.MenuImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuImage.TabIndex = 38;
            this.MenuImage.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(42, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "메뉴이미지";
            // 
            // txtMenuType
            // 
            this.txtMenuType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMenuType.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtMenuType.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtMenuType.FormattingEnabled = true;
            this.txtMenuType.Items.AddRange(new object[] {
            "음료",
            "디저트"});
            this.txtMenuType.Location = new System.Drawing.Point(330, 149);
            this.txtMenuType.Margin = new System.Windows.Forms.Padding(2);
            this.txtMenuType.Name = "txtMenuType";
            this.txtMenuType.Size = new System.Drawing.Size(136, 34);
            this.txtMenuType.TabIndex = 36;
            // 
            // txtMenuPrice
            // 
            this.txtMenuPrice.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtMenuPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtMenuPrice.Location = new System.Drawing.Point(330, 284);
            this.txtMenuPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtMenuPrice.Name = "txtMenuPrice";
            this.txtMenuPrice.Size = new System.Drawing.Size(136, 33);
            this.txtMenuPrice.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(328, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "메뉴가격";
            // 
            // txtMenuDesc
            // 
            this.txtMenuDesc.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtMenuDesc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtMenuDesc.Location = new System.Drawing.Point(330, 216);
            this.txtMenuDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtMenuDesc.Name = "txtMenuDesc";
            this.txtMenuDesc.Size = new System.Drawing.Size(136, 33);
            this.txtMenuDesc.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(328, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "메뉴설명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(328, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "메뉴종류";
            // 
            // txtMenuName
            // 
            this.txtMenuName.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtMenuName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtMenuName.Location = new System.Drawing.Point(330, 80);
            this.txtMenuName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(136, 33);
            this.txtMenuName.TabIndex = 30;
            // 
            // labelMenuName
            // 
            this.labelMenuName.AutoSize = true;
            this.labelMenuName.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.labelMenuName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelMenuName.Location = new System.Drawing.Point(328, 56);
            this.labelMenuName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMenuName.Name = "labelMenuName";
            this.labelMenuName.Size = new System.Drawing.Size(70, 24);
            this.labelMenuName.TabIndex = 29;
            this.labelMenuName.Text = "메뉴이름";
            // 
            // MenuDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 625);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddMenu);
            this.Controls.Add(this.MenuImage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMenuType);
            this.Controls.Add(this.txtMenuPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMenuDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMenuName);
            this.Controls.Add(this.labelMenuName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MenuDetail";
            this.Load += new System.EventHandler(this.MenuDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MenuImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddMenu;
        private System.Windows.Forms.PictureBox MenuImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtMenuType;
        private System.Windows.Forms.TextBox txtMenuPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMenuDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMenuName;
        private System.Windows.Forms.Label labelMenuName;
    }
}