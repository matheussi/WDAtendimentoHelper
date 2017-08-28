using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

using FluentNHibernate.Mapping;

namespace Entidades.Map
{
    class CheckListItemMap : ClassMap<CheckListItem>
    {
        public CheckListItemMap()
        {
            base.Table("at_checklistitem");

            base.Id(i => i.ID).Column("at_id").GeneratedBy.Identity();
            base.Map(i => i.Texto).Column("at_texto");
        }
    }
}
