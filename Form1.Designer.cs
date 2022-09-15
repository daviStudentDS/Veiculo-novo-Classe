namespace Projeto_Veículo_AGLRN
{
    partial class frmMenu
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
            this.btnFormCarro = new System.Windows.Forms.Button();
            this.btnFormCaminhao = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormCarro
            // 
            this.btnFormCarro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormCarro.Location = new System.Drawing.Point(220, 163);
            this.btnFormCarro.Name = "btnFormCarro";
            this.btnFormCarro.Size = new System.Drawing.Size(99, 45);
            this.btnFormCarro.TabIndex = 0;
            this.btnFormCarro.Text = "Carro";
            this.btnFormCarro.UseVisualStyleBackColor = true;
            this.btnFormCarro.Click += new System.EventHandler(this.btnFormCarro_Click);
            // 
            // btnFormCaminhao
            // 
            this.btnFormCaminhao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormCaminhao.Location = new System.Drawing.Point(81, 163);
            this.btnFormCaminhao.Name = "btnFormCaminhao";
            this.btnFormCaminhao.Size = new System.Drawing.Size(99, 45);
            this.btnFormCaminhao.TabIndex = 1;
            this.btnFormCaminhao.Text = "Caminhão";
            this.btnFormCaminhao.UseVisualStyleBackColor = true;
            this.btnFormCaminhao.Click += new System.EventHandler(this.btnFormCaminhao_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(355, 163);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 45);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 350);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFormCaminhao);
            this.Controls.Add(this.btnFormCarro);
            this.Name = "frmMenu";
            this.Text = "Veículo";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormCarro;
        private System.Windows.Forms.Button btnFormCaminhao;
        private System.Windows.Forms.Button btnSair;
    }
}

