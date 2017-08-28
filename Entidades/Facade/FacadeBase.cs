namespace Entidades.Facade
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Collections;
    using System.Configuration;
    using System.Collections.Generic;

    using NHibernate;
    using NHibernate.Linq;
    using NHibernate.Dialect;
    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;
    using FluentNHibernate.Conventions.Helpers;

    using Entidades;
    using Entidades.Map;

    public class FacadeBase
    {
        private static NHibernate.Cfg.Configuration _config = null;
        private static Hashtable _allFactories = new Hashtable();

        protected static ISession ObterSessao()
        {
            string chave = "1";
            ISessionFactory _sessionFactory = null;

            if (!_allFactories.ContainsKey(chave))
            {
                _sessionFactory = CriarSessaoNHibernate();
                _allFactories.Add(chave, _sessionFactory);
            }
            else
            {
                _sessionFactory = (ISessionFactory)_allFactories[chave];
            }

            ISession sessao = _sessionFactory.OpenSession();
            sessao.FlushMode = FlushMode.Commit;

            return sessao;
        }

        static ISessionFactory CriarSessaoNHibernate()
        {
            var se = Fluently.Configure().Database(
                FluentNHibernate.Cfg.Db.MySQLConfiguration.Standard.ConnectionString(//"server=186.233.89.23;database=smartcms_casadev;user=smartcms_casa;pwd=1q1a1z2w2s2x3e3d3c4r4f4v"
                    c => c.FromConnectionStringWithKey("ConnectionString")
                )
            )
            .Mappings(m => m.FluentMappings.AddFromAssemblyOf<CheckListItem>())
            .BuildSessionFactory();

            return se;
        }

        protected DateTime CToDateTime(String param6pos, Int32 hora, Int32 minunto, Int32 segundo, Boolean ddMMyy)
        {
            Int32 dia;
            Int32 mes;
            Int32 ano;

            if (ddMMyy)
            {
                dia = Convert.ToInt32(param6pos.Substring(0, 2));
                mes = Convert.ToInt32(param6pos.Substring(2, 2));
                ano = Convert.ToInt32(param6pos.Substring(4, 2));
            }
            else
            {
                ano = Convert.ToInt32(param6pos.Substring(0, 2));
                mes = Convert.ToInt32(param6pos.Substring(2, 2));
                dia = Convert.ToInt32(param6pos.Substring(4, 2));
            }

            if (ano >= 0 && ano <= 95)
                ano = Convert.ToInt32("20" + ano.ToString());
            else
                ano = Convert.ToInt32("19" + ano.ToString());

            DateTime data = new DateTime(ano, mes, dia, hora, minunto, segundo);
            return data;
        }

        protected string GetMD5Hash(string input)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {

                sb.Append(hash[i].ToString("X2"));

            }

            return sb.ToString();
        }

        public static string GetMD5Hash_static(string input)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {

                sb.Append(hash[i].ToString("X2"));

            }

            return sb.ToString();
        }
    }
}
