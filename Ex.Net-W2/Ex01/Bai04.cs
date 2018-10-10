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
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
        }

        private void Bai04_MouseClick(object sender, MouseEventArgs e)
        {
            lblInfo.Visible = true;
            lblInfo1.Visible = true;
            lblInfo2.Visible = false;            

            lblInfo.Text = e.Button.ToString() + " Mouse";
            lblInfo1.Text = "[X, Y] = [" + e.X + ", " + e.Y + "]";
            CanLe();
        }

        private void Bai04_KeyDown(object sender, KeyEventArgs e)
        {
            lblInfo.Visible = true;
            lblInfo1.Visible = true;
            lblInfo2.Visible = true;            

            lblInfo.Text = "Key Name   " + e.KeyCode.ToString();
            lblInfo1.Text = "ASCII Code   " + e.KeyValue.ToString();
            lblInfo2.Text = "Hash Code   " + e.GetHashCode().ToString();            

            CanLe();
        }

        private void CanLe()
        {
            lblInfo.Location = new Point(this.Size.Width / 2 - lblInfo.Width / 2, 250);
            lblInfo1.Location = new Point(this.Size.Width / 2 - lblInfo1.Width / 2, 275);
            lblInfo2.Location = new Point(this.Size.Width / 2 - lblInfo2.Width / 2, 300);            
        }
    }
}
