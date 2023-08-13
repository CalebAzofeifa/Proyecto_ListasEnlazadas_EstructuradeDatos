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
    public partial class FRMRecetas : Form
    {
        public FRMRecetas()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRMRecetas_Load(object sender, EventArgs e)
        {
          
        }

        private void AñdirIngr_Click(object sender, EventArgs e)
        {
            try
            {
                this.AñadirIngrMet(PostreAEncontrar.Text.Trim(),IngrName.Text.Trim());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AñadirIngrMet(string nPostre, string nIngrediente)
        {
            try
            {
                if (int.TryParse(this.IngrName.Text.Trim(), out int comprobarnum))
                {
                    MessageBox.Show("Ocurrió un error, digite un ingrediente adecuado que sea compuesto de números.");
                }
                else
                {
                    int indice = Array.FindIndex(Postres.postresarray, postre => postre != null && postre.Nombre == nPostre);
                    LinkedList<string> compIngredientes = Postres.postresarray[indice].Ingredientes;
                    if (compIngredientes.Contains(nIngrediente))
                    {
                        MessageBox.Show("El ingrediente fue agregado anteriormente.");
                    }
                    else if (indice != -1)
                    {
                        Postres.postresarray[indice].Ingredientes.AddLast(nIngrediente);
                        MessageBox.Show("El ingrediente fue agregado con éxito.");
                        this.IngrName.Clear();
                    }
                    else
                    {
                        MessageBox.Show("El postre se pudo encontrar.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EliminarIngrMet()
        {
            try
            {
                Postres buscPostre = Array.Find(Postres.postresarray, postre => postre != null && postre.Nombre == this.PostreAEncontrar.Text.Trim());
                if (buscPostre != null)
                {
                    if (buscPostre.Ingredientes.Remove(this.IngrName.Text.Trim())) 
                    {
                        MessageBox.Show("El ingrediente fue eliminado con éxito.");
                        this.IngrName.Clear();
                    }
                    else
                    {
                        MessageBox.Show("El ingrediente no pudo ser encontrado.");
                    }
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
        private void MostrarIngrMet()
        {
            Postres buscPostre = Array.Find(Postres.postresarray, pos => pos != null && pos.Nombre == this.PostreAEncontrar.Text.Trim());
            if (buscPostre != null)
            {
                string ingredienteslistados = string.Join(", ", buscPostre.Ingredientes);
                MessageBox.Show("Ingredientes del postre " + buscPostre.Nombre + ":\n" + ingredienteslistados);
            }
            else
            {
                MessageBox.Show("El postre no pudo ser encontrado.");
            }
        }

        private void MostrarIngr_Click(object sender, EventArgs e)
        {
            try
            {
                this.MostrarIngrMet();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        private void ElimIngr_Click(object sender, EventArgs e)
        {
            try
            {
                this.EliminarIngrMet();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }//cierre de la clase
}//cierre del namespace
