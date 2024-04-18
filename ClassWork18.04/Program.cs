using ClassWork18._04.Models;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace ClassWork18._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple alma = new Apple(10, 30);
            Orange portagal = new Orange(15);
            Pineapple ananas = new Pineapple(22, 12);
            Fruit[] Basket = new Fruit[] { alma, portagal, ananas };
            foreach (var item in Basket)
            {
                if (item is Apple app)
                {
                    Console.WriteLine(app.VitaminA);
                }
                else if (item is Pineapple pnp)
                {
                    Console.WriteLine(pnp.VitaminE);
                }
                else if (item is Orange org)
                {
                    Console.WriteLine(org.VitaminC);
                }
            }

        }
        public abstract System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags bindingAttr)
        {
            Console.WriteLine();
        }
        public abstract GetType()
        {
            Type type = item.GetType();
        }
            

    }
}