using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepreciacionEnLinea
{
    public partial class frmInicioSesion : Form
    {

        frmMenu logeo;
        int progreso;
        public frmInicioSesion()
        {
            InitializeComponent();
            progreso = 0;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text != "") && (txtPassword.Text != "") || (txtUsuario.Text != null && txtPassword.Text != null))

            {
                if ((txtUsuario.Text == "odel") && (txtPassword.Text == "4321"))
                {
                    if (progreso >= 0 && progreso <= 100)
                    {
                        progreso += 100;
                        progressBar1.Value = progreso;
                    }

                    logeo = new frmMenu();
                    logeo.Show();
                    this.Hide();
                }
                else if ((txtUsuario.Text == "owenn") && (txtPassword.Text == "12345"))
                {
                    
                    progressBar1.Minimum = 1;
                    progressBar1.Maximum = 100;
                    progressBar1.Step = 10;
                    for (int i = 0; i < 10; i++)
                    { 
                        progressBar1.PerformStep(); 
                        btnSeguir.Enabled = true;
                    }

                        
                        



                }
            }
            else if (txtUsuario.Text == "" || txtUsuario.Text == "")
            {
                MessageBox.Show("Datos incompletos", "sea caballo");
            }
        }

        private void btnSeguir_Click(object sender, EventArgs e)
        {
            logeo = new frmMenu();
            logeo.Show();
            this.Hide();
        }
    }
}
