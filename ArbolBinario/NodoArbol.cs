using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolBinario
{
    public class NodoArbol
    {
        public int Valor { get; set; }
        public NodoArbol NodoIzquierdo { get; set; }
        public NodoArbol NodoDerecho { get; set; }

        public NodoArbol(int valor)
        {
            Valor = valor;
            NodoIzquierdo = null;
            NodoDerecho = null;
        }
    }

    public class ArbolBinario
    {
        public static NodoArbol raiz;

        public static void Agregar(int valor)
        {
            raiz = AgregarRecursivo(raiz, valor);
        }

        public static NodoArbol AgregarRecursivo(NodoArbol actual, int valor)
        {
            if (actual == null)
            {
                return new NodoArbol(valor);
            }

            if (valor < actual.Valor)
            {
                actual.NodoIzquierdo = AgregarRecursivo(actual.NodoIzquierdo, valor);
            }
            else if (valor > actual.Valor)
            {
                actual.NodoDerecho = AgregarRecursivo(actual.NodoDerecho, valor);
            }

            return actual;
        }


        public static void OrdenarAscendente(ListBox lista_datos)
        {
            Console.WriteLine("Orden ascendente:");
            OrdenarAscendenteRecursivo(raiz, lista_datos);
            Console.WriteLine();
        }

        private static void OrdenarAscendenteRecursivo(NodoArbol nodo, ListBox lista_datos)
        {
            if (nodo != null)
            {
                OrdenarAscendenteRecursivo(nodo.NodoIzquierdo, lista_datos);
                lista_datos.Items.Add(nodo.Valor);
                OrdenarAscendenteRecursivo(nodo.NodoDerecho, lista_datos);
            }
        }

        public static void OrdenarDescendente(ListBox lista_datos)
        {
            Console.WriteLine("Orden descendente:");
            OrdenarDescendenteRecursivo(raiz , lista_datos);
            Console.WriteLine();
        }

        public static void OrdenarDescendenteRecursivo(NodoArbol nodo, ListBox lista_datos)
        {
            if (nodo != null)
            {
                OrdenarDescendenteRecursivo(nodo.NodoDerecho , lista_datos);
                lista_datos.Items.Add(nodo.Valor);
                OrdenarDescendenteRecursivo(nodo.NodoIzquierdo , lista_datos);
            }
        }

        public static void LimpiarArbol()
        {
            raiz = null;
            Console.WriteLine("Árbol limpiado.");
        }
    }

}
