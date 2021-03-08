using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Inicializacion de las pilas*/

            Pila ini = new Pila();
            Pila aux = new Pila();
            Pila fin = new Pila();
            int numDisc;
            Console.WriteLine("Juego de las torres de Hanoi");
            Console.WriteLine("");

            /*Se introducen los discos*/

            Console.WriteLine("Cuantos Discos ?");
            string key = Console.ReadLine();
            while (!Int32.TryParse(key, out numDisc))
            {
                Console.WriteLine("Cuantos Discos ?");
                key = Console.ReadLine();
            }
            for (int i = 0; i < numDisc; i++)
            {
                Disco d = new Disco(numDisc - i);

                ini.push(d);
            }



            Hanoi hanoi = new Hanoi();
            /*Se pregunta si Iterativo o Recursivo*/

            Console.WriteLine("Iterativo(I) - Recursivo(R)");
            string key2 = Console.ReadLine();
            key2 = key2.ToUpper();
            while (key2 != "I" && key2 != "R")
            {
                Console.WriteLine("Iterativo(I) - Recursivo(R)");
                key2 = Console.ReadLine();
                key2 = key2.ToUpper();
            }

            /*Se resuelve con la opción escogida*/

            switch (key2)
            {
                case "I":
                    int movs = hanoi.iterativo(numDisc, ini, fin, aux);

                    Console.WriteLine("Numero de movimientos: " + movs.ToString());
                    break;

                case "R":
                    int movs2 = hanoi.recursivo(numDisc, ini, fin, aux);

                    Console.WriteLine("Numero de movimientos: " + movs2.ToString());
                    break;
            }


            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
