using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; } = 0;

        public int Top { get; set; } = 0;


        public List<Disco> Elementos { get; set; }


        /* TODO: Implementar métodos */
        public Pila()
        {
            this.Elementos = new List<Disco>();
        }

        public void push(Disco d)
        {
            this.Elementos.Add(d);
            this.Top = d.Valor;
            this.Size++;
        }

        public Disco pop()
        {

            for (int i = 0; i < Elementos.Count; i++)
            {
                if (Elementos[i].Valor == Top)
                {
                    Disco d = new Disco(Elementos[i].Valor);
                    this.Size--;
                    Elementos.RemoveAt(i);
                    if (Size != 0)
                    {
                        this.Top = Elementos[this.Size - 1].Valor;
                    }
                    else if (Size <= 0)
                    {
                        this.Top = 0;
                    }
                    return d;

                }
            }
            this.Size--;
            return null;
        }

        public bool isEmpty()
        {
            if (this.Size == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
