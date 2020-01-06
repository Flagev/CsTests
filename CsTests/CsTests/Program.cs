using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsTests
{
    //Klasa bazowa do testow
    class Program
    {
        static void Main(string[] args)
        {
            //Konstruktor+Inicjalizator. Pominieto argument opcjonalny
            BaseClass bc= new BaseClass() { i=1,j=2};
            bc[2] = 3;
            bc.ExpressionMethod();
            bc.MyProperty = 2;
            Console.WriteLine($"prop*2: {bc.MyProperty}, indeksator: {bc[2]}, operator nameof: {nameof(bc)}");
            int f1, f2;
            //Przypisanie dekonstrukcyjne - odzyskanie wartosci z pol
            (f1, f2) = bc;         
            //Rzutowanie w dol - trzeba jawnie, nie wiadomo czy sie powiedzie
            BaseClass bc2 = new Derived1();
            Derived1 d1z = (Derived1)bc2;
            //Operator as - rzutowanie w dol, w ramach niepowodzenia daje null(jak tu - w bc1 jest BaseClass a nie Derived1)
            BaseClass bc1 = new BaseClass();
            Derived1 d1= bc1 as Derived1;
            //Rzutowanie w gore - niejawne
            //Operator is - sprawdzanie czy konwersja sie powiedzie
            BaseClass d1a = new Derived1();
            if (d1a is Derived1)
            {
                Console.WriteLine($"d1a is Derived1, typeof: {d1a.GetType()}");
            }
            //Operator is i zmienne wzrocowe - tworzenie zmiennej w sprawdzeniu
            if (d1a is Derived1 d1b)
            {
                d1b.MyProperty = 2;
            }
            //Uzycie klasy generycznej
            var genericC = new GenericClass<int,int>();
            genericC[2,2] = 2;
            Console.WriteLine($"Generic Indexer: {genericC[2,2]}");
            //Kowariancja - mozna do referencji nadklasy wpisac podklase poprzez wykorzsytanie interfejsu. Pozniej mozna ja wykorzystac do metody wymagajcej nadklasy.
            //bclass mozna przekazac dalej
            var generic2 = new GenericClass2<Derived1>();
            generic2.readData = new Derived1();
            IReadable<BaseClass> bClass = generic2;
            Console.ReadLine();
        }

    }
}
