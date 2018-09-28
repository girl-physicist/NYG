using NYG.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYG.Classes
{
    public class Chocolate : Sweet
    {
        public TypeOfChocolate TypeOfChocolate;

        public Chocolate(string name, double weight, double sugar, double calories,    TypeOfChocolate typeOfChocolate) : base(name, weight, sugar, calories)
        {
            TypeOfChocolate = typeOfChocolate;
        }

        public override string TypeOfSweetness => "Chocolate";
        public override string ItemInfo => string.Format(" {0},  weight: {1}, sugar: {2}, calories: {3}" +
                    ", type of chocolste  {4} ", Name, Weight,  SugarPerUnit, CaloriPerUnit, TypeOfChocolate);
    }
}
