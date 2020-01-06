using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsTests
{
    class BaseClass
    {
        //Pola
        public int i;
        public int j;
        public int k;
        //Pole readonly - inicjalizacja tutaj albo w konstruktorze
        readonly int r = 5;
        //Wlasnosc - jak pole+kontrola nad sprawdzaniem i ustawianiem wartosci
        private int myProperty;
        public int MyProperty
        {
            get { return myProperty; }
            set { myProperty = value * 2; }
        }
        //Wlasnosc automatyczna z inicjalizatorem
        public int AutoProperty { get; private set; } = 2;
        //Konstruktor statyczny - dla klasy jako calej 
        static BaseClass()
        {
            Console.WriteLine("Typ zainicjalizowany");
        }
        //Konstruktor z parametem opcjonalnym
        public BaseClass(int k = 2)
        {
            this.k = k;
        }
        //Indeksator - jak wlasnosc ale dostep przez indeks
        private int[] numbers = new int[] { 2, 3, 5 };
        public int this[int num]
        {
            get { return numbers[num]; }
            set { numbers[num] = value; }
        }
        //Funkcja wirtualna - moze byc przeslonieta
        public virtual void VirtualF (int x)
            {
            this.i=x*2;
            }
        //Dekonstruktor
        public void Deconstruct(out int i, out int j)
        {
            i = this.i;
            j = this.j;
        }
        //Metoda wyrazeniowa
        public void ExpressionMethod() => Console.WriteLine("xm");
        void TestFunction()
        {
            i = r;
        }
    }
}
