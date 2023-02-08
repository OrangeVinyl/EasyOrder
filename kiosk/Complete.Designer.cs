namespace kiosk
{
    partial class Complete
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
            this.txtOrderNum = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.txtMethod = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menu_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menu_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menu_quantity2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.총액 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "결제가 완료되었습니다!";
            // 
            // txtOrderNum
            // 
            this.txtOrderNum.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderNum.Location = new System.Drawing.Point(12, 91);
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.Size = new System.Drawing.Size(473, 33);
            this.txtOrderNum.TabIndex = 7;
            this.txtOrderNum.Text = "주문 번호 :";
            this.txtOrderNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderDate.Location = new System.Drawing.Point(12, 139);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(473, 33);
            this.txtOrderDate.TabIndex = 8;
            this.txtOrderDate.Text = "주문일 :";
            this.txtOrderDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(12, 187);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(473, 33);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.Text = "주문 총액 :";
            this.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMethod
            // 
            this.txtMethod.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMethod.Location = new System.Drawing.Point(12, 237);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(473, 33);
            this.txtMethod.TabIndex = 10;
            this.txtMethod.Text = "결제 방법 :";
            this.txtMethod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.menu_name,
            this.menu_price,
            this.menu_quantity2,
            this.총액});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(37, 306);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(426, 215);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // menu_name
            // 
            this.menu_name.Text = "메뉴명";
            this.menu_name.Width = 138;
            // 
            // menu_price
            // 
            this.menu_price.Text = "가격";
            // 
            // menu_quantity2
            // 
            this.menu_quantity2.Text = "갯수";
            // 
            // 총액
            // 
            this.총액.Text = "총액";
            // 
            // Complete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 625);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtMethod);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.txtOrderNum);
            this.Controls.Add(this.label1);
            this.Name = "Complete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Complete";
            this.Load += new System.EventHandler(this.Complete_Load);
            this.Click += new System.EventHandler(this.form_click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtOrderNum;
        private System.Windows.Forms.Label txtOrderDate;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader menu_name;
        private System.Windows.Forms.ColumnHeader menu_price;
        private System.Windows.Forms.ColumnHeader menu_quantity2;
        private System.Windows.Forms.ColumnHeader 총액;
        private System.Windows.Forms.Label txtMethod;
    }
}