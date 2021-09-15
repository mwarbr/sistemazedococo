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
    public partial class Inicio : Form
    {
        // propriedade privada que armazena a tela ativa
        // Form é a classe do Visual Studio que gera as telas
        private Form telaAtiva = null;

        // construtor da tela Início 
        public Inicio()
        {
            InitializeComponent();

            // Carregamos a tela de Menu ao abrir o programa
            CarregaTela( new Login() );
        }

        /// <summary>
        /// Método que carrega as telas dentro da tela Inicio
        /// </summary>
        private void CarregaTela( Form telaCarregada )
        {
            /*
                1. Se existe uma tela carregada, descarregue.
                2. Carregar a tela nova dentro da Inicio
            */
            if( telaAtiva != null )
            {
                telaAtiva.Close();// fecha a tela
            }
            // armazenamos na propriedade da classe a telal carregada
            telaAtiva = telaCarregada;

            // informa que esta tela NÃO é a principal
            telaCarregada.TopLevel = false;
            // carregar preenchendo a Início
            telaCarregada.Dock = DockStyle.Fill;
            // carregamos a tela dentro do painel conteúdos
            conteudos.Controls.Add(telaCarregada);
            // manter o identificador da tela carregada
            conteudos.Tag = telaCarregada;
            // Colocamos a tela que foi carregada acima
            telaCarregada.BringToFront();
            // exibimos a tela carregada
            telaCarregada.Show();
        }

        
    }
}
