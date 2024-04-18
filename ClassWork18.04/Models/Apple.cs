using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork18._04.Models
{
    internal class Apple : Fruit
    {
        public int VitaminA { get; set; }
        public int VitaminB { get; set; }

        public Apple(int vitamina, int vitaminb)
        {
            VitaminA = vitamina;
            VitaminB = vitaminb;
        }
        public override void Taste()
        {
            Console.WriteLine("Alma dadi");
        }
    }
}
