using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_de_tarea2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int nota1= Convert.ToInt16(nota1textBox.Text);
            int nota2 = Convert.ToInt16(nota2textBox.Text);
            int nota3 = Convert.ToInt16(nota3textBox.Text);
            int nota4 = Convert.ToInt16(nota4textBox.Text);

            decimal average = await CalcularPromAsync(nota1, nota2, nota3 ,nota4);

            promediotextBox.Text = average.ToString();


        }
        private async Task<decimal> CalcularPromAsync(decimal n1, decimal n2, decimal n3, decimal n4)
        {
            decimal Prom = await Task.Run(() =>
            {
                return (n1 + n2 + n3 + n4) / 4;

            });
                return Prom;
        }
    }
}
