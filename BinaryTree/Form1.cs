using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinaryTree;

namespace BinaryTree
{
    public partial class Form1 : Form
    {
        Arbol_Binario arbol;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            arbol = new Arbol_Binario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                arbol.Insertar(int.Parse(txtDato.Text));
                lblResultados.Text = arbol.Arbol.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
