using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw3
{
    class Car
    {
        private double pojemonoscSilnika;              //2
        private string marka;                          //2

       public Car()                                   //4 i 8
        {
            this.marka = "Skoda";
            this.pojemonoscSilnika = 5.1;            //4
        }
         public Car (double pojemnoscSilnika, string marka) //5 i 8
        {
            this.marka = marka; // skoda pobierze domyslnie
            this.pojemonoscSilnika = pojemnoscSilnika; // 5.1 pobierze domyslnie
        }
        /* public void PokazMarke()
         {
             Console.WriteLine(marka);
         }*/
        static public Car Create()  //9
         {
             return new Car();  
         }
        static int iloscKol;  //11
        static Car()
        {
            iloscKol = 4;
        }
        ~Car()
        {
            Console.WriteLine("Zwalniam pamięć");
            Console.WriteLine(this.marka);
            Console.WriteLine(this.pojemonoscSilnika);
            Console.ReadKey();
        }
    }
}
