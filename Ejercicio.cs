using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IParcial
{
    public partial class Ejercicio : Form
    {
        public Ejercicio()
        {
            InitializeComponent();
        }

        private async void PromedioAsincronaButton_Click(object sender, EventArgs e)
        {
            decimal nota1 = Convert.ToDecimal(NotaIPTextBox.Text);
            decimal nota2 = Convert.ToDecimal(NotaIIPTextBox.Text);
            decimal nota3 = Convert.ToDecimal(NotaIIIPTextBox.Text);
            decimal nota4 = Convert.ToDecimal(NotaIVPTextBox.Text);

            decimal total = await PromedioAsync(nota1, nota2, nota3, nota4) / 4;

            MessageBox.Show($"El Promedio es: {total}");
        }

        private async Task<decimal> PromedioAsync(decimal nota1, decimal nota2, decimal nota3, decimal nota4)
        {

            decimal promedio = await Task.Run(() =>
            {
                return nota1 + nota2 + nota3 + nota4;
            });
            return promedio;
        }

    }
}
