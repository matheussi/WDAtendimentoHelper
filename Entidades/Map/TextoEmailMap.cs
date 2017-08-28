using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

using FluentNHibernate.Mapping;

namespace Entidades.Map
{
    class TextoEmailMap : ClassMap<TextoEmail>
    {
        public TextoEmailMap()
        {
            base.Table("at_textoemail");

            base.Id(i => i.ID).Column("textoemail_id").GeneratedBy.Identity();
            base.Map(i => i.Nome).Column("textoemail_nome");
            base.Map(i => i.Texto).Column("textoemail_texto");
        }
    }
}
