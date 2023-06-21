using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_7
{
    public partial class Pentagon : Form
    {
        public Pentagon()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = ".\\picture\\explode-boom.gif";
            new Thread(() => { Thread.Sleep(5000); Application.Exit(); }).Start();
            
        }
    }
}
