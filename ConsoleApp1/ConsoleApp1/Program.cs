using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Weopen
    {
        private string name;
        public string Name { get; set; }
        private float kalibr;
        public float Kalibr { get; set; }
        private double dalnost;
        public double Dalnost { get; set; }

        public Weopen()
        {
            Name = "Gan";
            Kalibr = 0;
            Dalnost = 0.0;
        }
        public void Shot()
        {
            Console.WriteLine("Введите значения");
            Name = Console.ReadLine();
            Kalibr = Convert.ToSingle(Console.ReadLine());
            Dalnost = Convert.ToDouble(Console.ReadLine());
        }
        public void Vvivod()
        {
            Console.WriteLine($"Название: {Name} Калибр: {Kalibr} Дальность {Dalnost}");
        }      
    }
}

