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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void tnCalcular_Click(object sender, EventArgs e)
        {
            double subtotal, total;

            if(mtxtSubtotal.Text == "")
            {
                MessageBox.Show("Ingrese un valor válido", "jijijija");
            }
            else 
            {
                subtotal = Double.Parse(mtxtSubtotal.Text);
                

                if(cbxDescuento.Checked == true)
                {
                    if(subtotal <=500)
                    {

                        if (subtotal > 0 && subtotal < 60)
                        {
                            total = subtotal;
                            txtTotal.Text = total.ToString();
                        }
                        else if (subtotal > 59 && subtotal < 100)
                        {
                            //descuento = subtotal * 0.05;
                            total = subtotal - (subtotal * 0.05);
                            txtTotal.Text = total.ToString();
                        }
                        else if (subtotal > 99 && subtotal <= 500)
                        {
                            //descuento = subtotal * 0.10;
                            total = subtotal - (subtotal * 0.10);
                            txtTotal.Text = total.ToString();
                        }
                        else 
                        {
                            MessageBox.Show("Ingrese un valor dentro del rango");
                        }
                    } 
                }
                else if(cbxDescuento.Checked == false)
                {
                    MessageBox.Show("Marque la casilla de descuento");
                }


            }


        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            txtTotal.Enabled=false;
            mtxtSubtotal.Focus();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            mtxtSubtotal.Clear();
            txtTotal.Clear();
            mtxtSubtotal.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
