using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class City
    {
        Random rand = new Random();
        public City(Hero hero, Weapon weapon, BackPack backPack)
        {
            Console.WriteLine("Вы решили отправиться в город. Пора бы. Эти места вас уже явно выводили из себя..");
            Console.WriteLine();
            Console.WriteLine("************************************************************");
            Console.WriteLine();
        restart:
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(Arrays.locations_city[rand.Next(0, 10)]);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("1 - Посетить скупщика | 2 - Отправиться в лавку торговца | 3 - Проверить сняряжение | 4 - Отправиться в путь");
            Console.Write("Вы решаете: ");
            int ans = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (ans == 1)
            {
                Console.WriteLine("Вы посетили местного скупщика, которому сплавили найденные вами вещи. ");
                hero.Money += backPack.GetCost();
                backPack.EmptyBackpack();
                Console.WriteLine();
                goto restart;
            }
            else if (ans == 2)
            {
                Trader(hero, weapon);
                goto restart;
            }
            else if (ans == 3)
            {
                Console.WriteLine();
                Console.WriteLine($"Ваше оружие - {weapon.Name}; ваш уровень - {hero.Level}; ваши сбережения - {hero.Money} злотых; а вот ваши вещи в рюкзаке:");
                backPack.Show();
                Console.WriteLine();
                goto restart;
            }
            else if (ans == 4)
            {
                Console.WriteLine("И снова в путь...");
                Console.WriteLine();
                Console.WriteLine("************************************************************");
                return;
            }

        }
        public void Trader(Hero hero, Weapon weapon)
        {
            Console.WriteLine("Подойдя к лавке, вы увидели крепкого мужчину, показывающий свой ассортимент:");
        restart:
            Console.WriteLine();
            var Weapon1 = new Weapon("Железный меч", 25, 10, "Nothing", 1000);
            var Weapon2 = new Weapon("Копье городской стражи", 35, 3, "Nothing", 1500);
            var Weapon3 = new Weapon("Меч из Веленской стали", 45, 20, "Nothing", 4000);
            var Weapon4 = new Weapon("Тесак старца Питера", 60, 0, "Nothing", 6000);
            var Weapon5 = new Weapon("Меч рода Аланских", 75, 30, "Nothing", 10000);
            var Weapon6 = new Weapon("Меч из крови Асируса", 100, 50, "Nothing", 30000);
            Console.WriteLine($"1 - {Weapon1.Name} - Цена: {Weapon1.Cost} зл. - Урон: {Weapon1.Damage} ед. - Блокирование: {Weapon1.Block} ед.");
            Console.WriteLine($"2 - {Weapon2.Name} - Цена: {Weapon2.Cost} зл. - Урон: {Weapon2.Damage} ед. - Блокирование: {Weapon2.Block} ед.");
            Console.WriteLine($"3 - {Weapon3.Name} - Цена: {Weapon3.Cost} зл. - Урон: {Weapon3.Damage} ед. - Блокирование: {Weapon3.Block} ед.");
            Console.WriteLine($"4 - {Weapon4.Name} - Цена: {Weapon4.Cost} зл. - Урон: {Weapon4.Damage} ед. - Блокирование: {Weapon4.Block} ед.");
            Console.WriteLine($"5 - {Weapon5.Name} - Цена: {Weapon5.Cost} зл. - Урон: {Weapon5.Damage} ед. - Блокирование: {Weapon5.Block} ед.");
            Console.WriteLine($"6 - {Weapon6.Name} - Цена: {Weapon6.Cost} зл. - Урон: {Weapon6.Damage} ед. - Блокирование: {Weapon6.Block} ед.");
            Console.WriteLine();
            Console.WriteLine("1 | 2 | 3 | 4 | 5 | 6 | 7 - Покинуть лавку");
            Console.Write("Вы решаете: ");
            int ans = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (ans)
            {
                case 1:
                    Buy(weapon, hero, Weapon1);
                    break;
                case 2:
                    Buy(weapon, hero, Weapon2);
                    break;
                case 3:
                    Buy(weapon, hero, Weapon3);
                    break;
                case 4:
                    Buy(weapon, hero, Weapon4);
                    break;
                case 5:
                    Buy(weapon, hero, Weapon5);
                    break;
                case 6:
                    Buy(weapon, hero, Weapon6);
                    break;
                case 7:
                    return;
                default:
                    Console.WriteLine("Неверное значение!");
                    break;
            }
            goto restart;
        }

        public void Buy(Weapon weapon, Hero hero, Weapon weapon_buy)
        {
            if (hero.Money < weapon_buy.Cost)
            {
                Console.WriteLine("Недостаточно средств");
            }
            else if (weapon.Name == weapon_buy.Name)
            {
                Console.WriteLine("У вас уже есть это оружие!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("С успешной покупкой!");
                Console.ForegroundColor = ConsoleColor.White;
                weapon.Name = weapon_buy.Name;
                weapon.Damage = weapon_buy.Damage;
                weapon.Block = weapon_buy.Block;
                weapon.Modificator = weapon_buy.Modificator;
                weapon.Cost = weapon_buy.Cost;
                hero.Money -= weapon_buy.Cost;
            }
        }
    }
}
