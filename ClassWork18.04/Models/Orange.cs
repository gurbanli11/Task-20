using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork18._04.Models
{
    internal class Orange : Fruit
    {
        public int VitaminC { get; set; }
        public Orange(int vitaminc)
        {
            VitaminC = vitaminc;
        }
        public override void Taste()
        {
            Console.WriteLine("Portagal dadi");
        }
    }
}
