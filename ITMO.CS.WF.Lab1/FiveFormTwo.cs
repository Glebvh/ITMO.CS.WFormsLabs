using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CS.WF.Lab1
{
    public partial class FiveFormTwo : Form
    {
        public FiveFormTwo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FiveFormOne f = new FiveFormOne();
            f.Show();
        }
    }
}
