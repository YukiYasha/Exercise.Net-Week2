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
    public partial class Bai06 : Form
    {
        public Bai06()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            ofd.Title = "Open Image";
            if(txtPicPath.Text == "")
                ofd.InitialDirectory = @"C:\";
            else
                ofd.InitialDirectory = @txtPicPath.Text;
            ofd.Filter = "Image|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPicPath.Text = ofd.FileName;
                picPic.Image = Image.FromFile(ofd.FileName);                                
            }
        }
    }
}
