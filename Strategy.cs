using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp_7
{
    public interface Sub_Movs_Strategy
    {
        
        byte Ventilation(bool ventilation_enabled, byte gradus);

    }
    public interface Sub_Mil_Acts_Strategy
    {
        bool Attack(string rocket_type);
        bool Self_Destruction();
        bool Nerd_Destruction();
    }
    public interface Radar_Strategy
    {
        bool Detection(bool enemy_flag);
    }

    
    public class Submarine_movements : Sub_Movs_Strategy
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
    public class Submarine_military_actions : Sub_Mil_Acts_Strategy
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

    public class Radar : Radar_Strategy
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
    public class Submarine_radar
    {
        public bool enemy_flag { get; set; }
        Radar_Strategy _radar_strategy;
        public Submarine_radar(Radar_Strategy radar_strategy)
        {
            _radar_strategy = radar_strategy;
        }
        public void Scan()
        {
            _radar_strategy.Detection(enemy_flag);
        }
    }
    public class Military_Acts
    {
        public string rocket_type { get; set; }
        Sub_Mil_Acts_Strategy _sub_mil_acts;
        public Military_Acts(Sub_Mil_Acts_Strategy sub_mil_acts)
        {
            _sub_mil_acts = sub_mil_acts;
        }
        public void RED_BUTTON()
        {

            _sub_mil_acts.Self_Destruction();
        }
        public void Nerd_radar()
        {
            _sub_mil_acts.Nerd_Destruction();
        }
        public void Rocket_Attack()
        {
            _sub_mil_acts.Attack(rocket_type);
        }
    }
    public class Movements
    {
        Sub_Movs_Strategy _sub_movs;
        public Movements(Sub_Movs_Strategy sub_movs)
        {
            _sub_movs = sub_movs;
        }
        public byte gradus = 20;
        public void Ventilation(bool ventilation_enabled)
        {
            gradus = _sub_movs.Ventilation(ventilation_enabled, gradus);
        }
    }
}
