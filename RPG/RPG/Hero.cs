using System;
using System.ComponentModel.DataAnnotations;

namespace RPG
{
    public class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public double Damage { get; private set; }
        public double Hp { get; set; }
        public int Exp { get; set; }
        public int Money { get; set; }

        // Добавить оружие или броню с модификаторами:
        // CRIT - каждый 3 удар увеличивает урон на 150%
        // COLD - каждый 5 удар замораживает противника и он пропускает ход
        // POSION - каждый ход наносится дополнительно 10 урона
        // Модификаторы могут меняться в зависимости от вашей фантазии 


        public Hero(string name, int level)
        {
            Name = name;
            Level = level;
            Hp = 90 + level * 10;
            Damage = 1.5 * Level;
            Exp = 0;
            Money = 0;
        }
        public void Upgrade(Hero hero)
        { 
            if (hero.Exp > (100 * hero.Level))
            {
                hero.Level++;
                Console.WriteLine();
                Console.WriteLine($"ВЫ ДОСТИГЛИ {hero.Level} УРОВНЯ!");
                Console.WriteLine();
            }
        }

    }
   
}
