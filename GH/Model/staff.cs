using System;
using System.Collections.Generic;

#nullable disable

namespace GH.Model
{
    public partial class staff
    {
        public staff()
        {
            Contracts = new HashSet<Contract>();
        }

        public int IdStaff { get; set; }
        public string SurnameStaff { get; set; }
        public string NameStaff { get; set; }
        public string PatronymicStaff { get; set; }
        public decimal PhoneStaff { get; set; }
        public string PasswordStaf { get; set; }
        public string RequisitesStaff { get; set; }
        public string EmailStaff { get; set; }
        public int RoleStaff { get; set; }

        public virtual Role RoleStaffNavigation { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
