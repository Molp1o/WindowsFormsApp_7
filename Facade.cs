using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_7
{
    public class Facade
    {
        public string rocket_type { get; set; }
        public byte gradus { get; set; }
        public bool enemy_flag {  get; set; }
        Submarine_movements submarine_Movements = new Submarine_movements();
        Submarine_military_actions submarine_military_actions = new Submarine_military_actions();
        
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
        public void Submergion()
        {
            submarine_Movements.Submergion();
        }
        public void Ventilation(bool ventilation_enabled)
        {
            gradus = submarine_Movements.Ventilation(ventilation_enabled, gradus);
        }
    }
    class Submarine_movements
    {
        
        bool submergion;
        public void Submergion() // погружение
        {
            submergion = true;
        }
        public void Surfacing() //всплытие
        {
            submergion = false;
        }
        public void Movement()
        {

        }
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
    class Submarine_military_actions
    {
        
        public void Detection()
        {

        }
        public void Attack(string rocket_type)
        {
            
            MessageBox.Show("Враг был уничтожен ракетой " +  rocket_type + "!", "Враг уничтожен!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        public void Self_Destruction()
        {
            MessageBox.Show("Бум", "Самоуничтожение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Nerd_Destruction()
        {
            MessageBox.Show("Зануда был уничтожен", "Уничтожение зануды", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
        
}
