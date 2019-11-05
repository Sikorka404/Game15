using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGame15.Dialogs
{
    public partial class WinDialog : Form
    {
        string data;
        public WinDialog(string data)
        {

            InitializeComponent();
            this.data = data;
            LabelWin.Text = data;
        }
        

        private void LabelWin_Click(object sender, EventArgs e)
        {

        }

        private void WinDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
