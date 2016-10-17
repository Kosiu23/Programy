using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw3
{
    class Program
    {
        static void Main(string[] args)
        {
            //hermetyzacja wiedziec co to

            Car car1 = new Car();       //3
           // car1.pojemnoscSilnika = 5.1; //3 
            /*car1.PokazMarke();*/
            Car car2 = new Car(4.8, "Ford");
            Car car3 = Car.Create();  //9
            Console.ReadKey();
        } 
    }
}
