using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Entidades.Facade;

namespace WDAtendimentoHelper.cadastros
{
    public partial class frmCampanha : Form
    {
        long _id = 0;

        public frmCampanha(MDIParent1 mdi, long? id)
        {
            this.MdiParent = mdi;
            if (id != null) _id = id.Value;

            InitializeComponent();

            cboSexo.SelectedIndex = 0;
        }

        private void frmChecklist_Load(object sender, EventArgs e)
        {
            if (_id > 0)
            {
                CheckListItem item = CheckListFacade.Instance.Carregar(_id);
                txtBuscaCliente.Text = item.Texto;
            }
        }

        private void cmdFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            Campanha c = null;

            if (_id > 0)
                c = CampanhaFacade.Instance.Carregar(_id);
            else
                c = new Campanha();

            c.Cliente = Convert.ToString(gridBuscaCliente.SelectedRows[0].Cells[1].Value);
            c.ClienteId = Convert.ToInt64(gridBuscaCliente.SelectedRows[0].Cells[0].Value);

            //CheckListFacade.Instance.Salvar(item);

            this.Close();
        }

        private void cmdBuscaCliente_Click(object sender, EventArgs e)
        {
            if (txtBuscaCliente.Text.Trim().Length == 0)
            {
                MessageBox.Show("Informe um parâmetro para busca.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            var clientes = ClienteFacade.Instance.CarregarPor(txtBuscaCliente.Text);

            gridBuscaCliente.AutoGenerateColumns = false;
            gridBuscaCliente.DataSource = clientes;

            Cursor.Current = Cursors.Default;
        }

        private void gridBuscaCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }
    }
}
