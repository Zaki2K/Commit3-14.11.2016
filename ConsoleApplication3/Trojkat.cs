using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Trojkat:Figura
    {
        public override double ObliczPole()
        {
            return a*b/2;
        }
    
        public Trojkat(int a,int b)
{
            this.a = a;
            this.b = b;
}

    }
}
