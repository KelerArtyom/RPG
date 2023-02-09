using RPG;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Emit;
using System.Xml.Linq;
Random rand = new Random(); 
var Dialoge = new Dialoge();

Console.BackgroundColor = ConsoleColor.Black;
Console.Clear();
Console.ForegroundColor = ConsoleColor.Gray;
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("SKYRIL");

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("************************************************************");

Console.WriteLine("Вы просыпаетесь после невероятной попойки в местной таверне. Продрав глаза, вы замечаете, что над вами склонился корчмарь.");
Console.WriteLine("Заметив, что вы наконец очнулись, мужчина ухмыляется сквозь густые усы и обращается к вам:");
Console.WriteLine();
Console.WriteLine("- О, так ты живо- Тьфу, то есть, ты наконец проспался. И даже не окочурился. Для того количества алкоголя, что ты вчера выпил - это невероятно!");
Dialoge.Replices("Я не алкаш", "Я алкаш, и что?", "А что, нельзя?! Мы живём в свободном королевстве!", "Давай не будем об этом...");
Console.WriteLine("- Хорошо-хорошо, будь по-твоему, но вот в чём дельце...");
Console.WriteLine();
Console.WriteLine("Мужчина помог вам встать, через силу, вашу боль и слипшиеся от сладкого рома глаза, после чего вы обвели взглядом помещение:");
Console.WriteLine("Обширный гостевой зал, с виду приличный, однако сломанная мебель, разбитые окна, люстра, придавившая неаккуратного посетителя и плачущая в углу официантка явно портили внешний вид.");
Dialoge.Replices("Боже мой...", "Кто этот безумец, что это сделал?!", "Это... сделал Я?!", "Я пил в таком свинарнике? Я явно себя недооцениваю...");
Console.WriteLine("- Это, кстати, твоих рук творение, о Всевыпивший! *задорный смех разнесся по комнате эхом*");
Dialoge.Replices("...", "......", ".........", "*ещё больше точек*");
Console.WriteLine("- Чего замолчал, а? Не переживай, со стражниками я договорился, твоя задница на нарах не окажется.");
Console.WriteLine("  Но хоть я тебя спас, в благородство я играть не буду.");
Dialoge.Replices("Я должен убить дракона?", "Я должен захватить соседнее королевство?", "Я должен спасти прекрасную принцессу?", "Я должен остановить мировое зло?");
Console.WriteLine("- Не-е-е, упаси Асирус души наши. Просто достаточно оплатить за весь этот кавардак, скажем, хм-м-м... 50000 злотых.");
Dialoge.Replices("50000?!", "Что?! Ты с ума сошёл?!", "ОХ ТЫ Ж МАТЬ МОЯ АЛЬ-ДВАЛА!","Это же целое состояние!");
Console.WriteLine("- Как по мне, достаточно справедливая цена. Но вижу, такая сумма тебе не по карману... Что же с тобой придумать...");
Console.WriteLine("Мужчина задумчиво почесал подбородок, уставившись в пол.");
Dialoge.Replices("Понять и простить?..", "Могу помыть у вас посуду?..", "Я могу приводить к вам клиентов", "Черт что я тебе отдам, Кальва тебя побрал!");
Console.WriteLine("Корчмарь вас даже не дослушал, а просто быстрым шагом утопал к себе в подсобку, откуда вскоре вернулся с плохо выструганным, но увесистым деревянным мечом");
Console.WriteLine();
Console.WriteLine("- Поступим вот как: ты берешь этот меч и отправляешься в окрестные леса. Там же куча тварей мерзопакостных, одолеешь их - глядишь, на выкуп и заработаешь");
Dialoge.Replices("Может, лучше в темницу?", "А если я откажусь?", "Может, сможем как-нибудь договориться?", "А выбора у меня нет?");
Console.WriteLine("- А выбора у тебя нет. Если моя хозяйка об этом узнает - тебе не жить.");
Console.WriteLine("  Либо тебя убьет мерзкое существо, а затем расчленит и сожрет тебя с потрохами, либо помрёшь от монстров в лесу.");
Console.WriteLine("  Так что бери меч, собирайся и топай в ГРЕБАННЫЙ ЛЕС, НЕ ТЯНИ КОТА ЗА ПЛЮШКИ!");


var Weapon = new Weapon("Деревянный меч", 15, 5, "Nothing", 5);

Console.WriteLine();
Console.WriteLine("Вы уже стояли на пороге таверны и одновременно на пороге своей скорой кончины, пытаясь осознать как вы докатились до жизни такой...");
Console.WriteLine("А кстати..");
Console.WriteLine();
Console.WriteLine("Кто вы..?");
Console.WriteLine();
Console.Write("Введите своё имя: ");

string name = Console.ReadLine();
var Hero = new Hero(name, 1);
var BackPack = new BackPack(20);
BackPack.maxWeight = 25 + 5 * Hero.Level;

Console.WriteLine();
Console.WriteLine($"Что ж, вот она история твоей славы и смерти, {name}...");
Console.WriteLine();
Console.WriteLine("************************************************************");

var Enemy = new Enemy("Nobody", 1, 1, 1);
var BattleArena = new BattleArena(Enemy, Hero, Weapon);

for (int i = 0; i > -1; i++)
{
    Final final = new Final();
    final.Final_Stage(Hero, Dialoge, Weapon);
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine(Arrays.locations[rand.Next(0, 10)]);
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
    restart:
    Console.WriteLine("1 - Обыскать местность | 2 - Пройти мимо | 3 - Проверить сняряжение | 4 - Отправиться в город");
    Console.Write("Вы решаете: ");
    int ans = int.Parse(Console.ReadLine());
    Console.WriteLine();
    if (ans == 1)
    {
        int Chance = rand.Next(0, 2);
        if (Chance == 0)
        {
            Console.WriteLine("Обыскивая местность, вы услышали шум сзади. Что ж... Мирного решения не будет!");
            BackPack.Looting(BattleArena.Battle());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Hero.Upgrade(Hero);
            Console.ForegroundColor = ConsoleColor.White;
        }
        else if (Chance == 1)
        {
            Console.WriteLine();
            BackPack.Looting(1);
        }
        else
        {
            goto restart;
        }
    }
    else if (ans == 2)
    {
        Console.WriteLine("Вы решили пройти мимо, мало ли, какие здесь обитают существа..");
    }
    else if (ans == 3)
    {
        Console.WriteLine();
        Console.WriteLine($"Ваше оружие - {Weapon.Name}; ваш уровень - {Hero.Level}; в кошельке вы насчитали {Hero.Money} злотых, а вот ваши вещи в рюкзаке:");
        BackPack.Show();
        Console.WriteLine();
        goto restart;
    }
    else if (ans == 4)
    {
        City city = new City(Hero, Weapon, BackPack);
    }
}

