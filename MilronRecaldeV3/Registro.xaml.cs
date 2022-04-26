using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MilronRecaldeV3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtMontoInicio_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void buttonCalcular_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                DisplayAlert("Error", "Ingrese su nombre para registrar el pago", "Aceptar");
                return;
            }

            if (string.IsNullOrEmpty(txtMontoInicio.Text))
            {
                DisplayAlert("Error", "Ingrese un valor Monto", "Aceptar");
                return;
            }

            double d1 = 1800 - Convert.ToDouble(txtMontoInicio.Text);
            double d2 = d1 / 3;
            double d3 = 1800 * 0.05;
            double d4 = d2 + d3;

            txtCalculo.Text = d4.ToString();

        }

        private void buttonGuardar_Clicked(object sender, EventArgs e)
        {

        }
    }
}