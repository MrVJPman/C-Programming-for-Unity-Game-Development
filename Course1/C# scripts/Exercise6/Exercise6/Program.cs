using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            float degree = float.Parse(Console.ReadLine());
            Console.WriteLine("Cosine : " + Math.Cos(Math.PI * degree / 180));
            Console.WriteLine("Sine : " + Math.Sin(Math.PI * degree / 180));
        }
    }
}
