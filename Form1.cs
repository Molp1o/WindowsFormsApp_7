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
    public partial class Form1 : Form
    {
        bool ventilation_enabled = true;
        Facade facade = new Facade();

        Random rnd = new Random();
        int rnd_buffer;

        bool nerd_destructor = false;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Enabled = true;

            
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            sub form2 = new sub();
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            red_btn red_Btn = new Facade().RED_BUTTON;
            red_Btn();
            
        }

        private void nerd_detector_Click(object sender, EventArgs e)
        {
            if (nerd_destructor == true)
            {
                MessageBox.Show("Вы уже уничтожили зануду", "Зануда", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult diag = MessageBox.Show("Вы хотите уничтожить зануду?", "Уничтожение зануды", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (diag == DialogResult.Yes)
                {
                    facade.Nerd_radar();
                    nerd_destructor = true;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (facade.enemy_flag == true)
            {
                facade.Scan();
               
            }
            else
            {
                rnd_buffer = rnd.Next(0, 3);
                switch (rnd_buffer)
                {
                    case (0):
                        {
                            MessageBox.Show("На радаре обнаружен враг!", "ВРАГ!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            facade.enemy_flag = true;
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Врагов не обнаружено...", "Радар", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                }
            }
        }

        private void military_link_Click(object sender, EventArgs e)
        {
            Rockets rockets = new Rockets(facade);
            rockets.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {


            ventilation_enabled = !ventilation_enabled;
            
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            facade.Ventilation(ventilation_enabled);
            
            gradus_lbl.Text = facade.gradus.ToString() + "°С";
            if(facade.gradus >= 60)
            {
                gradus_lbl.ForeColor = Color.Red;
                pictureBox3.ImageLocation = ".\\picture\\123.png";
            }
            else if (facade.gradus < 60)
            {
                gradus_lbl.ForeColor = Color.Aqua;
                pictureBox3.ImageLocation = ".\\picture\\321.png";
            }
            if (ventilation_enabled == false)
                
            {
                pictureBox3.ImageLocation = ".\\picture\\vent_enabled.png";
            }
            if(facade.gradus == 110)
            {
                timer1.Enabled = false;
                MessageBox.Show("Весь экипаж подводной лодки был сварен заживо", "Ой...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            if (facade.gradus <=20)
            {
                facade.gradus++;
            }
        }

        private void surfacing_pb_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void about_pb_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.Show();
        }

        private void about_pb1_Click(object sender, EventArgs e)
        {

        }
    }
}
