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
    public partial class frmTextoEmail : Form
    {
        long _id = 0;
        public frmTextoEmail(MDIParent1 mdi, long? id)
        {
            this.MdiParent = mdi;
            if (id != null) _id = id.Value;

            InitializeComponent();
        }

        private void frmTextoEmail_Load(object sender, EventArgs e)
        {
            if (_id > 0)
            {
                TextoEmail obj = TextoEmailFacade.Instance.Carregar(_id);
                txtNome.Text = obj.Nome;
                txtTexto.Text = obj.Texto;
            }
        }

        private void cmdFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "" || txtTexto.Text.Trim() == "")
            {
                MessageBox.Show("Todos os campos são obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            TextoEmail item = null;

            if (_id > 0)
                item = TextoEmailFacade.Instance.Carregar(_id);
            else
                item = new TextoEmail();

            item.Nome = txtNome.Text;
            item.Texto = txtTexto.Text;

            TextoEmailFacade.Instance.Salvar(item);

            this.Close();
        }
    }
}
