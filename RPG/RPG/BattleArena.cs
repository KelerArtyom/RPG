using System;
namespace RPG
{

    public class BattleArena
    {
        public Enemy Enemy { get; set; }
        public Hero Hero { get; set; }
        public Weapon Weapon { get; set; }
        public BattleArena(Enemy enemy, Hero hero, Weapon weapon)
        {
            Enemy = enemy;
            Hero = hero;
            Weapon = weapon;
        }
        public int Battle()
        {
            Random rand = new Random();
            int Rand = 0;
            double Hp = Hero.Hp;
            int term = 1;
            int damage = 0;
            var Enemy = new Enemy(Arrays.monsters[rand.Next(0,Arrays.monsters.Length)], Hero.Level + rand.Next(0,2), rand.Next(15,100), rand.Next(5,20));
            int ans = 0;
        start:
            Console.WriteLine();
            Console.WriteLine($"Ваш противник:");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{Enemy.Name}, {Enemy.Level} lvl.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Вступить в бой?");
            Console.WriteLine("1 - В бой! | 2 - Сбежать..");
            Console.Write("Выбор: ");
            ans = int.Parse(Console.ReadLine());
            if (ans == 1)
            {
                do
                {
                restart:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"Ход: {term}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine($"Ваше здоровье: {Hp}; здоровье врага: {Math.Round(Enemy.Hp, 1)}");

                    Console.WriteLine($"Ваши действия?");
                    Console.WriteLine("1 - Атаковать | 2 - Блокировать | 3 - Уклониться");
                    Console.Write("Выбор: ");
                    int ans_btl = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    int block = 0;
                    int chance = 0;
                    if (ans_btl == 1)
                    {
                       
                        Rand = rand.Next(-5, 6);
                        Console.WriteLine($"Ваш ход: вы нанесли {Math.Round((Hero.Damage + Weapon.Damage + Rand), 1)} единиц урона");
                        Enemy.Hp -= Math.Round((Hero.Damage + Weapon.Damage + Rand), 1);
                        if (Enemy.Hp <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Победа");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"Вы получили {20 + 10 * Enemy.Level} EXP!");
                            Hero.Exp += 20 + 10 * Enemy.Level;
                            return 1;
                        }
                    }
                    else if (ans_btl == 2)
                    {
                        Console.WriteLine($"Вы приготовились отразить вражескую атаку!");
                        block = Weapon.Block;
                    }
                    else if (ans_btl == 3)
                    {
                        Console.WriteLine($"Вы встали в стойку, готовясь уклониться");
                        chance = rand.Next(0, 2);
                    }
                    else
                    {
                        goto restart;
                    }

                    Console.WriteLine($"Ход противника!");
                    Rand = rand.Next(-5, 6);
                    if (chance == 0 && ans_btl == 3)
                    {
                        Console.WriteLine("Противиник атакует!");
                        Console.WriteLine();
                        Console.WriteLine("Уклоняясь, вы запнулись и повалились на землю! (Входящий урон увеличен на 50%)");
                        Console.WriteLine($"Вам нанесли {(Enemy.Damage + Rand) * 1.5} единиц урона");
                        Hp -= (Enemy.Damage + Rand) * 1.5;
                        if (Hp <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Поражение");
                            Console.ForegroundColor = ConsoleColor.White;
                            term = 1;
                            Hp = Hero.Hp;
                            return 0;
                        }
                        else
                        {
                            term++;
                            goto restart;
                        }
                    }
                    else if (chance == 1 && ans_btl == 3)
                    {
                        Console.WriteLine("Противиник атакует!");
                        Console.WriteLine();
                        Console.WriteLine("Вы ловко увернулись, оставляя врага в замешательстве!");
                        term++;
                        goto restart;
                    }
                    Console.WriteLine($"Вам нанесли {Enemy.Damage + Rand - block} единиц урона");
                    Hp -= Enemy.Damage + Rand - block;
                    block = 0;
                    if (Hp <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Поражение");
                        Console.ForegroundColor = ConsoleColor.White;
                        term = 1;
                        Hp = Hero.Hp;
                        return 0;
                    }
                    else
                    {
                        term++;
                        goto restart;
                    }
                    
                }
                while (Enemy.Hp > 0 && Hp > 0);
            }
            else if (ans == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Вы решили перестраховаться и спасти свою шкуру..");
                return 2;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Неверное значение");
                goto start;
            }
            
        }
    }


}
