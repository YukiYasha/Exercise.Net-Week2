using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01
{
    public partial class Bai01 : Form
    {
        int Day = 0, Month = 0, Year = 0;
        public Bai01()
        {            
            InitializeComponent();
            LoadCb();            
        }

        private void LoadCb()
        {
            //Load Ngày Tháng Năm vào cb tương ứng
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {            
            this.Dispose();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            btnTinhThu.Enabled = true;
            lblKQ.Visible = false;
            lblKQ.Text = "Hôm đó là ngày ";
        }

        private void cboNam_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboNam.Text == "")
                return;
            Year = int.Parse(cboNam.Text);

            if (Month == 2)
            {
                if (((Year % 4) == 0 && (Year % 100) == 0 && (Year % 400) == 0) || ((Year % 4) == 0 && (Year % 100) != 0))
                {
                    //danh sách ngày từ 1-29
                }
                else
                {
                    //danh sách ngày từ 1-28
                }
            }
        }

        private void cboThang_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboThang.Text == "")
                return;
            Month = int.Parse(cboThang.Text);

            if (Month == 1 || Month == 3 || Month == 5 || Month == 7 || Month == 8 || Month == 10 || Month == 12)
            {
                //danh sách ngày từ 1-31
            }
            else
            if (Month == 4 || Month == 6 || Month == 9 || Month == 11)
            {
                //danh sách ngày từ 1-30
            }
            else
                cboNam_SelectedValueChanged(sender, e);
        }

        private void btnTinhThu_Click(object sender, EventArgs e)
        {
            if(cboNam.Text == "" || cboThang.Text == "" || cboNgay.Text == "")
            {
                MessageBox.Show("Chọn đầy đủ Ngày Tháng Năm!!!", "Cảnh báo", MessageBoxButtons.RetryCancel);
            }
            else
            {
                DateTime date = new DateTime(Year, Month, Day);
                lblKQ.Text += TranslateDay((date.DayOfWeek).ToString());
                lblKQ.Visible = true;
                btnTinhThu.Enabled = false;
            }            
        }

        private string TranslateDay(string x)
        {
            switch(x)
            {
                case "Monday":
                    return "Thứ Hai";
                case "Tueday":
                    return "Thứ Ba";
                case "Wednesday":
                    return "Thứ Tư";
                case "Thursday":
                    return "Thứ Năm";
                case "Friday":
                    return "Thứ Sáu";
                case "Saturday":
                    return "Thứ Bảy";
                case "Sunday":
                    return "Chủ Nhật";
                default:
                    return "Không có ngày";
            }
        }
    }
}
