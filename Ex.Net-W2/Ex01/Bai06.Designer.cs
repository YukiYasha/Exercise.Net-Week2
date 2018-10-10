namespace Ex01
{
    partial class Bai06
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
            this.btnChonHinh = new System.Windows.Forms.Button();
            this.txtPicPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChonHinh.Location = new System.Drawing.Point(668, 22);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.Size = new System.Drawing.Size(83, 29);
            this.btnChonHinh.TabIndex = 5;
            this.btnChonHinh.Text = "Chọn Hình";
            this.btnChonHinh.UseVisualStyleBackColor = true;
            this.btnChonHinh.Click += new System.EventHandler(this.btnChonHinh_Click);
            // 
            // txtPicPath
            // 
            this.txtPicPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPicPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPicPath.Location = new System.Drawing.Point(12, 22);
            this.txtPicPath.Multiline = true;
            this.txtPicPath.Name = "txtPicPath";
            this.txtPicPath.Size = new System.Drawing.Size(640, 29);
            this.txtPicPath.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đường dẫn";
            // 
            // picPic
            // 
            this.picPic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picPic.Location = new System.Drawing.Point(12, 57);
            this.picPic.Name = "picPic";
            this.picPic.Size = new System.Drawing.Size(738, 433);
            this.picPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPic.TabIndex = 6;
            this.picPic.TabStop = false;
            // 
            // Bai06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 508);
            this.Controls.Add(this.picPic);
            this.Controls.Add(this.btnChonHinh);
            this.Controls.Add(this.txtPicPath);
            this.Controls.Add(this.label1);
            this.Name = "Bai06";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình xem ảnh";
            ((System.ComponentModel.ISupportInitialize)(this.picPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChonHinh;
        private System.Windows.Forms.TextBox txtPicPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picPic;
    }
}