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
    using System.Data.Common;

    public class ClienteDTO
    {
        public long ClienteID { get; set; }
        public string Cliente { get; set; }
        public long ProjetoID { get; set; }
        public string Projeto { get; set; }
    }

    public class ClienteFacade : FacadeBase
    {
        #region Singleton 

        static ClienteFacade _instance;
        public static ClienteFacade Instance
        {
            get
            {
                if (_instance == null) { _instance = new ClienteFacade(); }
                return _instance;
            }
        }
        #endregion

        public ClienteDTO Carregar(Int64 cliId, Int64 projId)
        {
             using (var sessao = ObterSessao())
            {
                var cmd = sessao.Connection.CreateCommand();

                cmd.CommandText = string.Concat("select c.client_id,c.client_fantasy,p.projectId,p.projectName",
                    " from casa_lc_client c inner join casa_lc_client_project p on p.clientId = c.client_id ",
                    " where c.client_id =", cliId, " and p.projectName = ", projId,
                    " order by c.client_fantasy, p.projectName");

                ClienteDTO dto = null;

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dto = new ClienteDTO();

                        dto.ClienteID   = Convert.ToInt64(reader["client_id"]);
                        dto.Cliente     = Convert.ToString(reader["client_fantasy"]);
                        dto.ProjetoID   = Convert.ToInt64(reader["projectId"]);
                        dto.Projeto     = Convert.ToString(reader["projectName"]);
                    }
                }

                cmd.Dispose();
                return dto;
            }
        }

        public List<ClienteDTO> CarregarPor(string nome)
        {
            using (var sessao = ObterSessao())
            {
                var cmd = sessao.Connection.CreateCommand();

                cmd.CommandText = string.Concat("select c.client_id,c.client_fantasy,p.projectId,p.projectName",
                    " from casa_lc_client c inner join casa_lc_client_project p on p.clientId = c.client_id ",
                    " where c.client_fantasy like '%", nome, "%' or p.projectName like '%", nome, "%' ",
                    " order by c.client_fantasy, p.projectName");

                List<ClienteDTO> clientes = new List<ClienteDTO>();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ClienteDTO dto = new ClienteDTO();

                        dto.ClienteID   = Convert.ToInt64(reader["client_id"]);
                        dto.Cliente     = Convert.ToString(reader["client_fantasy"]);
                        dto.ProjetoID   = Convert.ToInt64(reader["projectId"]);
                        dto.Projeto     = Convert.ToString(reader["projectName"]);

                        clientes.Add(dto);
                    }
                }

                cmd.Dispose();
                return clientes;
            }
        }
    }
}