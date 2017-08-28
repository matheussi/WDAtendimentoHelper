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

    public class TextoEmailFacade : FacadeBase
    {
        #region Singleton

        static TextoEmailFacade _instance;
        public static TextoEmailFacade Instance
        {
            get
            {
                if (_instance == null) { _instance = new TextoEmailFacade(); }
                return _instance;
            }
        }
        #endregion

        public void Salvar(TextoEmail obj)
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

        public TextoEmail Carregar(long id)
        {
            using (var sessao = ObterSessao())
            {
                var l = sessao.Query<TextoEmail>()
                    .Where(c => c.ID == id)
                    .Single();

                return l;
            }
        }

        public IList<TextoEmail> Carregar()
        {
            using (var sessao = ObterSessao())
            {
                var l = sessao.Query<TextoEmail>()
                    .OrderBy(c => c.Nome)
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
                        TextoEmail obj = sessao.Get<TextoEmail>(id);
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
