using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateCommTest
{
    public partial class FrmMainA : Form
    {
        public FrmMainA()
        {
            InitializeComponent();

        }
        
        private void btnCreateChildForm_Click(object sender, EventArgs e)
        {
            FrmChildB frmChildB = new FrmChildB();
            frmChildB.Show();
            frmChildB.PassMsg = ReceiveMsg;
            btnCreateChildForm.Enabled = false;
        }

        public void ReceiveMsg(string msg)
        {
            txtContent.Text += msg + "\r\n";
        }

        public delegate void DelegateMessage(string msg);
    }
}
