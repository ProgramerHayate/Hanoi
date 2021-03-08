using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        int m = 0;
        int direccion = 0;
        /*Implementación de metodos*/
        public void mover_disco(Pila a, Pila b)
        {

            if ((a.Top > b.Top || a.Top == 0) && b.Top != 0)
            {
                a.push(b.pop());
                direccion = 1;
                
            }
            else if ((b.Top > a.Top || b.Top == 0) && a.Top != 0)
            {
                b.push(a.pop());
                direccion = 2;
            }
            m++;

        }
        /*Iterativo*/
        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {

            if (n % 2 == 0)
            {
                while (fin.Size < n)
                {
                    mover_disco(aux, ini);

                    /*Se muestra el movimiento por consola*/
                    if (direccion == 1)
                    {
                        Console.WriteLine("Se a movido el disco de ini a aux");
                    }
                    else
                    {
                        Console.WriteLine("Se a movido el disco de aux a ini");
                    }
                    /*---------------------------------------------------------------*/
                    mover_disco(ini, fin);
                    /*Se muestra el movimiento por consola*/
                    if (direccion == 1)
                    {
                        Console.WriteLine("Se a movido el disco de fin a ini");
                    }
                    else
                    {
                        Console.WriteLine("Se a movido el disco de ini a fin");
                    }
                    /*---------------------------------------------------------------*/

                    if (fin.Size == n)
                    {
                        return m;
                    }

                    mover_disco(fin, aux);
                    /*Se muestra el movimiento por consola*/
                    if (direccion == 1)
                    {
                        Console.WriteLine("Se a movido el disco de aux a fin");
                    }
                    else
                    {
                        Console.WriteLine("Se a movido el disco de fin a aux");
                    }
                    /*---------------------------------------------------------------*/

                    if (fin.Size == n)
                    {
                        return m;
                    }
                }
            }
            if (n % 2 != 0 || n == 1)
            {
                while (fin.Size < n)
                {
                    mover_disco(ini, fin);
                    /*Se muestra el movimiento por consola*/
                    if (direccion == 1)
                    {
                        Console.WriteLine("Se a movido el disco de fin a ini");
                    }
                    else
                    {
                        Console.WriteLine("Se a movido el disco de ini a fin");
                    }
                    /*---------------------------------------------------------------*/

                    if (fin.Size == n)
                    {
                        return m;
                    }
                    mover_disco(ini, aux);
                    /*Se muestra el movimiento por consola*/
                    if (direccion == 1)
                    {
                        Console.WriteLine("Se a movido el disco de aux a ini");
                    }
                    else
                    {
                        Console.WriteLine("Se a movido el disco de ini a aux");
                    }
                    /*---------------------------------------------------------------*/

                    mover_disco(aux, fin);
                    /*Se muestra el movimiento por consola*/
                    if (direccion == 1)
                    {
                        Console.WriteLine("Se a movido el disco de fin a aux");
                    }
                    else
                    {
                        Console.WriteLine("Se a movido el disco de aux a fin");
                    }
                    /*---------------------------------------------------------------*/
                    if (fin.Size == n)
                    {
                        return m;
                    }

                }
            }
            return m;
        }

        /*Recursivo*/
        public int recursivo(int n, Pila ini, Pila fin, Pila aux)
        {

            if (n == 1)
            {

                mover_disco(ini, fin);
                /*Se muestra el movimiento por consola*/
                if (direccion == 1)
                {
                    Console.WriteLine("Se a movido el disco de fin a ini");
                }
                else
                {
                    Console.WriteLine("Se a movido el disco de ini a fin");
                }
                /*---------------------------------------------------------------*/

            }
            else if(n == 0)
            {
                m = 0;
            }
            else
            {
                recursivo(n - 1, ini, aux, fin);
                mover_disco(ini, fin);
                /*Se muestra el movimiento por consola*/
                if (direccion == 1)
                {
                    Console.WriteLine("Se a movido el disco de fin a ini");
                }
                else
                {
                    Console.WriteLine("Se a movido el disco de ini a fin");
                }
                /*---------------------------------------------------------------*/

                recursivo(n - 1, aux, fin, ini);
            }

            return m;
        }

    }
}
