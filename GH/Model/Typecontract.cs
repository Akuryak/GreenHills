using System;
using System.Collections.Generic;

#nullable disable

namespace GH.Model
{
    public partial class Typecontract
    {
        public Typecontract()
        {
            Contracts = new HashSet<Contract>();
        }

        public int IdTypeContract { get; set; }
        public string NameTypeContract { get; set; }

        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
