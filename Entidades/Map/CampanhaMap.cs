namespace Entidades.Map
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;

    using FluentNHibernate.Mapping;

    public class CampanhaMap : ClassMap<Campanha>
    {
        public CampanhaMap()
        {
            base.Table("at_campanha");

            base.Id(i => i.ID).Column("camp_id").GeneratedBy.Identity();
            base.Map(i => i.DonoNome).Column("camp_donoNome");
            base.Map(i => i.DonoMail).Column("camp_donoMail");
            base.Map(i => i.ClienteMail).Column("camp_clienteMail");
            base.Map(i => i.ClienteId).Column("camp_clienteId");
            base.Map(i => i.ProjetoId).Column("camp_projetoId");
            base.Map(i => i.Cliente).Column("camp_cliente");
            base.Map(i => i.Projeto).Column("camp_projeto");
            base.Map(i => i.Data).Column("camp_data");
            base.Map(i => i.Inicio).Column("camp_inicio");

            base.Map(i => i.Sexo).Column("camp_clienteSexo").CustomType<int>();
            base.Map(i => i.ClienteNome).Column("camp_clienteNome");
        }
    }

    public class CampanhaCheckListMap : ClassMap<CampanhaCheckList>
    {
        public CampanhaCheckListMap()
        {
            base.Table("at_campanha_chklist");

            base.Id(i => i.ID).Column("campchk_id").GeneratedBy.Identity();
            base.Map(i => i.CampanhaID).Column("campchk_campId");
            base.Map(i => i.CheckListID).Column("campchk_chkId");
            base.Map(i => i.CheckListTexto).Column("campchk_chkTexto");
            base.Map(i => i.CheckListOK).Column("campchk_chkOK");
        }
    }
}
