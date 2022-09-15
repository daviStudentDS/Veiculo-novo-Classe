using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Veículo_AGLRN
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnFormCarro_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCarro carro = new FrmCarro();
            carro.Show();
        }

        private void btnFormCaminhao_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCaminhao caminhao = new FrmCaminhao();
            caminhao.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
