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
    public partial class frmChecklists : Form
    {
        frmChecklist _frmChecklist = null;

        public frmChecklists(MDIParent1 mdi)
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
            grid.DataSource = CheckListFacade.Instance.Carregar();
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0) return;

            var row = grid.Rows[e.RowIndex];

            if (_frmChecklist != null)
            {
                _frmChecklist.Close();
                _frmChecklist = null;
                return;
            }

            long id = Convert.ToInt64(row.Cells[0].Value);
            _frmChecklist = new cadastros.frmChecklist((MDIParent1)this.MdiParent, id);
            _frmChecklist.FormClosing += _frmChecklists_FormClosing;
            _frmChecklist.Show();
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows == null || grid.SelectedRows.Count == 0) return;

            var res = MessageBox.Show("Deseja excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == System.Windows.Forms.DialogResult.No) return;

            int index = grid.SelectedRows[0].Index;
            long id = Convert.ToInt64(grid.Rows[index].Cells[0].Value);

            CheckListFacade.Instance.Excluir(id);
            this.carregaDados();
        }

        void _frmChecklists_FormClosing(object sender, FormClosingEventArgs e)
        {
            _frmChecklist = null;
            this.carregaDados();
        }
        private void cmdNovo_Click(object sender, EventArgs e)
        {
            if (_frmChecklist != null)
            {
                _frmChecklist.Focus();
            }
            else
            {
                _frmChecklist = new cadastros.frmChecklist((MDIParent1)this.MdiParent, null);
                _frmChecklist.FormClosing += _frmChecklists_FormClosing;
                _frmChecklist.Show();
            }
        }
    }
}
