using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DelegateCommTest.FrmMainA;

namespace DelegateCommTest
{
    public partial class FrmChildB : Form
    {
        public FrmChildB()
        {
            InitializeComponent();
            
        }
        public DelegateMessage PassMsg = null;
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtSendMsg.Text == "") return;
            PassMsg(txtSendMsg.Text.Trim());
            txtSendMsg.Text = "";
        }
    }
}
