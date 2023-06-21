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
        Random random = new Random();
        public Rockets(Facade facade)
        {
            InitializeComponent();
            this.facade = facade;
        }

        public void rocket_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (rocket_cmbx.SelectedItem.ToString())
            {
                case ("'Посейдон'"):
                    {
                        pictureBox1.ImageLocation = ".\\picture\\poseidon.jpeg";
                        break;
                    }
                case ("'Поларис' А1"):
                    {
                        pictureBox1.ImageLocation = ".\\picture\\polaris.jpg";
                        break;
                    }
                case ("'Синева'"):
                    {
                        pictureBox1.ImageLocation = ".\\picture\\sineva.jpg";
                        break;
                    }
                case ("'Р-29'"):
                    {
                        pictureBox1.ImageLocation = ".\\picture\\r-29r.jpg";
                        break;
                    }
            }
        }

        private void boom_btn_Click(object sender, EventArgs e)
        {
            int s = random.Next(0, 10);
            if(!facade.enemy_flag)
            {
                MessageBox.Show("Вы не можете ударить ракетами по воздуху", "Ракеты", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (rocket_cmbx.SelectedItem is null)
            {
                errorProvider1.SetError(rocket_cmbx, "КАК ТЫ БУДЕШЬ БИТЬ БЕЗ РАКЕТЫ?");
            }
            else
            {
                switch (s)
                {
                    case (0):
                        {
                            MessageBox.Show("ВЫ ПОПАЛИ В СВОЮ ПОДВОДНУЮ ЛОДКУ!", "Бывает", MessageBoxButtons.OK, MessageBoxIcon.Error );
                            break;
                        }
                    case (5):
                        {
                            MessageBox.Show("Ракета не попала, запустите ещё одну!", "Ой-ой...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                    default:
                        {
                            facade.rocket_type = rocket_cmbx.SelectedItem.ToString();
                            facade.Rocket_Attack();
                            facade.enemy_flag = false;
                            break;
                        }
                }   
            }
        }
    }
}
