using NYG.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYG.Classes
{
    public class Candy : Sweet
    {
        public TypeOfCandy TypeOfCandy;
        public Candy(string name, double weight, double sugar, double calories, TypeOfCandy typeOfCandy) : base(name, weight, sugar, calories)
        {
            TypeOfCandy = typeOfCandy;
        }
        public override string TypeOfSweetness => "Candy";
        public override string ItemInfo => string.Format(" {0},  weight: {1}, sugar: {2}, calories: {3}" +
                    ", type of chocolste  {4} ", Name, Weight, SugarPerUnit, CaloriPerUnit, TypeOfCandy);
    }
}
