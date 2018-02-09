using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Class Types *****\n");
            // Создать объект Car по имени Chuck со скоростью 10 миль в час.
            car chuck = new car();
            chuck.PrintState();

            // Создать объект Car по имени Mary со скоростью 0 миль в час.
            car mary = new car("Mary");
            mary.PrintState();

            // Создать объект Car по имени Daisy со скоростью 75 миль в час.
            car daisy = new car("Daisy", 75);
            daisy.PrintState();

            // Разместить в памяти и сконфигурировать объект Car.
            car myCar = new car();
            myCar.petName = "Henry";
            myCar.currSpeed = 10;
            // Увеличить скорость автомобиля в несколько раз и вывести новое состояние.
            for (int i = 0; i <=10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }
            // Усадим на Motorcycle байкера по имени Tiny?
            Motorcycle c = new Motorcycle(5);
            c.SetDriverName("Tiny");
            c.PopAWheely();
            Console.WriteLine("Rider name is {0}", c.name); //Выводит пустое значение name!
            Console.ReadLine();
        }

    }
}
