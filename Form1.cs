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
        Military_Acts military;
        Submarine_radar radar;
        Movements movements;

        Random rnd = new Random();
        int rnd_buffer;

        bool nerd_destructor = false;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            military = new Military_Acts(new Submarine_military_actions());
            radar = new Submarine_radar(new Radar());
            movements = new Movements(new Submarine_movements());

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
            
            military.RED_BUTTON();
            
        }

        private void nerd_detector_Click(object sender, EventArgs e)
        {
            Military_Acts military = new Military_Acts(new Submarine_military_actions());
            if (nerd_destructor == true)
            {
                MessageBox.Show("Вы уже уничтожили зануду", "Зануда", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult diag = MessageBox.Show("Вы хотите уничтожить зануду?", "Уничтожение зануды", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (diag == DialogResult.Yes)
                {
                    military.Nerd_radar();
                    nerd_destructor = true;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            if (radar.enemy_flag == true)
            {
                radar.Scan();
               
            }
            else
            {
                rnd_buffer = rnd.Next(0, 3);
                switch (rnd_buffer)
                {
                    case (0):
                        {
                            MessageBox.Show("На радаре обнаружен враг!", "ВРАГ!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            radar.enemy_flag = true;
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
            Rockets rockets = new Rockets(radar, military);
            rockets.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {


            ventilation_enabled = !ventilation_enabled;
            
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            movements.Ventilation(ventilation_enabled);
            
            gradus_lbl.Text = movements.gradus.ToString() + "°С";
            if(movements.gradus >= 60)
            {
                gradus_lbl.ForeColor = Color.Red;
                pictureBox3.ImageLocation = ".\\picture\\123.png";
            }
            else if (movements.gradus < 60)
            {
                gradus_lbl.ForeColor = Color.Aqua;
                pictureBox3.ImageLocation = ".\\picture\\321.png";
            }
            if (ventilation_enabled == false)
                
            {
                pictureBox3.ImageLocation = ".\\picture\\vent_enabled.png";
            }
            if(movements.gradus == 110)
            {
                timer1.Enabled = false;
                MessageBox.Show("Весь экипаж подводной лодки был сварен заживо", "Ой...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            if (movements.gradus <=20)
            {
                movements.gradus++;
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
