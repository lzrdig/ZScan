using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            initStatus.Text = "Not Initialized";

            //axMG17Motor1.HWSerialNum = 45111111;

            //axMG17Motor1.StartCtrl();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void axMG17Motor1_Enter(object sender, EventArgs e)
        {

        }
    }
}
