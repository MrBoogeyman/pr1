using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    class Trucks
    {
        public int driverIntensity;
        public string Vodila;

        public Trucks() { }

        public Trucks(int intensity)
            : this(intensity, "") { }

        public Trucks(string name)
            : this(0, name) { }

        public Trucks(int intensity, string name)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            Vodila = name;

        }
        public void SetIntensity(int intensity)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
        }

        public String name;
        public void SetVodila(string name)
        { this.name = name; }
        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Vrum, Vrum mothefucker!");
            }
        }
    }
}
