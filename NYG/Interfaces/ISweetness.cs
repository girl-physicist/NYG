using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYG.Interfaces
{
   public interface ISweetness
    {
        double SugarPerUnit { get; }
        double Weight { get; }
        string Name { get; }
        double CaloriPerUnit { get; }
        string TypeOfSweetness { get; }
        string ItemInfo { get; }
    }
}
