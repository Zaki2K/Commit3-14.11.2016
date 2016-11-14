using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kwadrat kw1 = new Kwadrat(4);
            Console.WriteLine(kw1.ObliczPole());
            Trojkat tr1 = new Trojkat(5, 7);
            Console.WriteLine(tr1.ObliczPole());

            List<Figura> figury = new List<Figura>();
            figury.Add(new Kwadrat(1));
            figury.Add(new Trojkat(2, 5));
            figury.Add(new Kwadrat(1));
            figury.Add(new Trojkat(2, 5));
            figury.Add(new Kwadrat(1));
            figury.Add(new Trojkat(2, 5));
            figury.Add(new Kwadrat(1));
            figury.Add(new Trojkat(2, 5));
            figury.Add(new Kwadrat(1));
            figury.Add(new Trojkat(2, 5));
            foreach(var element in figury)
            {
                Console.WriteLine(element.ObliczPole());
            }

            Console.ReadKey();
        }
    }
}
