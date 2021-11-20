using BinaryTree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Arbol_Binario
    {
        private Nodo arbol;
        public Nodo Arbol
        {
            get { return arbol; }
            set { arbol = value; }
        }

        public Arbol_Binario()
        {
            
        }

        public void Insertar(int info)
        {
            if (arbol != null)
            {
                var tree = ActualizarArbol(info, arbol, 0);
            }
            else
            {
                arbol = new Nodo(info, null, null, null);
            }
        }

        public Nodo ActualizarArbol(int i, Nodo a, int n)
        {
            if (a == null)
            {
                a = new Nodo(i, null, null, null);
                a.Nivel = n;
            }
            else if (i < a.Info)
            {
                n++;
                a.Menor = ActualizarArbol(i, a.Menor, n);
            }
            else if (i > a.Info)
            {
                n++;
                a.Mayor = ActualizarArbol(i, a.Mayor, n);
            }
            else
            {
                throw new ArgumentException("Dato Existente en el Arbol");
            }
            return a;
        } 

        public void Eliminar() { }

        public void Buscar() { }

    }
}
