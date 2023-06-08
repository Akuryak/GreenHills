using System;
using System.Collections.Generic;

#nullable disable

namespace GH.Model
{
    public partial class Typeobject
    {
        public Typeobject()
        {
            Objects = new HashSet<Object>();
        }

        public int IdTypeObject { get; set; }
        public string NameTypeObject { get; set; }

        public virtual ICollection<Object> Objects { get; set; }
    }
}
