using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Proyecto_EstructuradeDatos
{
    public partial class FRMPostres : Form
    {

        public FRMPostres()
        {
            InitializeComponent();
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void PostresDisponibles_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarPosMet()
        {
            try
            {
                if (int.TryParse(this.PNameTXT.Text.Trim(), out int comprobarnum))
                {
                    MessageBox.Show("Ocurrió un error, digite un nombre que no esté compuesto de números. ");
                }
                else
                {
                    int indicearray = Array.IndexOf(Postres.postresarray, null);
                    if (Array.Exists(Postres.postresarray, postre => postre != null && postre.Nombre == this.PNameTXT.Text.Trim()))
                    {
                        MessageBox.Show("El postre ya ha sido agregado anteriormente.");
                    }
                    else if (indicearray != -1)
                    {
                        Postres.postresarray[indicearray] = new Postres { Nombre = this.PNameTXT.Text.Trim() };
                        indicearray++;
                        MessageBox.Show("Postre agregado con éxito.");
                        this.PNameTXT.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Ya se añadieron todos los postres. ");
                    }
                }
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }



        private void EliminarPostreMet()
        {
            try
            {
                int indice = Array.FindIndex(Postres.postresarray, pos => pos != null && pos.Nombre == this.PNameTXT.Text.Trim());
                if (indice != -1)
                {
                    Postres.postresarray[indice] = null;
                    MessageBox.Show("El postre fue eliminado con éxito.");
                    this.PNameTXT.Clear();
                }
                else
                {
                    MessageBox.Show("El postre no pudo ser encontrado.");
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
                this.AgregarPosMet();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.EliminarPostreMet();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void MostrarPostres()
        {
            try
            {
                foreach (var postre in Postres.postresarray)
                {
                    if (postre != null)
                    {
                        string msg = "Postres: " + "\n" + postre.Nombre;
                        MessageBox.Show(msg);
                    }
                }
                MessageBox.Show("No hay más postres.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.MostrarPostres();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }//cierre de clase
}//cierre del namespace
