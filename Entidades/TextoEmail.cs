using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Entidades
{
    public class TextoEmail
    {
        public virtual long ID { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Texto { get; set; }
    }
}
