using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemazedococo_t89
{
    public partial class Atividades_if_else : Form
    {
        public Atividades_if_else()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble( textBox1.Text ); 
            double valor2 = Convert.ToDouble( textBox2.Text );

            if ( valor1 > valor2 )
            {
                // C#
                label4.Text = "O valor1 é maior que o valor 2.";
            }

            if (valor1 < valor2)
            {
                // C#
                label4.Text = "O valor2 é maior que o valor 1.";
            }

            if (valor1 == valor2)
            {
                // C#
                label4.Text = "Os valores são iguais.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Pegar os dados da tela
            int anoNasc = Convert.ToInt32( textBox3.Text );
            int anoEleic = Convert.ToInt32( textBox4.Text );

            // Calcular
            int idade = anoEleic - anoNasc;

            // Comparar se é maior ou igual a 16 anos
            if (idade >= 16)
            {
                label8.Text = "Você tem " + idade + " anos! \n Você pode votar!";
            }
            else
            {
                label8.Text = "Você tem " + idade + " anos! \n Você não pode votar ainda!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Pegar os dados da interface
            int qtdade = Convert.ToInt32( textBox5.Text );
            // Calcular o total
            double total = qtdade * 5.50;
            // Calcular a Qtdade de brindes
            int grupos = qtdade % 3;// pegar a qtdade e dividir por 3 dando como resultgado o RESTO da divisão

            int brindes = qtdade / 3;

            if ( grupos == 0 )
            {
                // Comprou grupos exatos de 3 côcos, pegamos a variável qtdade e dividimos por 3

                label12.Text = "O valor da compra é " + total + " e \n você recebe " + brindes + " brindes \n pela sua compra";
            }
            else
            {
                // Ela não comproru grupos exatos de 3 côcos
                // arredondar o valor da divisão para menos
                double brindesArredondado =  Math.Floor( Convert.ToDouble ( brindes )  ) ;

                label12.Text = "O valor da compra é " + total + " e você \n recebe " + brindesArredondado + " brindes \n pela sua compra";
            }


        }
    }
}
