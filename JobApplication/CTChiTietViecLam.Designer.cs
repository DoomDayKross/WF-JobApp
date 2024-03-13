namespace JobApplication
{
    partial class CTChiTietViecLam
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
            this.chiTietViecLam1 = new JobApplication.ChiTietViecLam();
            this.SuspendLayout();
            // 
            // chiTietViecLam1
            // 
            this.chiTietViecLam1.Location = new System.Drawing.Point(0, 0);
            this.chiTietViecLam1.Name = "chiTietViecLam1";
            this.chiTietViecLam1.Size = new System.Drawing.Size(1600, 900);
            this.chiTietViecLam1.TabIndex = 0;
            // 
            // CTChiTietViecLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 753);
            this.Controls.Add(this.chiTietViecLam1);
            this.Name = "CTChiTietViecLam";
            this.Text = "CongTyChiTietViecLam";
            this.ResumeLayout(false);

        }

        #endregion

        private ChiTietViecLam chiTietViecLam1;
    }
}