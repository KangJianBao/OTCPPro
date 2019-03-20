using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace OTCPServer
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        public FrmMain()
        {
            InitializeComponent();
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLog.Text = string.Empty;
            txtLog.Focus();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
           
           
        }

    }
}
