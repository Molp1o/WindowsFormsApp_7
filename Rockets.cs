using System;
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
    public partial class Rockets : Form
    {
        Facade facade;

        public Rockets(Facade facade)
        {
            InitializeComponent();
            this.facade = facade;
        }

        public void rocket_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void boom_btn_Click(object sender, EventArgs e)
        {
            if(facade.enemy_flag == false)
            {
                MessageBox.Show("Вы не можете ударить ракетами по воздуху");
            }
            else
            {
                facade.rocket_type = rocket_cmbx.SelectedItem.ToString();
                facade.Rocket_Attack();
                facade.enemy_flag = false;
            }
        }
    }
}
