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
    public partial class Login : Form
    {
        // Variáveis ou Propriedades da Classe
        private string usuarioDB = "zeadmin";
        private string senhaDB = "1234";


        public Login()
        {
            InitializeComponent();

            // Forçando a Transparência desta tela evitando erros de sobreposição ao carregar na tela Inicio
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;

        }

        /// <summary>
        /// Construtor do click do botão "btnEntrar"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Pegando o que foi digitado pelo usuário nos campos
            string usuarioTela = txtUsuario.Text;
            string senhaTela = txtSenha.Text;

            // Executa a lógica do login ao clicar sobre este botão
            if ( usuarioDB == usuarioTela && senhaDB == senhaTela ) 
            {
                // se o if é verdadeiro
                // Inserindo texto no label lblMensagem
                lblMensagem.Text = "Seja bem vindo ao Sistema do Zé do Côco!";
            }
            else
            {
                //se o if for falso 
                lblMensagem.Text = "Ocorreu um erro: Login ou senha inválidos!";
            }
        }
    }
}
