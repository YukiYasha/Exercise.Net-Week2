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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }       

        private void button1_Click(object sender, EventArgs e)
        {
            Bai01 b1 = new Bai01();
            b1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai02 b2 = new Bai02();
            b2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai03 b3 = new Bai03();
            b3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai04 b4 = new Bai04();
            b4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bai05 b5 = new Bai05();
            b5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bai06 b6 = new Bai06();
            b6.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bai07 b7 = new Bai07();
            b7.ShowDialog();
        }
    }
}
