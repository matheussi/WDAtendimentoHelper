namespace Entidades.Facade
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Data;
    using System.Collections.Generic;

    using NHibernate;
    using NHibernate.Linq;

    using Entidades;
    using Entidades.Map;

    public class CheckListFacade : FacadeBase
    {
        #region Singleton 

        static CheckListFacade _instance;
        public static CheckListFacade Instance
        {
            get
            {
                if (_instance == null) { _instance = new CheckListFacade(); }
                return _instance;
            }
        }
        #endregion

        public void Salvar(CheckListItem obj)
        {
            using (var sessao = ObterSessao())
            {
                using (ITransaction tran = sessao.BeginTransaction())
                {
                    try
                    {
                        sessao.SaveOrUpdate(obj);
                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        public CheckListItem Carregar(long id)
        {
            using (var sessao = ObterSessao())
            {
                var l = sessao.Query<CheckListItem>()
                    .Where(c => c.ID == id)
                    .Single();

                return l;
            }
        }

        public IList<CheckListItem> Carregar()
        {
            using (var sessao = ObterSessao())
            {
                var l = sessao.Query<CheckListItem>()
                    .OrderBy(c => c.ID)
                    .ToList();

                return l;
            }
        }

        public void Excluir(long id)
        {
            using (var sessao = ObterSessao())
            {
                using (ITransaction tran = sessao.BeginTransaction())
                {
                    try
                    {
                        CheckListItem obj = sessao.Get<CheckListItem>(id);
                        sessao.Delete(obj);
                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        //public Cliente Carregar(string codigoWeDigi)
        //{
        //    using (var sessao = ObterSessao())
        //    {
        //        var l = sessao.Query<Cliente>()
        //            .Where(c => c.CodigoWeDigi == codigoWeDigi)
        //            .SingleOrDefault();

        //        return l;
        //    }
        //}

        //public Cliente CarregarPorEmail(String email)
        //{
        //    object id = null;

        //    using (var sessao = ObterSessao())
        //    {
        //        if (sessao.Connection.State != ConnectionState.Open) sessao.Connection.Open();

        //        IDbCommand cmd = sessao.Connection.CreateCommand();

        //        cmd.CommandText = "select client_id from casa_lc_client where client_email like '%" + email + "%'";

        //        using (var reader = cmd.ExecuteReader())
        //        {
        //            int i = 0;
        //            while (reader.Read()) i++;

        //            if (i == 1) id = reader[0];

        //            reader.Close();
        //        }

        //        if (id != null)
        //        {
        //            //achou somente um cliente pelo email, tudo ok

        //            Cliente cli = sessao.Get<Cliente>(Convert.ToInt64(id));
        //            return cli;
        //        }
        //        else
        //        {
        //            //não achou, entao tenta pelos contatos 
        //            cmd.CommandText = "select client_id from casa_lc_client_contact where contact_mail like '%" + email + "%'";

        //            List<Int64> lista = new List<Int64>();
        //            using (var reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    if (!lista.Contains(Convert.ToInt32(reader[0]))) lista.Add(Convert.ToInt64(reader[0]));
        //                }

        //                if (lista.Count == 1) id = lista[0];

        //                reader.Close();
        //            }

        //            if (id != null)
        //            {
        //                //achou somente um cliente pelo email, tudo ok

        //                Cliente cli = sessao.Get<Cliente>(id);
        //                return cli;
        //            }
        //        }
        //    }

        //    return null;
        //}
    }
}
