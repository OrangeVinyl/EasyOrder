namespace kiosk
{
    partial class Point
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnPointOut = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "적립하시려면 전화번호를 입력해주세요.";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(107, 241);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(297, 1);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel4.Location = new System.Drawing.Point(0, -9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(297, 10);
            this.panel4.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.Control;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPhone.Location = new System.Drawing.Point(107, 213);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(300, 26);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // btnPointOut
            // 
            this.btnPointOut.BackColor = System.Drawing.Color.SkyBlue;
            this.btnPointOut.FlatAppearance.BorderSize = 0;
            this.btnPointOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPointOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPointOut.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPointOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPointOut.Location = new System.Drawing.Point(125, 316);
            this.btnPointOut.Name = "btnPointOut";
            this.btnPointOut.Size = new System.Drawing.Size(266, 57);
            this.btnPointOut.TabIndex = 12;
            this.btnPointOut.Text = "적립하고 결제하기";
            this.btnPointOut.UseVisualStyleBackColor = false;
            this.btnPointOut.Click += new System.EventHandler(this.btnPointOut_Click);
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.SkyBlue;
            this.btnOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOut.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOut.Location = new System.Drawing.Point(125, 398);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(266, 57);
            this.btnOut.TabIndex = 11;
            this.btnOut.Text = "적립하지 않고 결제하기";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(125, 480);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(266, 57);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "뒤로가기";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(103, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "전화번호";
            // 
            // Point
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 625);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPointOut);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label1);
            this.Name = "Point";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Point";
            this.Load += new System.EventHandler(this.Point_Load);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnPointOut;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
    }
}