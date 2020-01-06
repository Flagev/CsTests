using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsTests
{
    //Modyfikator out oznacza typ kowariantny - do odczytu przy konwersji typu
    public interface IReadable<out T>
    {
        T Read();
    }
    //Modyfikator out oznacza typ kontrawariantny - do zapisu przy konwersji typu
    public interface IWritable<in T>
    {
        void Write(T obj);
    }

    //Klasa generyczna. Tworzy szablony - typy zastepcze. 
    //Umozliwia pisanie kodu dzialajacego z roznymi typami jak dziedziczenie.
    //Umozliwia zwiekszenie bezpieczenstwa typowego(typ okreslany podczas kompilacji)
    //oraz redukowac operacje rzutowania i pakowania
    //Rodzaj konwers ji (liczbowe,referencji,pakowania,wlasne) jest ustalany w czasie kompilacji. 
    //Deklaracja typow jest w sygnaturze. Where okresla wymogi dla typu
    class GenericClass<T1,TR> : IReadable<TR>
    {
        T1[,] data=new T1[100,100];
        TR readData;
        public int pint = 3;
        //Implementacja interfejsu
        public TR Read()
        {
            return readData;
        }
        //Indeksator
        public T1 this[int index1, int index2] 
        {
            get
            {
                return data[index1,index2];
            }
            set 
            {
                data[index1,index2]=value;
            }
        }
    }
    class GenericClass2<TR> : IReadable<TR>
    {
        public TR readData;
        public int pint = 3;
        //Implementacja interfejsu
        public TR Read()
        {
            return readData;
        }

    }
}
