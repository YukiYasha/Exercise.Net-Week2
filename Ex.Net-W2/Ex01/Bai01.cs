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
            Load_cbo();
        }
       
        private void Load_cbo()
        {
            for (int i = 2100; i > 1900; i--)
                cboNam.Items.Add(i);
            for (int i = 12; i > 0; i--)
                cboThang.Items.Add(i);
            for (int i = 31; i > 0; i--)
                cboNgay.Items.Add(i);

            Day = int.Parse(cboNgay.Text);
            Month = int.Parse(cboThang.Text);
            Year = int.Parse(cboNam.Text);
        }

        private void Update_cboNgay()
        {
            cboNgay.Items.Clear();

            if (Month == 1 || Month == 3 || Month == 5 || Month == 7 || Month == 8 || Month == 10 || Month == 12)
            {
                for (int i = 31; i > 0; i--)
                    cboNgay.Items.Add(i);
            }
            else
            if (Month == 4 || Month == 6 || Month == 9 || Month == 11)
            {
                for (int i = 30; i > 0; i--)
                    cboNgay.Items.Add(i);
            }
            else            
            if (Month == 2)
            {
                if (((Year % 4) == 0 && (Year % 100) == 0 && (Year % 400) == 0) || ((Year % 4) == 0 && (Year % 100) != 0))
                {
                    for (int i = 29; i > 0; i--)
                        cboNgay.Items.Add(i);
                }
                else
                {
                    for (int i = 28; i > 0; i--)
                        cboNgay.Items.Add(i);
                }
            }
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

        private void cboNam_Validated(object sender, EventArgs e)
        {
            try
            {
                Year = int.Parse(cboNam.Text);
            }
            catch (Exception)
            {
                cboNam.Text = DateTime.Now.Year.ToString();
            }

            Year = int.Parse(cboNam.Text);
            cboNgay_Validated(sender, e);
        }

        private void cboThang_Validated(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(cboThang.Text) < 1 || int.Parse(cboThang.Text) > 12)
                    cboThang.Text = DateTime.Now.Month.ToString();
            }
            catch (Exception)
            {
                cboThang.Text = DateTime.Now.Month.ToString();
            }
            
            Month = int.Parse(cboThang.Text);        
            cboNgay_Validated(sender, e);
        }

        private void cboNgay_Validated(object sender, EventArgs e)
        {
            try
            {
                Update_cboNgay();

                if (int.Parse(cboNgay.Text) < 1 || 
                    int.Parse(cboNgay.Text) > (int) cboNgay.Items[0])

                    cboNgay.Text = DateTime.Now.Day.ToString();
            }
            catch (Exception)
            {
                cboNgay.Text = DateTime.Now.Day.ToString();
            }
        }

        private void btnTinhThu_Click(object sender, EventArgs e)
        {
            if(cboNam.Text == "" || cboThang.Text == "" || cboNgay.Text == "")
            {
                MessageBox.Show("Chọn đầy đủ Ngày Tháng Năm!!!", "Cảnh báo", MessageBoxButtons.RetryCancel);
            }
            else
            {
                Year = int.Parse(cboNam.Text);
                Month = int.Parse(cboThang.Text);
                Day = int.Parse(cboNgay.Text);

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
