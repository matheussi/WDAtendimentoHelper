namespace WDAtendimentoHelper.plesk
{
    partial class frmSenhaAssinatura
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmdFechar = new System.Windows.Forms.Button();
            this.cmdSalvar = new System.Windows.Forms.Button();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdTeste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(67, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(498, 20);
            this.txtNome.TabIndex = 1;
            // 
            // cmdFechar
            // 
            this.cmdFechar.Location = new System.Drawing.Point(393, 431);
            this.cmdFechar.Name = "cmdFechar";
            this.cmdFechar.Size = new System.Drawing.Size(75, 23);
            this.cmdFechar.TabIndex = 2;
            this.cmdFechar.Text = "Fechar";
            this.cmdFechar.UseVisualStyleBackColor = true;
            this.cmdFechar.Click += new System.EventHandler(this.cmdFechar_Click);
            // 
            // cmdSalvar
            // 
            this.cmdSalvar.Location = new System.Drawing.Point(490, 431);
            this.cmdSalvar.Name = "cmdSalvar";
            this.cmdSalvar.Size = new System.Drawing.Size(75, 23);
            this.cmdSalvar.TabIndex = 3;
            this.cmdSalvar.Text = "Salvar";
            this.cmdSalvar.UseVisualStyleBackColor = true;
            this.cmdSalvar.Click += new System.EventHandler(this.cmdSalvar_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(67, 45);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTexto.Size = new System.Drawing.Size(498, 89);
            this.txtTexto.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Texto";
            // 
            // cmdTeste
            // 
            this.cmdTeste.Location = new System.Drawing.Point(490, 153);
            this.cmdTeste.Name = "cmdTeste";
            this.cmdTeste.Size = new System.Drawing.Size(75, 23);
            this.cmdTeste.TabIndex = 6;
            this.cmdTeste.Text = "Teste";
            this.cmdTeste.UseVisualStyleBackColor = true;
            this.cmdTeste.Click += new System.EventHandler(this.cmdTeste_Click);
            // 
            // frmSenhaAssinatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 466);
            this.Controls.Add(this.cmdTeste);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdSalvar);
            this.Controls.Add(this.cmdFechar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSenhaAssinatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Texto de email";
            this.Load += new System.EventHandler(this.frmTextoEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button cmdFechar;
        private System.Windows.Forms.Button cmdSalvar;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdTeste;
    }
}