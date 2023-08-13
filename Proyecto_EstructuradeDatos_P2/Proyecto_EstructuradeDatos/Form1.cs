    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Microsoft.VisualBasic;
    using static Proyecto_EstructuradeDatos.Postres;
    namespace Proyecto_EstructuradeDatos
    {
        public partial class Form1 : Form
        {

            public Form1()
            {
                InitializeComponent();
            }

            private void pictureBox1_Click(object sender, EventArgs e)
            {
                Environment.Exit(0);
            }

            private void VerPostres()
            {
                try
                {
                    FRMPostres frmpostres = new FRMPostres();
                   frmpostres.ShowDialog();
                    frmpostres.Dispose();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            private void VerRecetas()
            {
                try
                {
                    FRMRecetas frmRece = new FRMRecetas();
                    frmRece.ShowDialog();
                    frmRece.Dispose();
                }
                catch ( Exception ex ) { throw ex;}
            }

            private void button1_Click(object sender, EventArgs e)
            {
                try
                {
                    this.VerRecetas();
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
                    this.VerPostres();
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
                this.MostrarAyuda();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void MostrarAyuda()
        {
            try
            {
                Ayuda frmayuda = new Ayuda();
                frmayuda.ShowDialog();
                frmayuda.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }//cierre de la clase
    }//cierre del namespace
