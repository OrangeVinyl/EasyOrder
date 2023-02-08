namespace AddMenu
{
    partial class Form1
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
            this.txtMenuImg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMenuDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMenuPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddMenu = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMenuName
            // 
            this.labelMenuName.AutoSize = true;
            this.labelMenuName.Location = new System.Drawing.Point(390, 96);
            this.labelMenuName.Name = "labelMenuName";
            this.labelMenuName.Size = new System.Drawing.Size(106, 24);
            this.labelMenuName.TabIndex = 0;
            this.labelMenuName.Text = "메뉴이름";
            // 
            // txtMenuName
            // 
            this.txtMenuName.Location = new System.Drawing.Point(394, 144);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(250, 35);
            this.txtMenuName.TabIndex = 1;
            // 
            // txtMenuImg
            // 
            this.txtMenuImg.Location = new System.Drawing.Point(394, 278);
            this.txtMenuImg.Name = "txtMenuImg";
            this.txtMenuImg.Size = new System.Drawing.Size(250, 35);
            this.txtMenuImg.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "메뉴사진";
            // 
            // txtMenuDesc
            // 
            this.txtMenuDesc.Location = new System.Drawing.Point(394, 418);
            this.txtMenuDesc.Name = "txtMenuDesc";
            this.txtMenuDesc.Size = new System.Drawing.Size(250, 35);
            this.txtMenuDesc.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "메뉴설명";
            // 
            // txtMenuPrice
            // 
            this.txtMenuPrice.Location = new System.Drawing.Point(394, 570);
            this.txtMenuPrice.Name = "txtMenuPrice";
            this.txtMenuPrice.Size = new System.Drawing.Size(250, 35);
            this.txtMenuPrice.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "메뉴가격";
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.Location = new System.Drawing.Point(394, 664);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(245, 63);
            this.btnAddMenu.TabIndex = 8;
            this.btnAddMenu.Text = "메뉴추가";
            this.btnAddMenu.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(394, 761);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(245, 63);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "뒤로가기";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 872);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddMenu);
            this.Controls.Add(this.txtMenuPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMenuDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMenuImg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMenuName);
            this.Controls.Add(this.labelMenuName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMenuName;
        private System.Windows.Forms.TextBox txtMenuName;
        private System.Windows.Forms.TextBox txtMenuImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMenuDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMenuPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddMenu;
        private System.Windows.Forms.Button btnBack;
    }
}

