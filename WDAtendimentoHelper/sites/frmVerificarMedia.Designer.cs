namespace WDAtendimentoHelper.sites
{
    partial class frmVerificarMedia
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCaminhoTemplate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.cmdVerificar = new System.Windows.Forms.Button();
            this.txtMySqlProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCaminhoFisico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstArquivosNaoUsados = new System.Windows.Forms.ListBox();
            this.lblConcluido = new System.Windows.Forms.Label();
            this.cmdExcluir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFTP = new System.Windows.Forms.TextBox();
            this.txtFTPUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFTPPWD = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFTPPWD);
            this.groupBox1.Controls.Add(this.Label);
            this.groupBox1.Controls.Add(this.txtFTPUser);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFTP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCaminhoTemplate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblMsg);
            this.groupBox1.Controls.Add(this.cmdVerificar);
            this.groupBox1.Controls.Add(this.txtMySqlProd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCaminhoFisico);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados gerais";
            // 
            // txtCaminhoTemplate
            // 
            this.txtCaminhoTemplate.Location = new System.Drawing.Point(107, 86);
            this.txtCaminhoTemplate.Name = "txtCaminhoTemplate";
            this.txtCaminhoTemplate.Size = new System.Drawing.Size(465, 20);
            this.txtCaminhoTemplate.TabIndex = 6;
            this.txtCaminhoTemplate.Text = "J:\\acoscanada.com.br\\web\\template";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Caminho Template";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(13, 162);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(13, 13);
            this.lblMsg.TabIndex = 4;
            this.lblMsg.Text = "[]";
            // 
            // cmdVerificar
            // 
            this.cmdVerificar.Location = new System.Drawing.Point(497, 153);
            this.cmdVerificar.Name = "cmdVerificar";
            this.cmdVerificar.Size = new System.Drawing.Size(75, 23);
            this.cmdVerificar.TabIndex = 1;
            this.cmdVerificar.Text = "Verificar";
            this.cmdVerificar.UseVisualStyleBackColor = true;
            this.cmdVerificar.Click += new System.EventHandler(this.cmdVerificar_Click);
            // 
            // txtMySqlProd
            // 
            this.txtMySqlProd.Location = new System.Drawing.Point(107, 57);
            this.txtMySqlProd.Name = "txtMySqlProd";
            this.txtMySqlProd.Size = new System.Drawing.Size(465, 20);
            this.txtMySqlProd.TabIndex = 3;
            this.txtMySqlProd.Text = "server=mysql.lccloud.com.br;database=acoscana_portal;user=acoscana_admin;pwd=Zocn" +
    "01!7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "MySQL Produção";
            // 
            // txtCaminhoFisico
            // 
            this.txtCaminhoFisico.Location = new System.Drawing.Point(107, 28);
            this.txtCaminhoFisico.Name = "txtCaminhoFisico";
            this.txtCaminhoFisico.Size = new System.Drawing.Size(465, 20);
            this.txtCaminhoFisico.TabIndex = 1;
            this.txtCaminhoFisico.Text = "J:\\acoscanada.com.br\\web\\media";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caminho Media";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstArquivosNaoUsados);
            this.groupBox2.Location = new System.Drawing.Point(12, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 322);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // lstArquivosNaoUsados
            // 
            this.lstArquivosNaoUsados.FormattingEnabled = true;
            this.lstArquivosNaoUsados.Location = new System.Drawing.Point(6, 21);
            this.lstArquivosNaoUsados.Name = "lstArquivosNaoUsados";
            this.lstArquivosNaoUsados.Size = new System.Drawing.Size(576, 290);
            this.lstArquivosNaoUsados.TabIndex = 0;
            // 
            // lblConcluido
            // 
            this.lblConcluido.AutoSize = true;
            this.lblConcluido.Location = new System.Drawing.Point(18, 553);
            this.lblConcluido.Name = "lblConcluido";
            this.lblConcluido.Size = new System.Drawing.Size(13, 13);
            this.lblConcluido.TabIndex = 2;
            this.lblConcluido.Text = "[]";
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.ForeColor = System.Drawing.Color.Red;
            this.cmdExcluir.Location = new System.Drawing.Point(509, 548);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(75, 23);
            this.cmdExcluir.TabIndex = 3;
            this.cmdExcluir.Text = "Excluir";
            this.cmdExcluir.UseVisualStyleBackColor = true;
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "FTP";
            // 
            // txtFTP
            // 
            this.txtFTP.Location = new System.Drawing.Point(107, 115);
            this.txtFTP.Name = "txtFTP";
            this.txtFTP.Size = new System.Drawing.Size(190, 20);
            this.txtFTP.TabIndex = 8;
            this.txtFTP.Text = "ftp://ftp.lccloud.com.br/httpdocs/";
            // 
            // txtFTPUser
            // 
            this.txtFTPUser.Location = new System.Drawing.Point(338, 115);
            this.txtFTPUser.Name = "txtFTPUser";
            this.txtFTPUser.Size = new System.Drawing.Size(91, 20);
            this.txtFTPUser.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "User";
            // 
            // txtFTPPWD
            // 
            this.txtFTPPWD.Location = new System.Drawing.Point(477, 115);
            this.txtFTPPWD.Name = "txtFTPPWD";
            this.txtFTPPWD.Size = new System.Drawing.Size(95, 20);
            this.txtFTPPWD.TabIndex = 12;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(440, 118);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(33, 13);
            this.Label.TabIndex = 11;
            this.Label.Text = "PWD";
            // 
            // frmVerificarMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 577);
            this.Controls.Add(this.cmdExcluir);
            this.Controls.Add(this.lblConcluido);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVerificarMedia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verifica Media";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCaminhoFisico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMySqlProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdVerificar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstArquivosNaoUsados;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblConcluido;
        private System.Windows.Forms.Button cmdExcluir;
        private System.Windows.Forms.TextBox txtCaminhoTemplate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFTPPWD;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox txtFTPUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFTP;
        private System.Windows.Forms.Label label4;
    }
}