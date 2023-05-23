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

            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //TimerCallback timerCallback = new TimerCallback(Gradus);
            //var timer = new System.Threading.Timer(timerCallback, 0, 500, 1000);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            facade.RED_BUTTON();
            Environment.Exit(0);
        }

        private void nerd_detector_Click(object sender, EventArgs e)
        {
            if (nerd_destructor == true)
            {
                MessageBox.Show("Вы уже уничтожили зануду");
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
                MessageBox.Show("Вы не можете продолжить сканирование, пока враг не уничтожен!!", "ВНИМАНИЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                rnd_buffer = rnd.Next(0, 2);
                switch (rnd_buffer)
                {
                    case (0):
                        {
                            MessageBox.Show("На радаре обнаружен враг!");
                            facade.enemy_flag = true;
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Врагов не обнаружено...");
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
            
            if ( ventilation_enabled == true )
            {
                ventilation_enabled = false;
            }
            if( ventilation_enabled == false )
            {
                ventilation_enabled= true;
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            facade.Ventilation(ventilation_enabled);
            gradus_lbl.Text = null;
            gradus_lbl.Text = facade.gradus.ToString();
        }
    }
}
