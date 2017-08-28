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

    public class CampanhaFacade : FacadeBase
    {
        #region Singleton 

        static CampanhaFacade _instance;
        public static CampanhaFacade Instance
        {
            get
            {
                if (_instance == null) { _instance = new CampanhaFacade(); }
                return _instance;
            }
        }
        #endregion

        public void Salvar(Campanha obj)
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

        public Campanha Carregar(long id)
        {
            using (var sessao = ObterSessao())
            {
                var l = sessao.Query<Campanha>()
                    .Where(c => c.ID == id)
                    .Single();

                return l;
            }
        }

        public List<Campanha> Carregar()
        {
            using (var sessao = ObterSessao())
            {
                var l = sessao.Query<Campanha>()
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
                        Campanha obj = sessao.Get<Campanha>(id);
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
    }
}
