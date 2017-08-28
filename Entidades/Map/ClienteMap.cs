using System;
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

using FluentNHibernate.Mapping;

namespace Entidades.Map
{
    public class ClienteMap : ClassMap<Cliente>
    {
        public ClienteMap()
        {
            base.Table("casa_lc_client");

            base.Id(i => i.ID).Column("client_id").GeneratedBy.Identity();
            base.Map(i => i.Nome).Column("client_fantasy");
        }
    }
}
