using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    class Motorcycle
    {
        public int driverIntensity;
        public string driverName;

        //Связывание конструктора в цепочку.

        // Это 'Это главный конструктор', выполняющий всю реальную работу.
        public Motorcycle() { }

        public Motorcycle(int intensity)  
            : this(intensity, "") { }

        public Motorcycle(string name)
            : this(0, name) { }

        /*if{
            SetIntensity(intensity);
             (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
        }*/
        public Motorcycle(int intensity, string name)
        {
             if (intensity > 10)
             {
                 intensity = 10;
             }
             driverIntensity = intensity;
             driverName = name; 
            /*SetIntensity(intensity);
            driverName = name;*/
        }
        public void SetIntensity(int intensity)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
        }



       

        /*Конструкторы.
        public Motorcycle () { }
        public Motorcycle(int intensity)

            : this(intensity, "") { }
        public Motorcycle(string name)
          
        driverName = name;

        {
           
        }
        public Motorcycle(int intensity, string name)
        {
        if (intensity > 10)
        {
            intensity = 10;
        }

            SetIntensity(intensity);
            driverName = name;
        }
        

        public Motorcycle() { }

            // Избыточная логика конструктора!
            public Motorcycle(int intensity)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
        }

        public Motorcycle(int intensity, string name)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }*/

        // Новые члены для представления имени водителя.
        public String name;
        public void SetDriverName(string name)
        { this.name = name; }
        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeee Haaaaaeewww!");
            }
        }

        /* Вернуть стандартный конструктор, который будет устанавливать
        // для всех членов данных стандартные значения.
        public Motorcycle() { }

        //Специальный конструктор.
        public Motorcycle(int intensity)
        {
            driverIntensity = intensity;
        }*/
    }
}
