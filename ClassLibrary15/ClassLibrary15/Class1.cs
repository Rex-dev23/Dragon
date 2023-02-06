using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary15
{
    public class Dragon
    {
        int max_damage_dragon;//Максимальный урон дракону
        int dragon_hp;//Уровень жизни дракона
        int dragon_damage;//Урон дракона
        int hp2;//Подлечение уровни жизни игроку
        int current_level_hp;// текущий уровень жизни игрока
        int max_hp;//максимальное число жизни игрока
        int damage;//Урон игроку
        int max_damage;//Максимальый урон игроку
        
        public int HP
        {
            get { return current_level_hp; }
            set { max_hp = value; }

        }
    public int Damage
        {
            get { return max_damage; }
            set { max_damage = value; }
        }
    public int Strike_the_enemy()// нанесение удара 
        {
             return  (current_level_hp - damage);

        }
    public int Heal()//подлечение уровни жизни
        {
             return  hp2 + current_level_hp;
        }
    public int Damage_dragon()//урон дракона
        {
             return dragon - current_level_hp;
        }

    }
}
