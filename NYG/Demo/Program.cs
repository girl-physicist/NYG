using NYG.Classes;
using NYG.Enums;
using NYG.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NYG.Demo;

namespace NYG
{
    class Program
    {
        static void Main(string[] args)
        {
            IGift gift = new Gift("Gift 1", new List<ISweetness>());
            Candy candy1 = new Candy("Сhupa Chups XXL 4D", 29, 0.65,  370,TypeOfCandy.Bars);
            Candy candy2 = new Candy("Аэрофлотские", 150, 64.3, 483, TypeOfCandy.Chocolate);
            Chocolate choco1 = new Chocolate("Спартак", 75,  48, 540, TypeOfChocolate.Dark);
            Chocolate choco2 = new Chocolate("Любимая Алёнка", 200,  51.5, 550, TypeOfChocolate.Milk);
            gift.AddSweet(candy1);
            gift.AddSweet(candy2);
            gift.AddSweet(choco1);
            gift.AddSweet(choco2);
            gift.ShowItems();
        }
    }
}
