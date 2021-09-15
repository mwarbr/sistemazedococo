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
        public Login()
        {
            InitializeComponent();

            // Forçando a Transparência desta tela evitando erros
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;

        }
    }
}
