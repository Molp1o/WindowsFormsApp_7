﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_7
{
    public partial class sub : Form
    {
        Facade facade = new Facade();
        public sub()
        {
            InitializeComponent();
        }

        public void sub_Load(object sender, EventArgs e)
        {
            
        }
        public void sub_close()
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
