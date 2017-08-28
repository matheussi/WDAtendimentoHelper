using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WDAtendimentoHelper
{
    public partial class MDIParent1 : Form
    {
        int limit1 = 11801; //, limit2 = 10;
        bool chamado = false;
        bool processando = false;

        private int childFormNumber = 0;

        cadastros.frmChecklists _frmChecklists = null;
        cadastros.frmTextoEmailLista _frmTextoEmailLista = null;
        cadastros.frmCampanhas _frmCampanhas = null;
        plesk.frmSenhaAssinatura _frmSenhaAssinatura = null;
        sites.frmVerificarMedia _frmVerificarMedia = null;

        public MDIParent1()
        {
            InitializeComponent();
            this.timer1_Tick(null, null);
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }


        void _frmChecklists_FormClosing(object sender, FormClosingEventArgs e)
        {
            _frmChecklists = null;
        }
        private void chkListStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (_frmChecklists != null)
            {
                _frmChecklists.Focus();
            }
            else
            {
                _frmChecklists = new cadastros.frmChecklists(this);
                _frmChecklists.FormClosing += _frmChecklists_FormClosing;
                _frmChecklists.Show();
            }
            Cursor.Current = Cursors.Default;
        }

        void _frmTextoEmailLista_FormClosing(object sender, FormClosingEventArgs e)
        {
            _frmTextoEmailLista = null;
        }
        private void mailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (_frmTextoEmailLista != null)
            {
                _frmTextoEmailLista.Focus();
            }
            else
            {
                _frmTextoEmailLista = new cadastros.frmTextoEmailLista(this);
                _frmTextoEmailLista.FormClosing += _frmTextoEmailLista_FormClosing;
                _frmTextoEmailLista.Show();
            }
            Cursor.Current = Cursors.Default;
        }

        void __frmCampanhas_FormClosing(object sender, FormClosingEventArgs e)
        {
            _frmCampanhas = null;
        }
        private void CampanhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (_frmCampanhas != null)
            {
                _frmCampanhas.Focus();
            }
            else
            {
                _frmCampanhas = new cadastros.frmCampanhas(this);
                _frmCampanhas.FormClosing += __frmCampanhas_FormClosing;
                _frmCampanhas.Show();
            }
            Cursor.Current = Cursors.Default;
        }

        void __frmSenhaAssinatura_FormClosing(object sender, FormClosingEventArgs e)
        {
            _frmSenhaAssinatura = null;
        }
        private void senhaAssinaturaTSMI_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (_frmSenhaAssinatura != null)
            {
                _frmSenhaAssinatura.Focus();
            }
            else
            {
                _frmSenhaAssinatura = new plesk.frmSenhaAssinatura(this, null);
                _frmSenhaAssinatura.FormClosing += __frmSenhaAssinatura_FormClosing;
                _frmSenhaAssinatura.Show();
            }
            Cursor.Current = Cursors.Default;
        }

        void __frmVerificaMedia_FormClosing(object sender, FormClosingEventArgs e)
        {
            _frmVerificarMedia = null;
        }
        private void verificarMediaTSMI_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (_frmVerificarMedia != null)
            {
                _frmVerificarMedia.Focus();
            }
            else
            {
                _frmVerificarMedia = new sites.frmVerificarMedia(this);
                _frmVerificarMedia.FormClosing += __frmVerificaMedia_FormClosing;
                _frmVerificarMedia.Show();
            }
            Cursor.Current = Cursors.Default;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (processando) return;

            //processando = true;

            //if (chamado)
            //{
            //    limit1 += 10;
            //}
            //else
            //    chamado = true;

            //string url = "http://www.cesa.org.br/crop.php?limit=l1&limit2=l2"
            //    .Replace("l1",limit1.ToString())
            //    .Replace("l2",(limit1 + 10).ToString());

            //try
            //{

            //    System.Net.WebRequest request = System.Net.WebRequest.Create(url);
            //    System.Net.WebResponse response = request.GetResponse();
            //    System.IO.StreamReader sr = new System.IO.StreamReader(response.GetResponseStream(), System.Text.Encoding.GetEncoding("iso-8859-1"));
            //    String html = sr.ReadToEnd();
            //    sr.Close();
            //    response.Close();

            //    processando = false;
            //}
            //catch
            //{
            //    chamado = false; //para tentar de novo
            //}
        }
    }
}
