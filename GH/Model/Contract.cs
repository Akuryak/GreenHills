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

        public Contract()
        {
        }

        public Contract(int idContract, int idByerContract, int idObjectContract, int idStaffContract, DateTime dateConclusionContract, DateTime validUntilContract, int typeContract, Client idByerContractNavigation, Object idObjectContractNavigation, staff idStaffContractNavigation, Typecontract typeContractNavigation)
        {
            IdContract = idContract;
            IdByerContract = idByerContract;
            IdObjectContract = idObjectContract;
            IdStaffContract = idStaffContract;
            DateConclusionContract = dateConclusionContract;
            ValidUntilContract = validUntilContract;
            TypeContract = typeContract;
            IdByerContractNavigation = idByerContractNavigation;
            IdObjectContractNavigation = idObjectContractNavigation;
            IdStaffContractNavigation = idStaffContractNavigation;
            TypeContractNavigation = typeContractNavigation;
        }
    }
}
