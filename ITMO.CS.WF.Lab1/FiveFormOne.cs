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
    public partial class FiveFormOne : Form
    {
        public FiveFormOne()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FiveFormOne_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath =
            new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddPolygon(new Point[] 
            { 
            new Point(0, Height / 2),
            new Point(Width / 2, 0),
            new Point(Width, Height / 2),
            new Point(Width / 2, Height)
             });

            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }
    }
}
