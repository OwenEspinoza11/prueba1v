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
    public partial class frmTipoDepreciacion : Form
    {
        public frmTipoDepreciacion()
        {
            InitializeComponent();
        }

        private void frmTipoDepreciacion_Load(object sender, EventArgs e)
        {
            txtDepreBien.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor, depreciacion;
            if (mtxtValorBien.Text == "")
            {
                MessageBox.Show("Ingrese un valor válido", "jijijija");
            }
            else
            {

                if (lbxTipo.Text == "Suma de Digitos")
                {
                    valor = Convert.ToDouble(mtxtValorBien.Text);

                    if (cbxVeh.Checked == true || cbxEqOf.Checked == true || cbxEdi.Checked == true)
                    {
                        if (valor != 0)
                        {
                            depreciacion = (valor * (valor + 1)) / 2;
                            txtDepreBien.Text = depreciacion.ToString();
                        }
                    }
                    //else if (cbxEdi.Checked == true)
                    //{
                    //    if (valor != 0)
                    //    {
                    //        depreciacion = (valor * (valor + 1)) / 2;
                    //        txtDepreBien.Text = depreciacion.ToString();
                    //    }
                    //}
                    //else if (cbxEqOf.Checked == true)
                    //{
                    //    if (valor != 0)
                    //    {
                    //        depreciacion = (valor * (valor + 1)) / 2;
                    //        txtDepreBien.Text = depreciacion.ToString();
                    //    }
                    //}
                    else if (cbxVeh.Checked == false && cbxEqOf.Checked == false && cbxEdi.Checked == false)
                    {
                        MessageBox.Show("Seleccione una opcion");
                    }
                }
                else if(lbxTipo.Text == "Linea recta")
                {


                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            mtxtValorBien.Clear();
            txtDepreBien.Clear();
            mtxtValorBien.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}