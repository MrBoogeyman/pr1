using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    class car
    {
        // 'Состояние' объекта Car.
        public string petName;
        public int currSpeed;

        //Специальный стандартный конструктор.
        public car ()
        {
            petName = "Chuck";
            currSpeed = 10;
        }

        // Здесь currSpeed получает стандартное значение для типа int {0}
        public car(string pn)
        {
            petName = pn;
        }

        //Позволяет вызывающему коду установить полное состояние Car.
        public car(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;
        }

        // Функциональность Car.
        {
        public void PrintState ()
        {
           Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed)
        }
            public void SpeedUp (int delta)
        {
            currSpeed += delta;
        }

        }
    }
}
