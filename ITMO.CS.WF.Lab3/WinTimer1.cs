using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CS.WF.Lab3
{
    public partial class WinTimer1 : Form
    {
        public WinTimer1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Enabled)
            {
                if (userControlTimer1.TimeEnabled)
                {
                    userControlTimer1.TimeEnabled = false;
                }
                else
                    userControlTimer1.TimeEnabled = true;
            }
        }
    }
}
