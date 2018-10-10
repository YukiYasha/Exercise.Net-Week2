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
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
        }

        private void Bai05_Load(object sender, EventArgs e)
        {
            timer1.Start();            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock1.Text = DateTime.Now.ToLongTimeString();
            //lblClock2.Text = DateTime.Now.ToString("HH:mm:ss");
            lblClock2.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate2.Text = DateTime.Now.ToString("dd/MM/yyyy");

            //int day = DateTime.Now.Day;
            //int month = DateTime.Now.Month;
            //int year = DateTime.Now.Year;
        }
    }
}
