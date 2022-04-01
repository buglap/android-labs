using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calculadora_imc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Calculate_IMC(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Altura.Text) && !string.IsNullOrEmpty(Peso.Text))
            {
                var altura = double.Parse(Altura.Text);
                var peso = double.Parse(Peso.Text);

                var imc = peso / (altura * altura);
                IMC.Text = imc.ToString();

                string resultado = "";

                if (imc >= 0 && imc <= 18.49999)
                {
                    resultado = "Tu tienes bajo peso";
                }
                else if (imc >= 18.49999 && imc <= 24.9)
                {
                    resultado = "Tu peso es normal";
                }
                else if (imc >= 24.9 && imc <= 29.9)
                {
                    resultado = "Tu tienes sobrepeso";
                }
                else
                {
                    resultado = "Tienes obesidad, ¡Cuida tu alimentacion!";
                }

                DisplayAlert("Resultado", resultado, "Ok");
            }

            else
            {
                DisplayAlert("Datos Erroneos", "Por favor, llena todos los campos", "Ok");

            }
        }
    }
}