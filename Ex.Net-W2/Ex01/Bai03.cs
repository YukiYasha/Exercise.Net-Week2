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
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btnMB = new MessageBoxButtons();
            MessageBoxIcon iconMB = new MessageBoxIcon();

            if (CheckButton(ref btnMB) == 0 || CheckIcon(ref iconMB) == 0)
            {
                MessageBox.Show("Chọn đầy đủ RadioButton!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ShowMessageBox(btnMB, iconMB);
        }

        private void ShowMessageBox(MessageBoxButtons btnMB, MessageBoxIcon iconMB)
        {
            MessageBox.Show("This is Your Custom MessageBox.", "Custom MessageBox", btnMB, iconMB);
        }

        private int CheckButton(ref MessageBoxButtons btnMB)
        {
            if (rdoOK.Checked == true)
                btnMB = MessageBoxButtons.OK;
            else
                if (rdoOKC.Checked == true)
                btnMB = MessageBoxButtons.OKCancel;
            else
                if (rdoARI.Checked == true)
                btnMB = MessageBoxButtons.AbortRetryIgnore;
            else
                if (rdoYNC.Checked == true)
                btnMB = MessageBoxButtons.YesNoCancel;
            else
                if (rdoYN.Checked == true)
                btnMB = MessageBoxButtons.YesNo;
            else
                if (rdoRC.Checked == true)
                btnMB = MessageBoxButtons.RetryCancel;
            else
                return 0;
            return 1;
        }

        private int CheckIcon(ref MessageBoxIcon IconMB)
        {
            if (rdoErr.Checked == true)
                IconMB = MessageBoxIcon.Error;
            else
                if (rdoExc.Checked == true)
                IconMB = MessageBoxIcon.Exclamation;
            else
                if (rdoInf.Checked == true)
                IconMB = MessageBoxIcon.Information;
            else
                if(rdoQue.Checked == true)
                IconMB = MessageBoxIcon.Question;
            else
                return 0;
            return 1;
        }

    }
}
