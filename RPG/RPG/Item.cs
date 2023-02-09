using System;
namespace RPG
{
    //Класс отвечающий за вещь в рюкзаке
    public class Item
    {
        public string Name { get; set; }
        public int Weigth { get; set; }
        public int Cost { get; set; }

        public Item(string name, int weigth, int cost)
        {
            Name = name;
            Weigth = weigth;
            Cost = cost;
        }


    }
}