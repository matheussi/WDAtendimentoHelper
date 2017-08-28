using Entidades;
using Entidades.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WDAtendimentoHelper.cadastros
{
    public partial class frmTextoEmailLista : Form
    {
        frmTextoEmail _frmTextoEmail = null;

        public frmTextoEmailLista(MDIParent1 mdi)
        {
            this.MdiParent = mdi;
            InitializeComponent();
        }

        private void frmChecklists_Load(object sender, EventArgs e)
        {
            this.carregaDados();
        }

        void carregaDados()
        {
            grid.AutoGenerateColumns = false;
            grid.DataSource = TextoEmailFacade.Instance.Carregar();
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0) return;

            var row = grid.Rows[e.RowIndex];

            if (_frmTextoEmail != null)
            {
                _frmTextoEmail.Close();
                _frmTextoEmail = null;
                return;
            }

            long id = Convert.ToInt64(row.Cells[0].Value);
            _frmTextoEmail = new cadastros.frmTextoEmail((MDIParent1)this.MdiParent, id);
            _frmTextoEmail.FormClosing += __frmTextoEmail_FormClosing;
            _frmTextoEmail.Show();
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows == null || grid.SelectedRows.Count == 0) return;

            var res = MessageBox.Show("Deseja excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == System.Windows.Forms.DialogResult.No) return;

            int index = grid.SelectedRows[0].Index;
            long id = Convert.ToInt64(grid.Rows[index].Cells[0].Value);

            TextoEmailFacade.Instance.Excluir(id);
            this.carregaDados();
        }

        void __frmTextoEmail_FormClosing(object sender, FormClosingEventArgs e)
        {
            _frmTextoEmail = null;
            this.carregaDados();
        }
        private void cmdNovo_Click(object sender, EventArgs e)
        {
            if (_frmTextoEmail != null)
            {
                _frmTextoEmail.Focus();
            }
            else
            {
                _frmTextoEmail = new cadastros.frmTextoEmail((MDIParent1)this.MdiParent, null);
                _frmTextoEmail.FormClosing += __frmTextoEmail_FormClosing;
                _frmTextoEmail.Show();
            }
        }
    }
}