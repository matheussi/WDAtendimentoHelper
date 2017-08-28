namespace Entidades
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;

    public class Campanha
    {
        public enum eSexo : int
        {
            Masculino,
            Feminino
        }

        public Campanha()
        {
            Data = DateTime.Now;
            Sexo = eSexo.Masculino;
        }

        public virtual long ID            { get; set; }

        public virtual string DonoNome    { get; set; }
        public virtual string DonoMail    { get; set; }

        public virtual string ClienteNome { get; set; }
        public virtual string ClienteMail { get; set; }
        public virtual eSexo Sexo         { get; set; }

        public virtual long ClienteId     { get; set; }
        public virtual long ProjetoId     { get; set; }
        public virtual string Cliente     { get; set; }
        public virtual string Projeto     { get; set; }

        public virtual DateTime Data      { get; set; }
        public virtual DateTime? Inicio   { get; set; }
    }

    public class CampanhaCheckList
    {
        public CampanhaCheckList()
        {
            CheckListOK = false;
        }

        public virtual long ID { get; set; }
        public virtual long CampanhaID { get; set; }
        public virtual long CheckListID { get; set; }
        public virtual string CheckListTexto { get; set; }
        public virtual bool CheckListOK { get; set; }
    }
}