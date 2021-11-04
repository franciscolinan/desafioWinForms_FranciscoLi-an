using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafioWinForms_FranciscoLiñan
{
    public partial class Form1 : Form
    {
        Camisa _camisa = new Camisa();
        Pantalon _pantalon = new Pantalon();

        public Form1()
        {
            InitializeComponent();
        }

        private void tipoCamisa_CheckedChanged(object sender, EventArgs e)
        {
            tipoManga.Enabled = true;
            tipoBermuda.Enabled = false;
        }

        private void tipoPantalon_CheckedChanged(object sender, EventArgs e)
        {
            tipoManga.Enabled = false;
            tipoBermuda.Enabled = true;
        }

        private void calcularPrecio_Click(object sender, EventArgs e)
        {
            // Validar campo precio
            //
            if (Utiles.ValidarCampo(precio.Text, "int"))
            {
                precio.BackColor = Color.White;
            }
            else
            {
                precio.BackColor = Color.Red;
                return;
            }

            // Validar campo cantidad
            //
            if (Utiles.ValidarCampo(cantidad.Text, "int"))
            {
                cantidad.BackColor = Color.White;
            }
            else
            {
                cantidad.BackColor = Color.Red;
                return;
            }

            if (tipoCamisa.Checked)
            {
                this._camisa.SetTipo(tipoManga.Checked);
                this._camisa.SetCalidad(calidadPremium.Checked);

                // Calcular precio final
                //
                float precio_final = this._camisa.Precio(Convert.ToInt32(precio.Text)) * Convert.ToInt32(cantidad.Text);

                // Mostrar precio final
                //
                MessageBox.Show(precio_final.ToString("N4"));
                return;
            }

            if (tipoPantalon.Checked)
            {
                this._pantalon.SetTipo(tipoBermuda.Checked);
                this._pantalon.SetCalidad(calidadPremium.Checked);

                // Calcular precio final
                //
                float precio_final = this._pantalon.Precio(Convert.ToInt32(precio.Text)) * Convert.ToInt32(cantidad.Text);

                // Mostrar precio final
                //
                MessageBox.Show(precio_final.ToString("N4"));
                return;
            }
        }
    }
}
