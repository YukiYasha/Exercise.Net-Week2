namespace Ex01
{
    partial class Bai02
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.chkCaoVoi = new System.Windows.Forms.CheckBox();
            this.chkTayTrang = new System.Windows.Forms.CheckBox();
            this.chkChupHinhRang = new System.Windows.Forms.CheckBox();
            this.nudTramRang = new System.Windows.Forms.NumericUpDown();
            this.btnXuatHD = new System.Windows.Forms.Button();
            this.btnLuuHD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTramRang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(66, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dental Payment Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "$100.000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "$1.200.000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "$200.000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "$80.000/cái";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Trám răng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.ForeColor = System.Drawing.Color.Red;
            this.txtTenKH.Location = new System.Drawing.Point(151, 71);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(157, 22);
            this.txtTenKH.TabIndex = 8;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(188, 284);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(120, 22);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(33, 325);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 23);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(228, 325);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(80, 23);
            this.btnTinhTien.TabIndex = 11;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // chkCaoVoi
            // 
            this.chkCaoVoi.AutoSize = true;
            this.chkCaoVoi.BackColor = System.Drawing.SystemColors.Control;
            this.chkCaoVoi.Location = new System.Drawing.Point(33, 124);
            this.chkCaoVoi.Name = "chkCaoVoi";
            this.chkCaoVoi.Size = new System.Drawing.Size(62, 17);
            this.chkCaoVoi.TabIndex = 13;
            this.chkCaoVoi.Text = "Cạo vôi";
            this.chkCaoVoi.UseVisualStyleBackColor = false;
            this.chkCaoVoi.CheckedChanged += new System.EventHandler(this.chkCaoVoi_CheckedChanged);
            // 
            // chkTayTrang
            // 
            this.chkTayTrang.AutoSize = true;
            this.chkTayTrang.Location = new System.Drawing.Point(33, 159);
            this.chkTayTrang.Name = "chkTayTrang";
            this.chkTayTrang.Size = new System.Drawing.Size(71, 17);
            this.chkTayTrang.TabIndex = 14;
            this.chkTayTrang.Text = "Tẩy trắng";
            this.chkTayTrang.UseVisualStyleBackColor = true;
            this.chkTayTrang.CheckedChanged += new System.EventHandler(this.chkTayTrang_CheckedChanged);
            // 
            // chkChupHinhRang
            // 
            this.chkChupHinhRang.AutoSize = true;
            this.chkChupHinhRang.Location = new System.Drawing.Point(33, 194);
            this.chkChupHinhRang.Name = "chkChupHinhRang";
            this.chkChupHinhRang.Size = new System.Drawing.Size(98, 17);
            this.chkChupHinhRang.TabIndex = 15;
            this.chkChupHinhRang.Text = "Chụp hình răng";
            this.chkChupHinhRang.UseVisualStyleBackColor = true;
            this.chkChupHinhRang.CheckedChanged += new System.EventHandler(this.chkChupHinhRang_CheckedChanged);
            // 
            // nudTramRang
            // 
            this.nudTramRang.Location = new System.Drawing.Point(98, 225);
            this.nudTramRang.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.nudTramRang.Name = "nudTramRang";
            this.nudTramRang.ReadOnly = true;
            this.nudTramRang.Size = new System.Drawing.Size(72, 20);
            this.nudTramRang.TabIndex = 16;
            this.nudTramRang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTramRang.ValueChanged += new System.EventHandler(this.nudTramRang_ValueChanged);
            // 
            // btnXuatHD
            // 
            this.btnXuatHD.Location = new System.Drawing.Point(228, 363);
            this.btnXuatHD.Name = "btnXuatHD";
            this.btnXuatHD.Size = new System.Drawing.Size(80, 23);
            this.btnXuatHD.TabIndex = 17;
            this.btnXuatHD.Text = "Xuất hóa đơn";
            this.btnXuatHD.UseVisualStyleBackColor = true;
            this.btnXuatHD.Click += new System.EventHandler(this.btnXuatHD_Click);
            // 
            // btnLuuHD
            // 
            this.btnLuuHD.Location = new System.Drawing.Point(33, 363);
            this.btnLuuHD.Name = "btnLuuHD";
            this.btnLuuHD.Size = new System.Drawing.Size(80, 23);
            this.btnLuuHD.TabIndex = 18;
            this.btnLuuHD.Text = "Xem hóa đơn";
            this.btnLuuHD.UseVisualStyleBackColor = true;
            this.btnLuuHD.Click += new System.EventHandler(this.btnLuuHD_Click);
            // 
            // Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(345, 401);
            this.Controls.Add(this.btnLuuHD);
            this.Controls.Add(this.btnXuatHD);
            this.Controls.Add(this.nudTramRang);
            this.Controls.Add(this.chkChupHinhRang);
            this.Controls.Add(this.chkTayTrang);
            this.Controls.Add(this.chkCaoVoi);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Bai02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dental Payment Application";
            ((System.ComponentModel.ISupportInitialize)(this.nudTramRang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.CheckBox chkCaoVoi;
        private System.Windows.Forms.CheckBox chkTayTrang;
        private System.Windows.Forms.CheckBox chkChupHinhRang;
        private System.Windows.Forms.NumericUpDown nudTramRang;
        private System.Windows.Forms.Button btnXuatHD;
        private System.Windows.Forms.Button btnLuuHD;
    }
}