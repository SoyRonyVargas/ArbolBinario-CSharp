using System;
using System.Diagnostics;

using System.Windows.Forms;

namespace ArbolBinario
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int input = (int)input_dato.Value;
                ArbolBinario.Agregar(input);
                Prompt.Print("Dato ingresado correctamente");
                input_dato.Value = 0;
            }
            catch
            {
                Prompt.Print("Ingresa un dato valido");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lista_datos.Items.Clear();
            ArbolBinario.OrdenarAscendente(lista_datos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lista_datos.Items.Clear();
            ArbolBinario.OrdenarDescendente(lista_datos);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lista_datos.Items.Clear();
            ArbolBinario.LimpiarArbol();
            Prompt.Print("Arbol binario limpiado correctamente");
        }
    }
}
