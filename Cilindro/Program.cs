using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cilindro {
    class Program {
        static void Main(string[] args) {
            string raio;
            string alt;
            int a;
            int r;
            double V;
            double area;
            double PI = 3.1415926;
            Console.WriteLine("Insira altura");
            alt = Console.ReadLine();
            Console.WriteLine("Insira raio");
            raio = Console.ReadLine();
            a = Convert.ToInt32(alt);
            r = Convert.ToInt32(raio);

            V = PI * Math.Pow(r, 2) * a;
            area = 2 * PI * r *(r + a);

            Console.WriteLine("O volume e: " + V);
            Console.WriteLine("A area e: " + area);
            Console.ReadKey();
        }
    }
}
