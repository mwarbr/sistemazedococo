
namespace sistemazedococo_t89
{
    partial class Inicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.conteudos = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::sistemazedococo_t89.Properties.Resources.logo_transparente_alta;
            this.logo.Location = new System.Drawing.Point(29, 22);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(114, 112);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // btnPerfil
            // 
            this.btnPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPerfil.BackColor = System.Drawing.Color.Transparent;
            this.btnPerfil.BackgroundImage = global::sistemazedococo_t89.Properties.Resources.fundoPerfil;
            this.btnPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Location = new System.Drawing.Point(636, 29);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(70, 30);
            this.btnPerfil.TabIndex = 1;
            this.btnPerfil.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImage = global::sistemazedococo_t89.Properties.Resources.fundoSair;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(721, 29);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(58, 30);
            this.btnSair.TabIndex = 1;
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // conteudos
            // 
            this.conteudos.BackColor = System.Drawing.Color.Transparent;
            this.conteudos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conteudos.Location = new System.Drawing.Point(0, 0);
            this.conteudos.Name = "conteudos";
            this.conteudos.Size = new System.Drawing.Size(816, 456);
            this.conteudos.TabIndex = 2;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sistemazedococo_t89.Properties.Resources.fundoTela;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(816, 456);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.conteudos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(816, 456);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel conteudos;
    }
}

