using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
            CreateGridView();
        }
        
        private int Total = 0;

        private void chkCaoVoi_CheckedChanged(object sender, EventArgs e)
        {
            txtTotal.Text = "";
            if (chkCaoVoi.Checked == true)
                Total += 100;
            else
                Total -= 100;            
        }

        private void chkTayTrang_CheckedChanged(object sender, EventArgs e)
        {
            txtTotal.Text = "";
            if (chkTayTrang.Checked == true)
                Total += 1200;
            else
                Total -= 1200;
        }

        private void chkChupHinhRang_CheckedChanged(object sender, EventArgs e)
        {
            txtTotal.Text = "";
            if (chkChupHinhRang.Checked == true)
                Total += 200;
            else
                Total -= 200;
        }

        private void nudTramRang_ValueChanged(object sender, EventArgs e)
        {
            txtTotal.Text = "";
            NumericUpDown num = (NumericUpDown)sender;
            if (Convert.ToInt32(num.Text) > num.Value)
                Total -= 80;
            else
                Total += 80;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {            
            this.Dispose();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "")
            {
                MessageBox.Show("Chưa nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;                
            }
                        
            txtTotal.Text = "$" + Total * 1000;
            GhiDuLieu();
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            Bai02_dvw dvwNhatKi = new Bai02_dvw();
            dvwNhatKi.Controls.Add(dvw);
            dvwNhatKi.ShowDialog();
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "")
            {
                MessageBox.Show("Chưa tính tiền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (FileStream fs = new FileStream("HoaDon.txt", FileMode.Create, FileAccess.Write))
            {
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("Tên khách hàng\t\t " + txtTenKH.Text);
                if (chkCaoVoi.Checked == true)
                    sw.WriteLine("Cạo vôi\t\t\t $100.000");
                if (chkTayTrang.Checked == true)
                    sw.WriteLine("Tẩy Trắng\t\t $1.200.000");
                if (chkChupHinhRang.Checked == true)
                    sw.WriteLine("Chụp Hình Răng\t\t $200.000");
                if (nudTramRang.Value != 0)
                    sw.WriteLine("Trám Răng\t\t $80.000 * " + nudTramRang.Value.ToString());
                sw.WriteLine("Tổng Tiền:\t\t " + txtTotal.Text);
                MessageBox.Show("Đã xuất hóa đơn HoaDon.txt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sw.Close();
            }
        }

        private void GhiDuLieu()
        {
            dvw.Rows.Add(1);
            int indexRow = dvw.Rows.Count - 1;
            dvw[0, indexRow].Value = txtTenKH.Text;
            dvw[1, indexRow].Value = chkCaoVoi.Checked;
            dvw[2, indexRow].Value = chkTayTrang.Checked;
            dvw[3, indexRow].Value = chkChupHinhRang.Checked;
            dvw[4, indexRow].Value = nudTramRang.Value.ToString();
            dvw[5, indexRow].Value = txtTotal.Text;
        }

        DataGridView dvw = new DataGridView();            
        
        private void CreateGridView()
        {
            DataGridViewColumn colHoTen = new DataGridViewTextBoxColumn();
            DataGridViewColumn colCaoVoi = new DataGridViewCheckBoxColumn();
            DataGridViewColumn colTayTrang = new DataGridViewCheckBoxColumn();
            DataGridViewColumn colChupHinhRang = new DataGridViewCheckBoxColumn();
            DataGridViewColumn colTramRang = new DataGridViewTextBoxColumn();
            DataGridViewColumn colTongTien = new DataGridViewTextBoxColumn();

            dvw.AllowUserToDeleteRows = false;
            dvw.AllowUserToAddRows = false;
            dvw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvw.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dvw.Columns.AddRange(new DataGridViewColumn[] {
            colHoTen,
            colCaoVoi,
            colTayTrang,
            colChupHinhRang,
            colTramRang,
            colTongTien});
            dvw.Location = new Point(12, 12);
            dvw.Name = "dvw";
            dvw.ReadOnly = true;
            dvw.Size = new Size(580, 300);
            dvw.TabIndex = 0;

            colHoTen.HeaderText = "Họ Tên";
            colHoTen.Name = "colHoTen";
            colHoTen.ReadOnly = true;
            colHoTen.Width = 150;
            
            colCaoVoi.HeaderText = "Cạo Vôi";
            colCaoVoi.Name = "colCaoVoi";
            colCaoVoi.ReadOnly = true;
            colCaoVoi.Resizable = DataGridViewTriState.False;
            colCaoVoi.Width = 80;
             
            colTayTrang.HeaderText = "Tẩy Trắng";
            colTayTrang.Name = "colTayTrang";
            colTayTrang.ReadOnly = true;
            colTayTrang.Resizable = DataGridViewTriState.False;
            colTayTrang.Width = 80;
             
            colChupHinhRang.HeaderText = "Chụp Hình Răng";
            colChupHinhRang.Name = "colChupHinhRang";
            colChupHinhRang.ReadOnly = true;
            colChupHinhRang.Resizable = DataGridViewTriState.False;            
            colChupHinhRang.Width = 80;

            dvw.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colTramRang.HeaderText = "Trám Răng";
            colTramRang.Name = "colTramRang";
            colTramRang.ReadOnly = true;
            colTramRang.Resizable = DataGridViewTriState.False;            
            colTramRang.Width = 90;

            dvw.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colTongTien.HeaderText = "Tổng Tiền";
            colTongTien.Name = "colTongTien";
            colTongTien.ReadOnly = true;
            colTongTien.Resizable = DataGridViewTriState.False;
            colTongTien.Width = 100;
        }

    }
}
