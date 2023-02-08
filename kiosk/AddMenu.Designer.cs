namespace kiosk
{
    partial class AddMenu
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
            this.labelMenuName = new System.Windows.Forms.Label();
            this.txtMenuName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMenuDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMenuPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMenuType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MenuImage = new System.Windows.Forms.PictureBox();
            this.btnMenuImage = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MenuImage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMenuName
            // 
            this.labelMenuName.AutoSize = true;
            this.labelMenuName.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.labelMenuName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelMenuName.Location = new System.Drawing.Point(323, 46);
            this.labelMenuName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMenuName.Name = "labelMenuName";
            this.labelMenuName.Size = new System.Drawing.Size(70, 24);
            this.labelMenuName.TabIndex = 0;
            this.labelMenuName.Text = "메뉴이름";
            // 
            // txtMenuName
            // 
            this.txtMenuName.BackColor = System.Drawing.Color.White;
            this.txtMenuName.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtMenuName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtMenuName.Location = new System.Drawing.Point(325, 70);
            this.txtMenuName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(136, 33);
            this.txtMenuName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(323, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "메뉴종류";
            // 
            // txtMenuDesc
            // 
            this.txtMenuDesc.BackColor = System.Drawing.Color.White;
            this.txtMenuDesc.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtMenuDesc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtMenuDesc.Location = new System.Drawing.Point(325, 238);
            this.txtMenuDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtMenuDesc.Name = "txtMenuDesc";
            this.txtMenuDesc.Size = new System.Drawing.Size(136, 33);
            this.txtMenuDesc.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(323, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "메뉴설명";
            // 
            // txtMenuPrice
            // 
            this.txtMenuPrice.BackColor = System.Drawing.Color.White;
            this.txtMenuPrice.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtMenuPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtMenuPrice.Location = new System.Drawing.Point(325, 314);
            this.txtMenuPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtMenuPrice.Name = "txtMenuPrice";
            this.txtMenuPrice.Size = new System.Drawing.Size(136, 33);
            this.txtMenuPrice.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(323, 290);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "메뉴가격";
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
            this.txtMenuType.Location = new System.Drawing.Point(325, 156);
            this.txtMenuType.Margin = new System.Windows.Forms.Padding(2);
            this.txtMenuType.Name = "txtMenuType";
            this.txtMenuType.Size = new System.Drawing.Size(136, 34);
            this.txtMenuType.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(37, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "메뉴이미지";
            // 
            // MenuImage
            // 
            this.MenuImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuImage.Location = new System.Drawing.Point(41, 72);
            this.MenuImage.Margin = new System.Windows.Forms.Padding(2);
            this.MenuImage.Name = "MenuImage";
            this.MenuImage.Size = new System.Drawing.Size(262, 201);
            this.MenuImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuImage.TabIndex = 12;
            this.MenuImage.TabStop = false;
            // 
            // btnMenuImage
            // 
            this.btnMenuImage.BackColor = System.Drawing.Color.SkyBlue;
            this.btnMenuImage.FlatAppearance.BorderSize = 0;
            this.btnMenuImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuImage.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuImage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMenuImage.Location = new System.Drawing.Point(41, 292);
            this.btnMenuImage.Name = "btnMenuImage";
            this.btnMenuImage.Size = new System.Drawing.Size(262, 57);
            this.btnMenuImage.TabIndex = 29;
            this.btnMenuImage.Text = "이미지 추가";
            this.btnMenuImage.UseVisualStyleBackColor = false;
            this.btnMenuImage.Click += new System.EventHandler(this.btnMenuImage_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(127, 511);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(266, 57);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "뒤로가기";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAddMenu.FlatAppearance.BorderSize = 0;
            this.btnAddMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMenu.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddMenu.Location = new System.Drawing.Point(127, 424);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(266, 57);
            this.btnAddMenu.TabIndex = 33;
            this.btnAddMenu.Text = "메뉴추가";
            this.btnAddMenu.UseVisualStyleBackColor = false;
            this.btnAddMenu.Click += new System.EventHandler(this.btnAddMenu_Click);
            // 
            // AddMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 625);
            this.Controls.Add(this.btnAddMenu);
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
            this.Name = "AddMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AddMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MenuImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMenuName;
        private System.Windows.Forms.TextBox txtMenuName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMenuDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMenuPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtMenuType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox MenuImage;
        private System.Windows.Forms.Button btnMenuImage;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddMenu;
    }
}

