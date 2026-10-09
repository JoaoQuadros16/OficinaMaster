using ControleEstoqueWindowsForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoqueWindowsForm
{
    public partial class FrmOrdensServico : Form
    {
        public FrmOrdensServico()
        {
            InitializeComponent();

            // valores iniciais dos filtros: todas as OS do mês atual
            cboStatus.SelectedIndex = 0;
            dtpInicio.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpFim.Value = DateTime.Today;
        }

        private void FrmOrdensServico_Load(object sender, EventArgs e)
        {
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dtpFim_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dgvOrdens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnNovaOS_Click(object sender, EventArgs e)
        {
            FrmOrdemServico tela = new FrmOrdemServico();
            tela.ShowDialog(this);
        }

        private void btnAbrirOS_Click(object sender, EventArgs e)
        {
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
