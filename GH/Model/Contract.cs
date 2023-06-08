using System;
using System.Collections.Generic;

#nullable disable

namespace GH.Model
{
    public partial class Contract
    {
        public int IdContract { get; set; }
        public int IdByerContract { get; set; }
        public int IdObjectContract { get; set; }
        public int IdStaffContract { get; set; }
        public DateTime DateConclusionContract { get; set; }
        public DateTime ValidUntilContract { get; set; }
        public int TypeContract { get; set; }

        public virtual Client IdByerContractNavigation { get; set; }
        public virtual Object IdObjectContractNavigation { get; set; }
        public virtual staff IdStaffContractNavigation { get; set; }
        public virtual Typecontract TypeContractNavigation { get; set; }
    }
}
