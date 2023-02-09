using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Final
    {
        public void Final_Stage(Hero hero, Dialoge dialoge, Weapon weapon)
        {
            if (hero.Money >= 50000)
            {
                Console.WriteLine("************************************************************");
                Console.WriteLine();
                Console.WriteLine("Вы в сотый раз пересчитываете свои накопления, чтобы убедиться в правдивости своих действий..");
                Console.WriteLine("Всё точно... 50000 злотых у вас..");
                Console.WriteLine("Стремглав вы несётесь к той самой таверне, очарованные тем, что выберетесь из долгового рабства!");
                Console.WriteLine("Наконец-то..");
                Console.WriteLine();
                Console.WriteLine("************************************************************");
                Console.WriteLine();
                Console.WriteLine("Хозяин таверны неторопливо волочил по паркету безсознательное тело какого-то забулдыги, чтобы затем выкинуть его за порог в грязное месиво прямо перед вашим носом.");
                Console.WriteLine();
                Console.WriteLine($"- О, {hero.Name}, давненько тебя не было! Я уж думал, что ты решил сбежать и посвятить свою жизнь беспросветному скитанию по диким землям...");
                Console.WriteLine($"  Или помер в каком-нибудь болоте, наевшись музоморами, одно из двух.");
                Console.WriteLine();
                Console.WriteLine("Тавернщик пригласил вас внутрь, где уже практически не осталось следов вашего кутежа (кроме той самой официантки, которая завидев вас с диким воплем убежала прочь.)");
                Console.WriteLine();
                Console.WriteLine($"- Ну так, с чем пожаловал? Надеюсь, с компенсацией, ведь так?");
                Console.WriteLine();
                Console.WriteLine($"Мужчина невесело усмехнулся и еле заметно оскалился, смотря вам прямо в глаза.");
                dialoge.Replices("Деньги у меня, не волнуйся.", "Я ж явно сюда не просто так пришёл.", "Само собой, злоты у меня, ровно 50000.", "Принёс, принёс.. Какие вы алчные все пошли..");
                Console.WriteLine();
                Console.WriteLine($"- Ха-хах, это хорошо. Не сомневался, что ты меня не подведёшь! -");
                Console.WriteLine($"  Увесистая рука протянулась к вам, в ожидании, когда вы вложите туда заветный мешочек с звенящими монетками.");
                Console.WriteLine();
                Console.WriteLine(" 1 - Отдать деньги.");
                Console.WriteLine(" 2 - Не отдавать деньги.");
                point:
                Console.Write("Выберите выриант ответа: ");
                int ans = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (ans == 1)
                {
                    Console.WriteLine($"Вы достаете деньги и протягиваете его мужчине, с чувством облегчения..");
                    Console.WriteLine();
                    Console.WriteLine($"- Вот та-а-ак, отлично! Просто прекрасно! Я верю тебе наслово, пересчитаю позже. Можешь быть свободен, не пугай гостей, ага?");
                    Console.WriteLine($"  Мужчина сделал жест рукой, указывающих на выход из заведения.");
                    Console.WriteLine();
                    Console.WriteLine($"Не желая больше злить, вы встаёте и быстрым шагом выходите на свежий воздух, вдыхая кислород полной грудью.");
                    Console.WriteLine();
                    Console.WriteLine($"Вот так пахнет свобода?..");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"КОНЕЦ");
                    Console.ReadKey();
                }
                else if (ans == 2)
                {
                    Console.WriteLine($"Вы молча смотрели в глаза тавернщика, которые с каждой лишней секундой всё больше наливались гневом. Вы не будете отдавать деньги, на которые вы так копили с кровью и потом.");
                    Console.WriteLine();
                    Console.WriteLine($"- Вот как значит.. Надо было сдать тебя еще тогда..");
                    Console.WriteLine($"  Маленький. Жалкий. Отброс.");
                    Console.WriteLine();
                    Console.WriteLine($"Мужчина поднялся со своего места и достал из-за пазухи большой мясницкий нож, явно старым, но не менее смертоносным.");
                    Console.WriteLine();
                    Console.WriteLine($"- Не хочешь отдавать - тогда я заберу это сам! -");
                    Console.WriteLine($"  Стол, за которым вы сидели ловким движением руки отлетел в сторону. Что ж, а на что ты еще рассчитывал?");
                    Console.WriteLine();
                    Random rand = new Random();
                    int Rand = 0;
                    double Hp = hero.Hp;
                    double Enemy_Hp = 300;
                    int term = 1;
                    double damage = 0;
                    Console.WriteLine($"Ваш противник:");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Корчмарь, спасения нет.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Вступить в бой?");
                    Console.WriteLine("1 - В бой! | 2_3-№;КПЫВПе3_№;%?");
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
                            Console.WriteLine($"Ваше здоровье: {Hp}; здоровье врага: {Enemy_Hp}");

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
                                Console.WriteLine($"Ваш ход: вы нанесли {Math.Round((hero.Damage + weapon.Damage + Rand), 1)} единиц урона");
                                Enemy_Hp -= Math.Round((hero.Damage + weapon.Damage + Rand), 1);
                                if (Enemy_Hp <= 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Победа");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine($"Вы приставили лезвие к горлу израдно раненого мужчины, лежащего не окрававленном полу.");
                                    Console.WriteLine();
                                    Console.WriteLine($"- Эгх.. Угрх.. Спокойно, {hero.Name}, спокойно.. Забирай эти деньги к чертовой матери.. И забудь чертову дорогу в это место, щенок.. -");
                                    Console.WriteLine($"  Корчмарь сплюнул сгустком в сторону, продолжая тяжело дышать.");
                                    Console.WriteLine();
                                    Console.WriteLine($"Что ж, вы победили. ВЫ. ПОБЕДИЛИ. Деньги ваши. Как и свобода. Касательно советси есть вопросы, но плевать - ЭТО ВАША ПОБЕДА!");
                                    Console.WriteLine($"Вы спрятали оружие и в последнй раз кинув взгляд на зал, вышли на улицу, прямо под мелко моросящий дождь.");
                                    Console.WriteLine();
                                    Console.WriteLine($"Так ли пахнет свобода?..");
                                    Console.WriteLine();
                                    Console.WriteLine($"Мелкими шагами вы поплелись в неизвестные просторы, в надежде найти новые приключения. Или новую таверну. Может выпить?");
                                    Console.WriteLine();
                                    Console.WriteLine($"КОНЕЦ");
                                    Console.ReadKey();
                                }
                            }
                            else if (ans_btl == 2)
                            {
                                Console.WriteLine($"Вы приготовились отразить вражескую атаку!");
                                block = weapon.Block;
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
                                damage = (40 + Rand) * 1.5;
                                Console.WriteLine($"Вам нанесли {damage} единиц урона");
                                Hp -= damage;
                                if (Hp <= 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Поражение");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine();
                                    Console.WriteLine("Нет.. Всё не должно было закончится так.. Но он закончилось..");
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine($"КОНЕЦ");
                                    Console.ReadKey();
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
                            damage = 40 + Rand - block;
                            Console.WriteLine($"Вам нанесли {damage} единиц урона");
                            Hp -= damage;
                            block = 0;
                            if (Hp <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Поражение");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine();
                                Console.WriteLine("Нет.. Всё не должно было закончится так.. Но он закончилось..");
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine($"КОНЕЦ");
                                Console.ReadKey();
                            }
                            else
                            {
                                term++;
                                goto restart;
                            }

                        }
                        while (Enemy_Hp > 0 && Hp > 0);
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ответ, попробуй снова");
                    goto point;
                }
            }
        }
    }
}
