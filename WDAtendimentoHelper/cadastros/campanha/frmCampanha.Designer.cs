namespace WDAtendimentoHelper.cadastros
{
    partial class frmCampanha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscaCliente = new System.Windows.Forms.TextBox();
            this.cmdFechar = new System.Windows.Forms.Button();
            this.cmdSalvar = new System.Windows.Forms.Button();
            this.cmdBuscaCliente = new System.Windows.Forms.Button();
            this.gridBuscaCliente = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDProj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Projeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDono = new System.Windows.Forms.TextBox();
            this.txtDonoEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridBuscaCliente)).BeginInit();
            this.gbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // txtBuscaCliente
            // 
            this.txtBuscaCliente.Location = new System.Drawing.Point(67, 39);
            this.txtBuscaCliente.Name = "txtBuscaCliente";
            this.txtBuscaCliente.Size = new System.Drawing.Size(421, 20);
            this.txtBuscaCliente.TabIndex = 1;
            // 
            // cmdFechar
            // 
            this.cmdFechar.Location = new System.Drawing.Point(413, 466);
            this.cmdFechar.Name = "cmdFechar";
            this.cmdFechar.Size = new System.Drawing.Size(75, 23);
            this.cmdFechar.TabIndex = 2;
            this.cmdFechar.Text = "Fechar";
            this.cmdFechar.UseVisualStyleBackColor = true;
            this.cmdFechar.Click += new System.EventHandler(this.cmdFechar_Click);
            // 
            // cmdSalvar
            // 
            this.cmdSalvar.Location = new System.Drawing.Point(510, 466);
            this.cmdSalvar.Name = "cmdSalvar";
            this.cmdSalvar.Size = new System.Drawing.Size(75, 23);
            this.cmdSalvar.TabIndex = 3;
            this.cmdSalvar.Text = "Salvar";
            this.cmdSalvar.UseVisualStyleBackColor = true;
            this.cmdSalvar.Click += new System.EventHandler(this.cmdSalvar_Click);
            // 
            // cmdBuscaCliente
            // 
            this.cmdBuscaCliente.Location = new System.Drawing.Point(510, 36);
            this.cmdBuscaCliente.Name = "cmdBuscaCliente";
            this.cmdBuscaCliente.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscaCliente.TabIndex = 4;
            this.cmdBuscaCliente.Text = "localizar";
            this.cmdBuscaCliente.UseVisualStyleBackColor = true;
            this.cmdBuscaCliente.Click += new System.EventHandler(this.cmdBuscaCliente_Click);
            // 
            // gridBuscaCliente
            // 
            this.gridBuscaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBuscaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Cliente,
            this.IDProj,
            this.Projeto});
            this.gridBuscaCliente.Location = new System.Drawing.Point(30, 75);
            this.gridBuscaCliente.Name = "gridBuscaCliente";
            this.gridBuscaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBuscaCliente.Size = new System.Drawing.Size(555, 100);
            this.gridBuscaCliente.TabIndex = 5;
            this.gridBuscaCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBuscaCliente_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.DataPropertyName = "ClienteID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // Cliente
            // 
            this.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // IDProj
            // 
            this.IDProj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IDProj.DataPropertyName = "ProjetoID";
            this.IDProj.HeaderText = "ID";
            this.IDProj.Name = "IDProj";
            this.IDProj.ReadOnly = true;
            this.IDProj.Width = 43;
            // 
            // Projeto
            // 
            this.Projeto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Projeto.DataPropertyName = "Projeto";
            this.Projeto.HeaderText = "Projeto";
            this.Projeto.Name = "Projeto";
            this.Projeto.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dono";
            // 
            // txtDono
            // 
            this.txtDono.Location = new System.Drawing.Point(67, 191);
            this.txtDono.Name = "txtDono";
            this.txtDono.Size = new System.Drawing.Size(180, 20);
            this.txtDono.TabIndex = 7;
            // 
            // txtDonoEmail
            // 
            this.txtDonoEmail.Location = new System.Drawing.Point(323, 191);
            this.txtDonoEmail.Name = "txtDonoEmail";
            this.txtDonoEmail.Size = new System.Drawing.Size(262, 20);
            this.txtDonoEmail.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "E-mail Dono";
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.cboSexo);
            this.gbCliente.Controls.Add(this.label6);
            this.gbCliente.Controls.Add(this.txtEmailCliente);
            this.gbCliente.Controls.Add(this.label5);
            this.gbCliente.Controls.Add(this.txtNomeCliente);
            this.gbCliente.Controls.Add(this.label4);
            this.gbCliente.Location = new System.Drawing.Point(30, 230);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(555, 116);
            this.gbCliente.TabIndex = 10;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Dados do cliente";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(47, 31);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(240, 20);
            this.txtNomeCliente.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome";
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(47, 57);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(240, 20);
            this.txtEmailCliente.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "E-mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sexo";
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cboSexo.Location = new System.Drawing.Point(333, 32);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(216, 21);
            this.cboSexo.TabIndex = 13;
            // 
            // frmCampanha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 501);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.txtDonoEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridBuscaCliente);
            this.Controls.Add(this.cmdBuscaCliente);
            this.Controls.Add(this.cmdSalvar);
            this.Controls.Add(this.cmdFechar);
            this.Controls.Add(this.txtBuscaCliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCampanha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Campanha";
            this.Load += new System.EventHandler(this.frmChecklist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBuscaCliente)).EndInit();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscaCliente;
        private System.Windows.Forms.Button cmdFechar;
        private System.Windows.Forms.Button cmdSalvar;
        private System.Windows.Forms.Button cmdBuscaCliente;
        private System.Windows.Forms.DataGridView gridBuscaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Projeto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDono;
        private System.Windows.Forms.TextBox txtDonoEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Label label6;
    }
}