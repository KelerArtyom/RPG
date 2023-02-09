using System;
namespace RPG
{
    public class Weapon
    {
        public double Damage { get; set; }
        public string Name { get; set; }

        public int Cost { get; set; }
        public int Block { get; set; }
        public string Modificator { get; set; }
        public Weapon (string name, int damage, int block, string modification, int cost)
        {
            Name = name;
            Damage = damage;
            Block = block;
            Modificator = modification;
            Cost = cost;
        }

    }
}
