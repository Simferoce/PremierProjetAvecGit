using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blabla
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
            Console.WriteLine("Pose une question oui ou non");
            Console.ReadLine();
            Random rnd = new Random();
            int nbAleatoire = rnd.Next(0, 1 + 1);
            if (nbAleatoire == 0)
            {
                Console.WriteLine("peut-être");
            }
            else
            {
                Console.WriteLine("non");
            }
                Console.ReadKey();
            }
        }
    }
}
