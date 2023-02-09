using System;
using System.Drawing;
namespace RPG
{
    public class Dialoge
    {
        public void Replices(string a, string b, string c, string d)
        {
            Console.WriteLine();
            Console.WriteLine($" 1 - {a}");
            Console.WriteLine($" 2 - {b}");
            Console.WriteLine($" 3 - {c}");
            Console.WriteLine($" 4 - {d}");
            point:
            Console.Write("Выберите выриант ответа: ");
            int ans = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (ans == 1)
            {
                Console.WriteLine($"- {a}");
            }
            else if (ans == 2)
            {
                Console.WriteLine($"- {b}");
            }
            else if (ans == 3)
            {

                Console.WriteLine($"- {c}");
            }
            else if (ans == 4)
            {

                Console.WriteLine($"- {d}");
            }
            else
            {
                Console.WriteLine("Неверный ответ, попробуй снова");
                goto point;
            }
            Console.WriteLine();
        }
    }
}
