using System;
namespace RPG
{

    public class Enemy
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Damage { get; private set; }
        public double Hp { get; set; }

        public Enemy(string name, int level, int hp, int damage)
        {
            Name = name;
            Level = level;
            Hp = hp + level * 5;
            Damage = (2 * level) + damage;
        }
    }
}