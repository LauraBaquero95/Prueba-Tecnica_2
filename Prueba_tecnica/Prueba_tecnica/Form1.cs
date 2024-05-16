using System.Collections;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Prueba_tecnica
{

    public partial class Form1 : Form
    {
     
        List<int> numeros = new List<int>();
        List<int> par = new List<int>();
        List<int> impar = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                int numero = int.Parse(txtNumeros.Text);
                numeros.Add(numero);
                txtNumeros.Text = "";

                // Actualizar el ListBox


                listNumeros.Items.Add(numero.ToString());

            } catch (FormatException)
            {
                MessageBox.Show("Error formato invalido");
            }

        }

        private void BtnOrdenar_Click(object sender, EventArgs e)
        {
            foreach (int n in numeros)
            {
                if (n % 2 == 0)
                {
                    par.Add(n);
                }
                else
                {
                    impar.Add(n);
                }

            }
            par.Sort();
            impar.Sort();
            var combinado = par.Concat(impar);
            foreach (int n in combinado)
            {
                lisOrdenados.Items.Add(n.ToString());
            }
           
            
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            lisOrdenados.Items.Clear();
            listNumeros.Items.Clear();
            numeros.Clear();
        }
    }
}
