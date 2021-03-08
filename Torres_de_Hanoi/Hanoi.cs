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
        /*Implementación de metodos*/
        public void mover_disco(Pila a, Pila b)
        {

            if ((a.Top > b.Top || a.Top == 0) && b.Top != 0)
            {
                a.push(b.pop());
            }
            else if ((b.Top > a.Top || b.Top == 0) && a.Top != 0)
            {
                b.push(a.pop());
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

                    mover_disco(ini, fin);

                    if (fin.Size == n)
                    {
                        return m;
                    }

                    mover_disco(fin, aux);

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

                    if (fin.Size == n)
                    {
                        return m;
                    }
                    mover_disco(ini, aux);

                    mover_disco(aux, fin);
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

            }
            else if(n == 0)
            {
                m = 0;
            }
            else
            {
                recursivo(n - 1, ini, aux, fin);
                mover_disco(ini, fin);

                recursivo(n - 1, aux, fin, ini);
            }

            return m;
        }

    }
}
