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
    public partial class frmChecklist : Form
    {
        long _id = 0;
        public frmChecklist(MDIParent1 mdi, long? id)
        {
            this.MdiParent = mdi;
            if (id != null) _id = id.Value;

            InitializeComponent();
        }

        private void frmChecklist_Load(object sender, EventArgs e)
        {
            if (_id > 0)
            {
                CheckListItem item = CheckListFacade.Instance.Carregar(_id);
                txtTexto.Text = item.Texto;
            }
        }

        private void cmdFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            CheckListItem item = null;

            if (_id > 0)
                item = CheckListFacade.Instance.Carregar(_id);
            else
                item = new CheckListItem();

            item.Texto = txtTexto.Text;

            CheckListFacade.Instance.Salvar(item);

            this.Close();
        }
    }
}
