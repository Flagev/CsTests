using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsTests
{
    class Derived1 : BaseClass
    {
        public int z = 2;
      //Wykorzystanie konstruktora klasy bazowej. Najpierw wywolywany bazowy  
        public Derived1() : base()
            {
            }
        //Przeslonieta metoda. Przy wywolaniu z poziomu nadklasy zostanie wywolana metoda z Derived1
        //Sealed  - brak mozliwosci dalszego override
        public sealed override void VirtualF(int x)
        {
            //Wywolanie metody z fynkcji bazowej. Dziala przy przeslanianiu i chowaniu
            base.VirtualF(x);
        }
        //Schowana metoda. Przy wywolaniu z poziomu nadklasy zostanie wywolana metoda z BaseClass
        public new void ExpressionMethod() => Console.WriteLine("xm");

        //Atrybut flags - ala checkbox
        [Flags]
        public enum Sides { 
            None=0,Top=1,Bottom=2,Right=4,Left=8,
            LeftRight=Left | Right,
            TopBottom=Top|Bottom,
            All=TopBottom|LeftRight
        }


    }
}
