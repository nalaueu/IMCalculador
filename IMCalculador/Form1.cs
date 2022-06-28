using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMCalculador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso = 0;
            double altura = 0;
            double resultado = 0;

                peso = double.Parse(txtPeso.Text);
                altura = double.Parse(txtAltura.Text);

            resultado = peso / Math.Pow(altura, 2);

            if (resultado >= 1 && resultado <= 18.5)
            {
                lblResultado.Text = resultado.ToString();
                lblSituacao.Text = "Abaixo do peso ideal.";
                lblSituacao.ForeColor = Color.Red;
            }
            else if (resultado > 18.5 && resultado < 24.9)
            {
                lblResultado.Text = resultado.ToString();
                lblSituacao.Text = "Peso ideal.";
                lblSituacao.ForeColor = Color.Green;
            }    
            else if (resultado > 25 && resultado < 29.9)
            {
                lblResultado.Text = resultado.ToString();
                lblSituacao.Text = "Sobrepeso.";
                lblSituacao.ForeColor = Color.Red;
            }
            else if (resultado > 30 && resultado < 34.9)
            {
                lblResultado.Text= resultado.ToString();
                lblSituacao.Text = "Obesidade Grau I";
                lblSituacao.ForeColor = Color.Red;
            }
            else if (resultado > 35 && resultado < 39.9)
            {
                lblResultado.Text = resultado.ToString();
                lblSituacao.Text = "Obesidade Grau II";
                lblSituacao.ForeColor = Color.Red;
            }
            else if(resultado >= 40)
            {
                lblResultado.Text = resultado.ToString();
                lblSituacao.Text = "Obesidade mórbida.";
                lblSituacao.ForeColor = Color.Red;
            }
        }
    }
}
