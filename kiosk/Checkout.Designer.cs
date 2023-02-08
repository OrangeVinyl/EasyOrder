namespace kiosk
{
    partial class Checkout
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
            this.txtTot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTot
            // 
            this.txtTot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTot.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTot.Location = new System.Drawing.Point(47, 273);
            this.txtTot.Name = "txtTot";
            this.txtTot.Size = new System.Drawing.Size(424, 42);
            this.txtTot.TabIndex = 33;
            this.txtTot.Text = "결제중입니다...";
            this.txtTot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 625);
            this.Controls.Add(this.txtTot);
            this.Name = "Checkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.Click += new System.EventHandler(this.button1_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtTot;
    }
}