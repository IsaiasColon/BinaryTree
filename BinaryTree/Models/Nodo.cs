using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.Models
{
    public class Nodo
    {
        public int Info { get; set; }
        public Nodo Padre { get; set; }
        public Nodo Menor { get; set; }
        public Nodo Mayor { get; set; }
        public int Altura { get; set; }
        public int Nivel { get; set; }

        public Nodo(int info, Nodo padre, Nodo menor, Nodo mayor)
        {
            Info = info;
            Padre = padre;
            Menor = menor;
            Mayor = mayor;
            Altura = 0;
        }

    }
}
