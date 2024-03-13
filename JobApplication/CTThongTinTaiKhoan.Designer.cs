namespace JobApplication
{
    partial class CTThongTinTaiKhoan
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
            this.thongTinTaiKhoan1 = new JobApplication.ThongTinTaiKhoan();
            this.SuspendLayout();
            // 
            // thongTinTaiKhoan1
            // 
            this.thongTinTaiKhoan1.Location = new System.Drawing.Point(0, 0);
            this.thongTinTaiKhoan1.Name = "thongTinTaiKhoan1";
            this.thongTinTaiKhoan1.Size = new System.Drawing.Size(1600, 800);
            this.thongTinTaiKhoan1.TabIndex = 0;
            // 
            // CTThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 753);
            this.Controls.Add(this.thongTinTaiKhoan1);
            this.Name = "CTThongTinTaiKhoan";
            this.Text = "CTThongTinTaiKhoan";
            this.ResumeLayout(false);

        }

        #endregion

        private ThongTinTaiKhoan thongTinTaiKhoan1;
    }
}