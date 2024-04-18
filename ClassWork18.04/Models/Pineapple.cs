using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork18._04.Models
{
    internal class Pineapple : Fruit
    {
        public int VitaminE { get; set; }
        public int VitaminD { get; set; }

        public Pineapple(int vitamine, int vitamind)
        {
            VitaminE = vitamine;
            VitaminD = vitamind;
        }
        public override void Taste()
        {
            Console.WriteLine("Ananas dadi");
        }
    }
}
