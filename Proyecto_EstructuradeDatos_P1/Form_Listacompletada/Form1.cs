using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Listacompletada
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
                if (int.TryParse(this.Numero1TXT.Text.Trim(), out int numero1) && int.TryParse(this.Numero2TXT.Text.Trim(), out int numero2))
                {
                    if (numero1 > numero2)
                    {
                        int numtemp = numero1;
                        numero1 = numero2;
                        numero2 = numtemp;
                    }
                    LinkedList<int> lista = GenerarLista(numero1, numero2);
                    string numerosresultantes = string.Join(", ", lista);
                    MessageBox.Show(numerosresultantes, "Lista completa", MessageBoxButtons.OK, MessageBoxIcon.Information );
                }
                else
                {
                    MessageBox.Show("Por favor ingrese números válidos en ambos espacios","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.FrmReglas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static LinkedList<int> GenerarLista(int num1, int num2)
        {
            try
            {
                LinkedList<int> lista = new LinkedList<int>();
                for (int i = num1; i <= num2; i++)
                {
                    lista.AddLast(i);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void FrmReglas()
        {
            try
            {
                Reglas reglas = new Reglas();
                reglas.ShowDialog();
                reglas.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }//cierre de clase
}//cierre del namespace
