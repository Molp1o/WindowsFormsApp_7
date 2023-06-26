using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_7
{
    delegate void red_btn();
    public class Facade
    {
        public string rocket_type { get; set; }
        public byte gradus = 20;
        public bool enemy_flag { get; set; }
        Submarine_movements submarine_Movements = new Submarine_movements();
        Submarine_military_actions submarine_military_actions = new Submarine_military_actions();
        Radar radar = new Radar();




        public void RED_BUTTON()
        {

            submarine_military_actions.Self_Destruction();
        }
        public void Nerd_radar()
        {
            submarine_military_actions.Nerd_Destruction();
        }
        public void Rocket_Attack()
        {
            submarine_military_actions.Attack(rocket_type);
        }
        public void Ventilation(bool ventilation_enabled)
        {
            gradus = submarine_Movements.Ventilation(ventilation_enabled, gradus);
        }
        public void Scan()
        {
            radar.Detection(enemy_flag);
        }

    }
    public class Submarine_movements
    {
        public byte Ventilation(bool ventilation_enabled, byte gradus)
        {
            if (ventilation_enabled == true)
            {
                gradus++;
            }
            else
            {
                gradus--;
            }
            return gradus;

        }
    }
    public class Submarine_military_actions
    {

        public bool Attack(string rocket_type)
        {
            if (string.IsNullOrEmpty(rocket_type))
            {
                return false;
            }
            else
            {
                MessageBox.Show("Враг был уничтожен ракетой " + rocket_type + "!", "Враг уничтожен!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return true;
            }
        }
        
        public bool Self_Destruction()
        {
            bool pentaflag;
            Pentagon pentagon = new Pentagon();
            pentagon.Show();
            if (pentagon.Visible)
            {
                pentaflag = true;
            }
            else
            {
                pentaflag = false;
            }
            return pentaflag;
        }
        public bool Nerd_Destruction()
        {
            MessageBox.Show("Зануда был уничтожен", "Уничтожение зануды", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return true;
        }

    }

    public class Radar
    {
        public bool Detection(bool enemy_flag)
        {
            if (!enemy_flag)
            {
                return false;
            }
            else
            {
                MessageBox.Show("Вы не можете продолжить сканирование, пока враг не уничтожен!!", "ВНИМАНИЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
        }
    }

}
