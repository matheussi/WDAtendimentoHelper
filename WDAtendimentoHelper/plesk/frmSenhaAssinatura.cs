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

namespace WDAtendimentoHelper.plesk
{
    public partial class frmSenhaAssinatura : Form
    {
        public string Hostname = "lccloud.com.br";
        public string Login = "fabioadm";
        public string Password = "lcsenha";

        long _id = 0;
        public frmSenhaAssinatura(MDIParent1 mdi, long? id)
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


        private static bool RemoteCertificateValidation(object sender,
              X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            if (sslPolicyErrors != SslPolicyErrors.RemoteCertificateNotAvailable)
                return true;

            //Console.WriteLine("Certificate error: {0}", sslPolicyErrors);
            MessageBox.Show(string.Format("Certificate error: {0}", sslPolicyErrors), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Do not allow this client to communicate with unauthenticated servers.
            return false;
        }

        private static void XmlSchemaValidation(object sender, ValidationEventArgs e)
        {
            Console.WriteLine("Validation error: {0}", e.Message);
        }

        static string PrintResult(XmlDocument document)
        {
            //XmlTextWriter writer = new XmlTextWriter(Console.Out);
            //writer.Formatting = Formatting.Indented;

            //document.WriteTo(writer);

            //writer.Flush();
            //Console.WriteLine();

            return document.InnerXml;
        }

        private void cmdTeste_Click(object sender, EventArgs e)
        {
            ServicePointManager.ServerCertificateValidationCallback = 
                new RemoteCertificateValidationCallback(RemoteCertificateValidation);

            Request request     = new Request();
            request.Hostname    = Hostname; // "https://lccloud.com.br:8443/";
            request.Login       = Login;
            request.Password    = Password;
            string packet       = request.packet_database_gerinfo("sacchelli.com.br"); //@"C:\Users\ACER E1 572 6830\Documents\request2.xml";

            try
            {
                XmlDocument result = request.Send(packet);
                string ret         = PrintResult(result);
                txtTexto.Text      = ret;

                txtNome.Text = request.GetDataBaseGerInfo_ID("sacchelli.com.br");

                txtTexto.Text = request.GetDomain_GerInfo("sacchelli.com.br"); //request.GetDomain_List();

                txtTexto.Text = request.GetFTP_GerInfo("gruposenun.com.br");

                //txtTexto.Text = request.GetFTP_GerInfo("sacchelli.com.br");

                txtTexto.Text = request.GetSite_GerInfo("sacchelli.com.br");
            }
            catch (Exception err)
            {
                MessageBox.Show(string.Format("Request error: {0}", err.Message),"Erro", MessageBoxButtons.OK,  MessageBoxIcon.Error);
            }
        }
    }

    public class Request
    {
        public string Hostname = "lccloud.com.br";
        public string Login = "fabioadm";
        public string Password = "lcsenha";

        #region banco de dados 

        public string GetDataBaseGerInfo_ID(string dominio)
        {
            XmlDocument doc = this.Send(this.packet_database_gerinfo(dominio));

            return doc.DocumentElement.SelectSingleNode("database/get-db/result/id").InnerText;
            //return this.getResult(doc);
        }

        public string packet_database_gerinfo(string dominio)
        {
            return string.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" ?><packet><database><get-db><filter><webspace-name>",
                dominio, "</webspace-name></filter></get-db></database></packet>");
        }

        #endregion

        #region dominios 

        public string GetDomain_List()
        {
            XmlDocument doc = this.Send(this.packet_domain_list());

            return doc.InnerXml;
        }

        string packet_domain_list()
        {
            return string.Concat(
                "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>",
                "<packet><webspace><get><filter/><dataset><gen_info></gen_info></dataset></get></webspace></packet>");
        }

        public string GetDomain_GerInfo(string dominio)
        {
            XmlDocument doc = this.Send(this.packet_domain_gerinfo(dominio));

            return doc.InnerXml;
        }

        string packet_domain_gerinfo(string dominio)
        {
            return string.Concat(
                "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>",
                "<packet><webspace><get><filter><name>", dominio, "</name></filter><dataset><gen_info></gen_info></dataset></get></webspace></packet>");
        }

        #endregion

        #region ftps 

        //traz o ftp adicional
        public string GetFTP_GerInfo(string dominio)
        {
            XmlDocument doc = this.Send(this.packet_ftp_gerinfo(dominio));

            string id = doc.DocumentElement.SelectSingleNode("ftp-user/get/result/id").InnerText;

            doc = this.Send(packet_ftp_id(id, dominio));

            return doc.InnerXml;
        }

        string packet_ftp_gerinfo(string dominio)
        {
            return string.Concat(
                "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>", //domain-name
                "<packet><ftp-user><get><filter><webspace-name>", dominio, "</webspace-name></filter></get></ftp-user></packet>");
        }

        string packet_ftp_id(string id, string dominio)
        {
            return string.Concat(
                "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>",
                "<packet><ftp-user><get><filter><id>", id, "</id></filter></get></ftp-user></packet>");

            //return string.Concat(
            //    "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>",
            //    "<packet><ftp-user><get><filter><id>", id, "</id></filter></get></ftp-user></packet>");
        }

        //Atualiza um ftp
        //string atualizaFTPPacket = "<packet><ftp-user><set><filter><name>teste</name></filter><values><password>12@den!isZ</password></values></set></ftp-user></packet>";
        //doc = this.Send(atualizaFTPPacket);
        //var doc2 = this.Send(packet_ftp_id("56", ""));

        #endregion

        #region site  

        //traz o ftp original
        public string GetSite_GerInfo(string dominio)
        {
            XmlDocument doc = this.Send(this.packet_site_gerinfo(dominio));

            //atualiza o ftp default
            string packet = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?><packet><site><set><filter><name>sacchelli.com.br</name></filter><values><hosting><vrt_hst><property><name>ftp_password</name><value>vKi99u$9</value></property></vrt_hst></hosting></values></set></site></packet>";
            var doc2 = this.Send(packet);

            return doc2.InnerXml;
        }

        string packet_site_gerinfo(string dominio)
        {
            return string.Concat(
                "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>", //<hosting/>  <gen_info/>
                "<packet><site><get><filter><name>", dominio, "</name></filter><dataset><gen_info/><hosting/></dataset></get></site></packet>");

            //return string.Concat(
            //    "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>", //<hosting/> 
            //    "<packet><site><get><filter/><dataset><gen_info/></dataset></get></site></packet>");

            //return string.Concat(
            //    "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>", //domain-name
            //    "<packet><site-alias><get><filter/></get></site-alias></packet>");
        }

        string packet_costumer_id(string id, string dominio)
        {
            return string.Concat(
                "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>",
                "<packet><ftp-user><get><filter></filter></get></ftp-user></packet>");

            //return string.Concat(
            //    "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>",
            //    "<packet><ftp-user><get><filter><id>", id, "</id></filter></get></ftp-user></packet>");
        }

        #endregion

        public string AgentEntryPoint { get { return "https://" + Hostname + ":8443/enterprise/control/agent.php"; } }

        public Request()
        {
        }

        public XmlDocument SendPack(XmlDocument packet)
        {
            HttpWebRequest request = SendRequest(packet.OuterXml);
            XmlDocument result = GetResponse(request);
            return result;
        }

        public XmlDocument Send(string packet)
        {
            return this.SendPack(this.Parse(packet));
        }

        private HttpWebRequest SendRequest(string message)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(AgentEntryPoint);

            request.Method = "POST";
            request.Headers.Add("HTTP_AUTH_LOGIN", Login);
            request.Headers.Add("HTTP_AUTH_PASSWD", Password);
            request.ContentType = "text/xml";
            request.ContentLength = message.Length;

            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] buffer = encoding.GetBytes(message);

            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(buffer, 0, message.Length);
            }

            return request;
        }

        private XmlDocument Parse(string xmlContent)
        {
            XmlDocument document = new XmlDocument();

            document.LoadXml(xmlContent);

            return document;
        }

        private XmlDocument Parse(TextReader xml)
        {
            XmlDocument document = new XmlDocument();

            using (XmlReader reader = XmlTextReader.Create(xml))
            {
                document.Load(reader);
            }

            return document;
        }

        private XmlDocument GetResponse(HttpWebRequest request)
        {
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (TextReader reader = new StreamReader(stream))
            {
                return Parse(reader);
            }
        }


        string getResult(XmlDocument document)
        {
            //XmlTextWriter writer = new XmlTextWriter(Console.Out);
            //writer.Formatting = Formatting.Indented;

            //document.WriteTo(writer);

            //writer.Flush();
            //Console.WriteLine();

            return document.InnerXml;
        }
    }
}

//http://docs.plesk.com/en-US/17.0/api-rpc/reference/managing-databases/retrieving-default-database-user-info.34464/#o34465
//https://github.com/plesk/api-examples/blob/master/c-sharp/program.cs
//http://docs.plesk.com/en-US/17.0/api-rpc/reference/managing-databases/changing-credentials-access-rules-and-user-roles.34709/#o34711
//http://download1.parallels.com/Plesk/PP11/11.0/Doc/en-US/online/plesk-api-rpc/index.htm?fileName=35233.htm ///FTP

//http://www.ugurethemaydin.com/asp/plesk-api-parallels-plesk-net-c.html
//http://download1.parallels.com/Plesk/Plesk8.2/Doc/plesk-8.2-api-rpc-guide/33182.htm
