namespace kiosk
{
    partial class ManageMenu
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
            this.btnEditMenu = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMenuImage = new System.Windows.Forms.Button();
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
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MenuImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditMenu
            // 
            this.btnEditMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEditMenu.FlatAppearance.BorderSize = 0;
            this.btnEditMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMenu.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditMenu.Location = new System.Drawing.Point(124, 447);
            this.btnEditMenu.Name = "btnEditMenu";
            this.btnEditMenu.Size = new System.Drawing.Size(266, 57);
            this.btnEditMenu.TabIndex = 46;
            this.btnEditMenu.Text = "메뉴수정";
            this.btnEditMenu.UseVisualStyleBackColor = false;
            this.btnEditMenu.Click += new System.EventHandler(this.btnEditMenu_Click);
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
            this.btnBack.TabIndex = 45;
            this.btnBack.Text = "뒤로가기";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnMenuImage
            // 
            this.btnMenuImage.BackColor = System.Drawing.Color.SkyBlue;
            this.btnMenuImage.FlatAppearance.BorderSize = 0;
            this.btnMenuImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuImage.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuImage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMenuImage.Location = new System.Drawing.Point(46, 297);
            this.btnMenuImage.Name = "btnMenuImage";
            this.btnMenuImage.Size = new System.Drawing.Size(262, 57);
            this.btnMenuImage.TabIndex = 44;
            this.btnMenuImage.Text = "이미지 수정";
            this.btnMenuImage.UseVisualStyleBackColor = false;
            this.btnMenuImage.Click += new System.EventHandler(this.btnMenuImage_Click);
            // 
            // MenuImage
            // 
            this.MenuImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuImage.Location = new System.Drawing.Point(46, 77);
            this.MenuImage.Margin = new System.Windows.Forms.Padding(2);
            this.MenuImage.Name = "MenuImage";
            this.MenuImage.Size = new System.Drawing.Size(262, 201);
            this.MenuImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuImage.TabIndex = 43;
            this.MenuImage.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(42, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 42;
            this.label4.Text = "메뉴이미지";
            // 
            // txtMenuType
            // 
            this.txtMenuType.BackColor = System.Drawing.Color.White;
            this.txtMenuType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMenuType.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtMenuType.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtMenuType.FormattingEnabled = true;
            this.txtMenuType.Items.AddRange(new object[] {
            "음료",
            "디저트"});
            this.txtMenuType.Location = new System.Drawing.Point(330, 161);
            this.txtMenuType.Margin = new System.Windows.Forms.Padding(2);
            this.txtMenuType.Name = "txtMenuType";
            this.txtMenuType.Size = new System.Drawing.Size(136, 34);
            this.txtMenuType.TabIndex = 41;
            // 
            // txtMenuPrice
            // 
            this.txtMenuPrice.BackColor = System.Drawing.Color.White;
            this.txtMenuPrice.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtMenuPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtMenuPrice.Location = new System.Drawing.Point(330, 319);
            this.txtMenuPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtMenuPrice.Name = "txtMenuPrice";
            this.txtMenuPrice.Size = new System.Drawing.Size(136, 33);
            this.txtMenuPrice.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(328, 295);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "메뉴가격";
            // 
            // txtMenuDesc
            // 
            this.txtMenuDesc.BackColor = System.Drawing.Color.White;
            this.txtMenuDesc.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtMenuDesc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtMenuDesc.Location = new System.Drawing.Point(330, 243);
            this.txtMenuDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtMenuDesc.Name = "txtMenuDesc";
            this.txtMenuDesc.Size = new System.Drawing.Size(136, 33);
            this.txtMenuDesc.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(328, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "메뉴설명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(328, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "메뉴종류";
            // 
            // txtMenuName
            // 
            this.txtMenuName.BackColor = System.Drawing.Color.White;
            this.txtMenuName.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtMenuName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtMenuName.Location = new System.Drawing.Point(330, 75);
            this.txtMenuName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(136, 33);
            this.txtMenuName.TabIndex = 35;
            // 
            // labelMenuName
            // 
            this.labelMenuName.AutoSize = true;
            this.labelMenuName.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.labelMenuName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelMenuName.Location = new System.Drawing.Point(328, 51);
            this.labelMenuName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMenuName.Name = "labelMenuName";
            this.labelMenuName.Size = new System.Drawing.Size(70, 24);
            this.labelMenuName.TabIndex = 34;
            this.labelMenuName.Text = "메뉴이름";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.White;
            this.txtQuantity.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtQuantity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtQuantity.Location = new System.Drawing.Point(330, 392);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(136, 33);
            this.txtQuantity.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(328, 368);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 24);
            this.label5.TabIndex = 47;
            this.label5.Text = "재고";
            // 
            // ManageMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 625);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEditMenu);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMenuImage);
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
            this.Name = "ManageMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManageMenu";
            this.Load += new System.EventHandler(this.ManageMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MenuImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditMenu;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnMenuImage;
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
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label5;
    }
}