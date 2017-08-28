using System;
using Entidades;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using Entidades.Facade;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;

using System.Net;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WDAtendimentoHelper.sites
{
    public partial class frmVerificarMedia : Form
    {
        public frmVerificarMedia(MDIParent1 mdi)
        {
            this.MdiParent = mdi;
            InitializeComponent();

            // ACOS CANADA
            txtCaminhoFisico.Text = @"J:\acoscanada.com.br\web\media";
            txtMySqlProd.Text = @"server=mysql.lccloud.com.br;database=acoscana_portal;user=acoscana_admin;pwd=Zocn01!7";

            // RRS
            txtCaminhoFisico.Text = @"C:\__temp\rss\media";
            txtMySqlProd.Text = @"server=mysql.lccloud.com.br;database=rrsalime_portal;user=rrsalime_admin;pwd=R3u0yz@3";
            txtCaminhoTemplate.Text = @"C:\__temp\rss\template\";
            txtFTPUser.Text = "rrsalime2";
            txtFTPPWD.Text = "ksLt0@89";

            //VS CINTOS
            txtCaminhoFisico.Text = @"C:\__temp\vscintos\media";
            string mysqlsenha = "mTkfm^xuO~a";
            txtMySqlProd.Text = @"server=mysql.lccloud.com.br;database=vscintos_portal3;user=vscintos_app3;pwd=" + mysqlsenha;
            txtCaminhoTemplate.Text = @"";
            txtFTPUser.Text = "vscintos";
            txtFTPPWD.Text = "Eiw?a496";

            //CINTOS Exclusivos
            txtCaminhoFisico.Text = @"C:\__temp\cintosexclusivos\media";
            mysqlsenha = "Ncv7r8?5";
            txtMySqlProd.Text = @"server=mysql.lccloud.com.br;database=cintosex_portal;user=cintosex_admin;pwd=" + mysqlsenha;
            txtCaminhoTemplate.Text = @"";
            txtFTPUser.Text = "cintosex";
            txtFTPPWD.Text = "Ftu_4r60";

            //SALUS PRIME
            txtCaminhoFisico.Text = @"j:\sallusprime2.com.br\dados_prod_temp\media";
            txtMySqlProd.Text = @"server=mysql.lccloud.com.br;database=prime_portal;user=prime_admin;pwd=mQo*53b0";
            txtCaminhoTemplate.Text = @"";//c:\__temp\sallusprime\template\
            txtFTPUser.Text = "prime";
            txtFTPPWD.Text = "Givg388%";

            //COLEGIO MORUMBI
            txtCaminhoFisico.Text = @"C:\inetpub\publish\__temp\morumbi\media";
            txtMySqlProd.Text = @"server=mysql.lccloud.com.br;database=escolamo_portal;user=escolamo_admin;pwd=Tel@5d48";
            txtCaminhoTemplate.Text = ""; // @"c:\__temp\morumbi\template\";
            txtFTPUser.Text = "escolamo";
            txtFTPPWD.Text = "kX0qw3#6";

            lblMsg.Text = "";
            lblConcluido.Text = "";
        }

        List<MediaVo> VOs { get; set; }

        string toString(object param)
        {
            if (param == null || param == DBNull.Value)
                return "";
            else
                return Convert.ToString(param);
        }

        private void cmdVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                List<string> arquivosLST = new List<string>();

                #region extensões de arquivos 

                string[] arquivosTMP = Directory.GetFiles(
                    txtCaminhoFisico.Text, "*.jpg", SearchOption.AllDirectories); //;*.png;*.gif;*.mp3;*.mp4;*.psd
                arquivosLST.AddRange(arquivosTMP);

                arquivosTMP = Directory.GetFiles(
                    txtCaminhoFisico.Text, "*.gif", SearchOption.AllDirectories);
                arquivosLST.AddRange(arquivosTMP);

                arquivosTMP = Directory.GetFiles(
                    txtCaminhoFisico.Text, "*.png", SearchOption.AllDirectories);
                arquivosLST.AddRange(arquivosTMP);

                arquivosTMP = Directory.GetFiles(
                    txtCaminhoFisico.Text, "*.mp3", SearchOption.AllDirectories);
                arquivosLST.AddRange(arquivosTMP);

                //arquivosTMP = Directory.GetFiles(
                //    txtCaminhoFisico.Text, "*.mp4", SearchOption.AllDirectories);
                //arquivosLST.AddRange(arquivosTMP);

                //arquivosTMP = Directory.GetFiles(
                //    txtCaminhoFisico.Text, "*.pdf", SearchOption.AllDirectories);
                //arquivosLST.AddRange(arquivosTMP);

                arquivosTMP = Directory.GetFiles(
                    txtCaminhoFisico.Text, "*.psd", SearchOption.AllDirectories);
                arquivosLST.AddRange(arquivosTMP);

                /************************************************************************************************************/
                //arquivosLST.Clear();
                //arquivosTMP = Directory.GetFiles(
                //    txtCaminhoFisico.Text, "*.png", SearchOption.AllDirectories);

                //foreach (var tmp in arquivosTMP)
                //{
                //    if (tmp.IndexOf("00002452_contato_jardimeuropa.png") > -1) arquivosLST.Add(tmp);
                //}
                /************************************************************************************************************/

                #endregion

                string[] arquivos = arquivosLST.ToArray();

                List<MediaVo> listaNaoUsado01 = new List<MediaVo>();
                List<MediaVo> listaNaoUsado02 = new List<MediaVo>();
                List<MediaVo> listaNaoUsado03 = new List<MediaVo>();
                List<MediaVo> listaNaoUsado04 = new List<MediaVo>();
                List<MediaVo> listaNaoUsado04b = new List<MediaVo>();
                List<MediaVo> listaNaoUsado05 = new List<MediaVo>();

                List<MediaVo> listaNaoUsado06 = new List<MediaVo>();
                List<MediaVo> listaNaoUsado07 = new List<MediaVo>();
                List<MediaVo> listaNaoUsado08 = new List<MediaVo>();
                List<MediaVo> listaNaoUsado09 = new List<MediaVo>();

                List<MediaVo> listaNaoUsado10 = new List<MediaVo>();
                List<MediaVo> listaNaoUsado11 = new List<MediaVo>();
                List<MediaVo> listaNaoUsado12 = new List<MediaVo>();
                List<MediaVo> listaNaoUsado13 = new List<MediaVo>();
                List<MediaVo> listaNaoUsado14 = new List<MediaVo>();
                List<MediaVo> listaNaoUsado15 = new List<MediaVo>();
                List<MediaVo> listaNaoUsado16 = new List<MediaVo>();
                List<MediaVo> listaNaoUsado17 = new List<MediaVo>();
                List<MediaVo> listaNaoUsado18 = new List<MediaVo>();
                List<MediaVo> listaNaoUsado19 = new List<MediaVo>();
                List<MediaVo> listaNaoUsado20 = new List<MediaVo>();

                string auxArquivo = "", aux = "";
                bool localizado = false;

                DataTable dt = new DataTable();
                using (MySqlConnection conn = new MySqlConnection(txtMySqlProd.Text))
                {
                    #region verifica paginas 

                    this.exibeStatus("Verificando páginas...");

                    conn.Open();
                    MySqlDataAdapter adp = new MySqlDataAdapter("select pagina_texto from smt_pagina", conn);
                    dt = new DataTable();
                    adp.Fill(dt);
                    foreach (string arquivo in arquivos)
                    {
                        //auxArquivo = arquivo.Replace(txtCaminhoFisico.Text.ToLower().Replace(@"media", ""), ""); //arquivo.Replace(@"J:\acoscanada.com.br\web\", "");
                        auxArquivo = txtCaminhoFisico.Text.Substring(0, txtCaminhoFisico.Text.ToLower().IndexOf("media"));
                        auxArquivo = arquivo.Replace(auxArquivo, "").Replace(@"\", "/");

                        localizado = false;

                        this.exibeStatus(string.Concat("Arquivo ", auxArquivo));

                        foreach (DataRow row in dt.Rows)
                        {
                            aux = Convert.ToString(row[0]).ToLower();
                            if (aux.Contains(auxArquivo.ToLower()))
                            {
                                localizado = true;
                                break;
                            }
                        }

                        if (!localizado && arquivo.ToLower().IndexOf("blog") == -1) //excluindo o blog pois ainda não tem checagem pra ele
                        {
                            MediaVo vo = new MediaVo();
                            vo.NomeCompleto = arquivo;
                            vo.NomeTratado = auxArquivo; // auxArquivo.ToLower();
                            listaNaoUsado01.Add(vo);
                        }
                    }

                    #endregion

                    #region verifica albuns

                    this.exibeStatus("Verificando albuns...");

                    dt.Rows.Clear();
                    dt.Dispose();
                    dt = new DataTable();

                    adp.SelectCommand.CommandText = "select foto_url from modulo_album_foto";
                    dt = new DataTable();
                    adp.Fill(dt);

                    foreach (var vo in listaNaoUsado01)
                    {
                        this.exibeStatus(string.Concat("Arquivo ", vo.NomeTratado));

                        localizado = false;
                        if (vo.NomeCompleto.ToLower().IndexOf("album") == -1) //se não é album, entao adiciona e nem verifica
                        {
                            MediaVo vo2 = new MediaVo();
                            vo2.NomeCompleto = vo.NomeCompleto;
                            vo2.NomeTratado = vo.NomeTratado;
                            listaNaoUsado02.Add(vo2);
                        }
                        else
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                //verifica se tem
                                if (vo.NomeTratado.ToLower().Contains(Convert.ToString(row[0]).ToLower()))
                                {
                                    localizado = true; break;
                                }
                            }

                            if (!localizado)
                            {
                                MediaVo vo2 = new MediaVo();
                                vo2.NomeCompleto = vo.NomeCompleto;
                                vo2.NomeTratado = vo.NomeTratado;
                                listaNaoUsado02.Add(vo2);
                            }
                        }
                    }

                    #endregion

                    #region verifica produtos

                    this.exibeStatus("Verificando produtos...");

                    dt.Rows.Clear();
                    dt.Dispose();
                    dt = new DataTable();

                    try
                    {
                        //adp.SelectCommand.CommandText = "SELECT pf.* FROM ecomm_produto p INNER JOIN ecomm_produto_foto pf ON p.produto_id = pf.produto_id where pf.foto_id=137512";
                        adp.SelectCommand.CommandText = "SELECT pf.* FROM ecomm_produto p INNER JOIN ecomm_produto_foto pf ON p.produto_id = pf.produto_id";
                        dt = new DataTable();
                        adp.Fill(dt);

                        foreach (var vo2 in listaNaoUsado02)
                        {
                            this.exibeStatus(string.Concat("Arquivo ", vo2.NomeTratado));

                            localizado = false;
                            foreach (DataRow row in dt.Rows)
                            {
                                //verifica se tem
                                if (vo2.NomeTratado.ToLower().Contains(Convert.ToString(row[2]).ToLower()))
                                {
                                    localizado = true; break;
                                }
                            }

                            if (!localizado)
                            {
                                MediaVo vo3 = new MediaVo();
                                vo3.NomeCompleto = vo2.NomeCompleto;
                                vo3.NomeTratado = vo2.NomeTratado;
                                listaNaoUsado03.Add(vo3);
                            }
                        }
                    }
                    catch
                    {
                        listaNaoUsado03.AddRange(listaNaoUsado02); //se for institucional, vai dar erro, entao adiciona a lista 02 para sequencia no processo
                    }

                    #endregion

                    #region verifica banners

                    this.exibeStatus("Verificando banners...");

                    dt.Rows.Clear();
                    dt.Dispose();
                    dt = new DataTable();

                    adp.SelectCommand.CommandText = "SELECT banner_imagem FROM modulo_banner";
                    dt = new DataTable();
                    adp.Fill(dt);

                    foreach (var vo3 in listaNaoUsado03)
                    {
                        this.exibeStatus(string.Concat("Arquivo ", vo3.NomeTratado));

                        localizado = false;
                        foreach (DataRow row in dt.Rows)
                        {
                            //verifica se tem
                            if (vo3.NomeTratado.ToLower().Contains(Convert.ToString(row[0]).ToLower()))
                            {
                                localizado = true; break;
                            }
                        }

                        if (!localizado)
                        {
                            MediaVo vo4 = new MediaVo();
                            vo4.NomeCompleto = vo3.NomeCompleto;
                            vo4.NomeTratado = vo3.NomeTratado;
                            listaNaoUsado04.Add(vo4);
                        }
                    }

                    #endregion

                    #region verifica banners 2 

                    try
                    {
                        this.exibeStatus("Verificando banners...");

                        dt.Rows.Clear();
                        dt.Dispose();
                        dt = new DataTable();

                        adp.SelectCommand.CommandText = "SELECT * FROM smt_banner";
                        dt = new DataTable();
                        adp.Fill(dt);

                        foreach (var vo4 in listaNaoUsado04)
                        {
                            this.exibeStatus(string.Concat("Arquivo ", vo4.NomeTratado));

                            localizado = false;
                            foreach (DataRow row in dt.Rows)
                            {
                                //verifica se tem
                                if (vo4.NomeTratado.ToLower().Contains(toString(row["banner_1"]).ToLower()) && toString(row["banner_1"]) != "")
                                {
                                    localizado = true; break;
                                }

                                //verifica se tem
                                if (vo4.NomeTratado.ToLower().Contains(toString(row["banner_2"]).ToLower()) && toString(row["banner_2"]) != "")
                                {
                                    localizado = true; break;
                                }

                                //verifica se tem
                                if (vo4.NomeTratado.ToLower().Contains(toString(row["banner_3"]).ToLower()) && toString(row["banner_3"]) != "")
                                {
                                    localizado = true; break;
                                }
                            }

                            if (!localizado)
                            {
                                MediaVo vo4b = new MediaVo();
                                vo4b.NomeCompleto = vo4.NomeCompleto;
                                vo4b.NomeTratado = vo4.NomeTratado;
                                listaNaoUsado04b.Add(vo4);
                            }
                        }
                    }
                    catch
                    {
                        listaNaoUsado04b.AddRange(listaNaoUsado04);
                    }

                    #endregion

                    #region verifica template (*.phtml)

                    bool verificaPHTMLS = txtCaminhoTemplate.Text.Trim().Length > 5;

                    if (verificaPHTMLS)
                    {
                        this.exibeStatus("Verificando phtmls...");

                        string[] phtmls = Directory.GetFiles(
                            txtCaminhoTemplate.Text, "*.phtml", SearchOption.AllDirectories);

                        string conteudo = "";
                        localizado = false;
                        foreach (var vo4 in listaNaoUsado04b)
                        {
                            localizado = false;

                            foreach (string phtml in phtmls)
                            {
                                this.exibeStatus("Verificando arquivo " + Path.GetFileName(phtml));
                                conteudo = File.ReadAllText(phtml);

                                if (conteudo.ToLower().IndexOf(vo4.NomeTratado.ToLower()) > -1)
                                {
                                    localizado = true; break;
                                }
                            }

                            if (!localizado)
                            {
                                MediaVo vo5 = new MediaVo();
                                vo5.NomeCompleto = vo4.NomeCompleto;
                                vo5.NomeTratado = vo4.NomeTratado;
                                listaNaoUsado05.Add(vo4);
                            }
                        }
                    }
                    else
                    {
                        listaNaoUsado05.AddRange(listaNaoUsado04b);
                    }

                    #endregion

                    #region verifica albuns

                    this.exibeStatus("Verificando albuns...");

                    dt.Rows.Clear();
                    dt.Dispose();
                    dt = new DataTable();

                    adp.SelectCommand.CommandText = "select foto_url from modulo_album_foto";
                    dt = new DataTable();
                    adp.Fill(dt);

                    foreach (var vo in listaNaoUsado05) //foreach (var vo in listaNaoUsado01)
                    {
                        this.exibeStatus(string.Concat("Arquivo ", vo.NomeTratado));

                        localizado = false;
                        if (vo.NomeCompleto.ToLower().IndexOf("album") == -1) //se não é album, entao adiciona e nem verifica
                        {
                            MediaVo vo6 = new MediaVo();
                            vo6.NomeCompleto = vo.NomeCompleto;
                            vo6.NomeTratado = vo.NomeTratado;
                            listaNaoUsado06.Add(vo6);
                        }
                        else
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                //verifica se tem
                                if (vo.NomeTratado.ToLower().Contains(Convert.ToString(row[0]).ToLower()))
                                {
                                    localizado = true; break;
                                }
                            }

                            if (!localizado)
                            {
                                MediaVo vo6 = new MediaVo();
                                vo6.NomeCompleto = vo.NomeCompleto;
                                vo6.NomeTratado = vo.NomeTratado;
                                listaNaoUsado06.Add(vo6);
                            }
                        }
                    }

                    #endregion

                    #region verifica blog - texto

                    try
                    {

                        this.exibeStatus("Verificando blog...");

                        //conn.Open();
                        adp = new MySqlDataAdapter("select post_descricao from modulo_blog_post", conn);
                        dt = new DataTable();
                        adp.Fill(dt);
                        foreach (var vo in listaNaoUsado06)
                        {
                            this.exibeStatus(string.Concat("Arquivo ", vo.NomeTratado));

                            localizado = false;
                            foreach (DataRow row in dt.Rows)
                            {
                                //verifica se tem
                                if (Convert.ToString(row[0]).ToLower().Contains(vo.NomeTratado.ToLower()))
                                {
                                    localizado = true; break;
                                }
                            }

                            if (!localizado)
                            {
                                MediaVo _vo = new MediaVo();
                                _vo.NomeCompleto = vo.NomeCompleto;
                                _vo.NomeTratado = vo.NomeTratado;
                                listaNaoUsado07.Add(_vo);
                            }
                        }
                    }
                    catch
                    {
                        listaNaoUsado07.AddRange(listaNaoUsado06);
                    }

                    #endregion

                    #region verifica blog - fotos

                    try
                    {

                        this.exibeStatus("Verificando blog...");

                        //conn.Open();
                        adp = new MySqlDataAdapter("select foto_url from modulo_blog_post_foto", conn);
                        dt = new DataTable();
                        adp.Fill(dt);
                        foreach (var vo in listaNaoUsado07)
                        {
                            this.exibeStatus(string.Concat("Arquivo ", vo.NomeTratado));

                            localizado = false;
                            foreach (DataRow row in dt.Rows)
                            {
                                //verifica se tem
                                //if (Convert.ToString(row[0]).ToLower().Contains(vo.NomeTratado.ToLower()))
                                if (vo.NomeTratado.ToLower().Contains(Convert.ToString(row[0]).ToLower()))
                                {
                                    localizado = true; break;
                                }
                            }

                            if (!localizado)
                            {
                                MediaVo _vo = new MediaVo();
                                _vo.NomeCompleto = vo.NomeCompleto;
                                _vo.NomeTratado = vo.NomeTratado;
                                listaNaoUsado08.Add(_vo);
                            }
                        }
                    }
                    catch
                    {
                        listaNaoUsado08.AddRange(listaNaoUsado07);
                    }

                    #endregion

                    #region verifica modulo memoria

                    try
                    {

                        this.exibeStatus("Verificando módulo memória...");

                        //conn.Open();
                        adp = new MySqlDataAdapter("select memoria_descricao from modulo_memoria", conn);
                        dt = new DataTable();
                        adp.Fill(dt);
                        foreach (var vo in listaNaoUsado08)
                        {
                            this.exibeStatus(string.Concat("Arquivo ", vo.NomeTratado));

                            localizado = false;
                            foreach (DataRow row in dt.Rows)
                            {
                                //verifica se tem
                                if (Convert.ToString(row[0]).ToLower().Contains(vo.NomeTratado.ToLower()))
                                {
                                    localizado = true; break;
                                }
                            }

                            if (!localizado)
                            {
                                MediaVo _vo = new MediaVo();
                                _vo.NomeCompleto = vo.NomeCompleto;
                                _vo.NomeTratado = vo.NomeTratado;
                                listaNaoUsado09.Add(_vo);
                            }
                        }
                    }
                    catch
                    {
                        listaNaoUsado09.AddRange(listaNaoUsado08);
                    }

                    #endregion

                    #region verifica memoria - fotos

                    try
                    {

                        this.exibeStatus("Verificando memória fotos...");

                        //conn.Open();
                        adp = new MySqlDataAdapter("select foto_url from modulo_memoria_foto", conn);
                        dt = new DataTable();
                        adp.Fill(dt);
                        foreach (var vo in listaNaoUsado09)
                        {
                            this.exibeStatus(string.Concat("Arquivo ", vo.NomeTratado));

                            localizado = false;
                            foreach (DataRow row in dt.Rows)
                            {
                                //verifica se tem
                                //if (Convert.ToString(row[0]).ToLower().Contains(vo.NomeTratado.ToLower()))
                                if (vo.NomeTratado.ToLower().Contains(Convert.ToString(row[0]).ToLower()))
                                {
                                    localizado = true; break;
                                }
                            }

                            if (!localizado)
                            {
                                MediaVo _vo = new MediaVo();
                                _vo.NomeCompleto = vo.NomeCompleto;
                                _vo.NomeTratado = vo.NomeTratado;
                                listaNaoUsado10.Add(_vo);
                            }
                        }
                    }
                    catch
                    {
                        listaNaoUsado10.AddRange(listaNaoUsado09);
                    }

                    #endregion

                    #region verifica modulo noticia

                    try
                    {

                        this.exibeStatus("Verificando módulo notícia...");

                        //conn.Open();
                        adp = new MySqlDataAdapter("select noticia_texto from modulo_noticia", conn);
                        dt = new DataTable();
                        adp.Fill(dt);
                        foreach (var vo in listaNaoUsado10)
                        {
                            this.exibeStatus(string.Concat("Arquivo ", vo.NomeTratado));

                            localizado = false;
                            foreach (DataRow row in dt.Rows)
                            {
                                //verifica se tem
                                if (Convert.ToString(row[0]).ToLower().Contains(vo.NomeTratado.ToLower()))
                                {
                                    localizado = true; break;
                                }
                            }

                            if (!localizado)
                            {
                                MediaVo _vo = new MediaVo();
                                _vo.NomeCompleto = vo.NomeCompleto;
                                _vo.NomeTratado = vo.NomeTratado;
                                listaNaoUsado11.Add(_vo);
                            }
                        }
                    }
                    catch
                    {
                        listaNaoUsado11.AddRange(listaNaoUsado10);
                    }

                    #endregion

                    // modulo_produto_foto ??? (tem em itapecerica)

                    #region verifica documentos - arquivos

                    try
                    {
                        this.exibeStatus("Verificando módulo documentos e arquivos...");

                        //conn.Open();
                        adp = new MySqlDataAdapter("select arquivo_nome from pi_documento_arquivo", conn);
                        dt = new DataTable();
                        adp.Fill(dt);
                        foreach (var vo in listaNaoUsado11)
                        {
                            this.exibeStatus(string.Concat("Arquivo ", vo.NomeTratado));

                            localizado = false;
                            foreach (DataRow row in dt.Rows)
                            {
                                if (vo.NomeTratado.ToLower().Contains(Convert.ToString(row[0]).ToLower()))
                                {
                                    localizado = true; break;
                                }
                            }

                            if (!localizado)
                            {
                                MediaVo _vo = new MediaVo();
                                _vo.NomeCompleto = vo.NomeCompleto;
                                _vo.NomeTratado = vo.NomeTratado;
                                listaNaoUsado12.Add(_vo);
                            }
                        }
                    }
                    catch
                    {
                        listaNaoUsado12.AddRange(listaNaoUsado11);
                    }

                    #endregion

                    #region verifica pi_importante

                    try
                    {

                        this.exibeStatus("Verificando módulo PI_Importante...");

                        //conn.Open();
                        adp = new MySqlDataAdapter("select importante_arquivo from pi_importante", conn);
                        dt = new DataTable();
                        adp.Fill(dt);
                        foreach (var vo in listaNaoUsado12)
                        {
                            this.exibeStatus(string.Concat("Arquivo ", vo.NomeTratado));

                            localizado = false;
                            foreach (DataRow row in dt.Rows)
                            {
                                if (vo.NomeTratado.ToLower().Contains(Convert.ToString(row[0]).ToLower()))
                                {
                                    localizado = true; break;
                                }
                            }

                            if (!localizado)
                            {
                                MediaVo _vo = new MediaVo();
                                _vo.NomeCompleto = vo.NomeCompleto;
                                _vo.NomeTratado = vo.NomeTratado;
                                listaNaoUsado13.Add(_vo);
                            }
                        }
                    }
                    catch
                    {
                        listaNaoUsado13.AddRange(listaNaoUsado12);
                    }

                    #endregion

                    #region verifica pi_publicacao

                    try
                    {

                        this.exibeStatus("Verificando módulo PI_Publicacao...");

                        //conn.Open();
                        adp = new MySqlDataAdapter("select publicacao_imagem from pi_importante", conn);
                        dt = new DataTable();
                        adp.Fill(dt);
                        foreach (var vo in listaNaoUsado13)
                        {
                            this.exibeStatus(string.Concat("Arquivo ", vo.NomeTratado));

                            localizado = false;
                            foreach (DataRow row in dt.Rows)
                            {
                                if (vo.NomeTratado.ToLower().Contains(Convert.ToString(row[0]).ToLower()))
                                {
                                    localizado = true; break;
                                }
                            }

                            if (!localizado)
                            {
                                MediaVo _vo = new MediaVo();
                                _vo.NomeCompleto = vo.NomeCompleto;
                                _vo.NomeTratado = vo.NomeTratado;
                                listaNaoUsado14.Add(_vo);
                            }
                        }
                    }
                    catch
                    {
                        listaNaoUsado14.AddRange(listaNaoUsado13);
                    }

                    #endregion

                    #region verifica pi_secretaria

                    try
                    {

                        this.exibeStatus("Verificando módulo PI_Secretaria...");

                        //conn.Open();
                        adp = new MySqlDataAdapter("select secretaria_secretaria_foto from pi_secretaria", conn);
                        dt = new DataTable();
                        adp.Fill(dt);
                        foreach (var vo in listaNaoUsado14)
                        {
                            this.exibeStatus(string.Concat("Arquivo ", vo.NomeTratado));

                            localizado = false;
                            foreach (DataRow row in dt.Rows)
                            {
                                if (vo.NomeTratado.ToLower().Contains(Convert.ToString(row[0]).ToLower()))
                                {
                                    localizado = true; break;
                                }
                            }

                            if (!localizado)
                            {
                                MediaVo _vo = new MediaVo();
                                _vo.NomeCompleto = vo.NomeCompleto;
                                _vo.NomeTratado = vo.NomeTratado;
                                listaNaoUsado15.Add(_vo);
                            }
                        }
                    }
                    catch
                    {
                        listaNaoUsado15.AddRange(listaNaoUsado14);
                    }

                    #endregion

                    #region verifica modulo pi_servico

                    try
                    {

                        this.exibeStatus("Verificando módulo PI_Servico...");

                        //conn.Open();
                        adp = new MySqlDataAdapter("select servico_texto from pi_servico", conn);
                        dt = new DataTable();
                        adp.Fill(dt);
                        foreach (var vo in listaNaoUsado15)
                        {
                            this.exibeStatus(string.Concat("Arquivo ", vo.NomeTratado));

                            localizado = false;
                            foreach (DataRow row in dt.Rows)
                            {
                                //verifica se tem
                                if (Convert.ToString(row[0]).ToLower().Contains(vo.NomeTratado.ToLower()))
                                {
                                    localizado = true; break;
                                }
                            }

                            if (!localizado)
                            {
                                MediaVo _vo = new MediaVo();
                                _vo.NomeCompleto = vo.NomeCompleto;
                                _vo.NomeTratado = vo.NomeTratado;
                                listaNaoUsado16.Add(_vo);
                            }
                        }
                    }
                    catch
                    {
                        listaNaoUsado16.AddRange(listaNaoUsado15);
                    }

                    #endregion


                    //[ESCOLA MORUMBI] Na escola morumbi deu problema

                    #region verifica modulo modulo_cliente_arquivo

                    try
                    {

                        this.exibeStatus("Verificando modulo_cliente_arquivo_varios ...");

                        adp = new MySqlDataAdapter("select arquivo_nome from modulo_cliente_arquivo_varios", conn);
                        dt = new DataTable();
                        adp.Fill(dt);
                        foreach (var vo in listaNaoUsado16)
                        {
                            this.exibeStatus(string.Concat("Arquivo ", vo.NomeTratado));

                            localizado = false;
                            foreach (DataRow row in dt.Rows)
                            {
                                //verifica se tem
                                if (vo.NomeTratado.ToLower().Contains(Convert.ToString(row[0]).ToLower())) //if (Convert.ToString(row[0]).ToLower().Contains(vo.NomeTratado.ToLower()))
                                {
                                    localizado = true; break;
                                }
                            }

                            if (!localizado)
                            {
                                MediaVo _vo = new MediaVo();
                                _vo.NomeCompleto = vo.NomeCompleto;
                                _vo.NomeTratado = vo.NomeTratado;
                                listaNaoUsado17.Add(_vo);
                            }
                        }
                    }
                    catch
                    {
                        listaNaoUsado17.AddRange(listaNaoUsado16);
                    }

                    #endregion

                    #region verifica modulo modulo_cliente_arquivo

                    try
                    {

                        this.exibeStatus("Verificando modulo_cliente_arquivo ...");

                        //conn.Open();
                        adp = new MySqlDataAdapter("select arquivo_nome from modulo_cliente_arquivo", conn);
                        dt = new DataTable();
                        adp.Fill(dt);
                        foreach (var vo in listaNaoUsado17)
                        {
                            this.exibeStatus(string.Concat("Arquivo ", vo.NomeTratado));

                            localizado = false;
                            foreach (DataRow row in dt.Rows)
                            {
                                //verifica se tem
                                if (vo.NomeTratado.ToLower().Contains(Convert.ToString(row[0]).ToLower())) //if (Convert.ToString(row[0]).ToLower().Contains(vo.NomeTratado.ToLower()))
                                {
                                    localizado = true; break;
                                }
                            }

                            if (!localizado)
                            {
                                MediaVo _vo = new MediaVo();
                                _vo.NomeCompleto = vo.NomeCompleto;
                                _vo.NomeTratado = vo.NomeTratado;
                                listaNaoUsado18.Add(_vo);
                            }
                        }
                    }
                    catch
                    {
                        listaNaoUsado18.AddRange(listaNaoUsado17);
                    }

                    #endregion

                    #region verifica modulo noticia - campo imagem

                    try
                    {

                        this.exibeStatus("Verificando módulo notícia...");

                        adp = new MySqlDataAdapter("select noticia_imagem from modulo_noticia WHERE noticia_imagem is not null and noticia_imagem <> ''", conn);
                        //dt.Rows.Clear();
                        dt = new DataTable();
                        adp.Fill(dt);
                        foreach (var vo in listaNaoUsado18)
                        {
                            this.exibeStatus(string.Concat("Arquivo ", vo.NomeTratado));

                            localizado = false;
                            foreach (DataRow row in dt.Rows)
                            {
                                //verifica se tem
                                if (vo.NomeTratado.ToLower().Contains(Convert.ToString(row[0]).ToLower()))
                                {
                                    localizado = true; break;
                                }
                            }

                            if (!localizado)
                            {
                                MediaVo _vo = new MediaVo();
                                _vo.NomeCompleto = vo.NomeCompleto;
                                _vo.NomeTratado = vo.NomeTratado;
                                listaNaoUsado19.Add(_vo);
                            }
                        }
                    }
                    catch
                    {
                        listaNaoUsado19.AddRange(listaNaoUsado18);
                    }

                    #endregion

                    #region verifica modulo escola_unidade - campos unidade_imagem, unidade_logo, unidade_menu_imagem 

                    try
                    {

                        this.exibeStatus("Verificando módulo escola_unidade...");

                        adp = new MySqlDataAdapter("select unidade_imagem,unidade_logo,unidade_menu_imagem,unidade_fone_imagem from escola_unidade", conn);
                        dt = new DataTable();
                        adp.Fill(dt);
                        foreach (var vo in listaNaoUsado19)
                        {
                            this.exibeStatus(string.Concat("Arquivo ", vo.NomeTratado));

                            localizado = false;
                            foreach (DataRow row in dt.Rows)
                            {
                                //verifica se tem
                                if (vo.NomeTratado.ToLower().Contains(Convert.ToString(row[0]).ToLower()) || 
                                    vo.NomeTratado.ToLower().Contains(Convert.ToString(row[1]).ToLower()) || 
                                    vo.NomeTratado.ToLower().Contains(Convert.ToString(row[2]).ToLower()) ||
                                    vo.NomeTratado.ToLower().Contains(Convert.ToString(row[3]).ToLower()))
                                {
                                    localizado = true; break;
                                }
                            }

                            if (!localizado)
                            {
                                MediaVo _vo = new MediaVo();
                                _vo.NomeCompleto = vo.NomeCompleto;
                                _vo.NomeTratado  = vo.NomeTratado;
                                listaNaoUsado20.Add(_vo);
                            }
                        }
                    }
                    catch
                    {
                        listaNaoUsado20.AddRange(listaNaoUsado19);
                    }

                    #endregion

                } //fecha escopo conexao mysql

                //listaNaoUsado20 = new List<MediaVo>();
                //listaNaoUsado20.AddRange(listaNaoUsado01);

                this.VOs = listaNaoUsado20;

                lstArquivosNaoUsados.Items.Clear();
                foreach (var vo in this.VOs)
                {
                    lstArquivosNaoUsados.Items.Add(vo.NomeCompleto + " - (" + vo.NomeTratado + ")");
                    this.exibeStatus("Sumarizando...");
                }


                this.exibeStatus("Concluído.");

                lblConcluido.Text = "Total a excluir: " + this.VOs.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        void exibeStatus(string msg)
        {
            lblMsg.Text = msg;
            Application.DoEvents();
        }


        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (this.VOs == null || this.VOs.Count == 0) return;

            var res = MessageBox.Show("Deseja realmente excluir os arquivos?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == System.Windows.Forms.DialogResult.No) return;

            foreach (var vo in this.VOs)
            {
                lblConcluido.Text = "Excluindo arquivo " + vo.NomeTratado;
                Application.DoEvents();
                if (File.Exists(vo.NomeCompleto)) 
                { 
                    //File.Delete(vo.NomeCompleto);
                    this.excluirArquivoNoFTP(vo.NomeTratado);
                    lstArquivosNaoUsados.SelectedIndex = lstArquivosNaoUsados.FindStringExact(vo.NomeCompleto + " - (" + vo.NomeTratado + ")");
                }
            }

            lblConcluido.Text = this.VOs.Count.ToString() + " arquivos excluídos";
            MessageBox.Show(this.VOs.Count.ToString() + " arquivos excluídos.", "Exclusão concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void excluirArquivoNoFTP(string arquivo)
        {
            if (string.IsNullOrEmpty(txtFTPUser.Text) || string.IsNullOrEmpty(txtFTPPWD.Text)) return;

            try
            {
                lblConcluido.Text = "Excluindo arquivo (FTP) " + arquivo;
                Application.DoEvents();

                string ftpPath = txtFTP.Text + arquivo;

                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(ftpPath);
                ftpRequest.KeepAlive = false;
                ftpRequest.UsePassive = true;
                ftpRequest.Method = WebRequestMethods.Ftp.DeleteFile;
                ftpRequest.Credentials = new NetworkCredential(txtFTPUser.Text, txtFTPPWD.Text);

                using (FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse())
                {
                    ftpResponse.Close();
                }
            }
            catch
            {
            }
        }

        [Serializable]
        class MediaVo
        {
            public string NomeCompleto { get; set; }
            public string NomeTratado { get; set; }
        }
    }
}
