using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GH.Model
{
    public partial class staff
    {
        public double Rating { get { return App.Context.Contracts.ToList().Where(x => x.IdStaffContract == IdStaff).Count() == 3 ? 5.0 : App.Context.Contracts.ToList().Where(x => x.IdStaffContract == IdStaff).Count() == 2 ? 4.0 : App.Context.Contracts.ToList().Where(x => x.IdStaffContract == IdStaff).Count() == 1 ? 3.0 : 1.5 ; } }

        public string FullName { get { return $"{SurnameStaff} {NameStaff} {PatronymicStaff}"; } }

        public staff(int idStaff, string surnameStaff, string nameStaff, string patronymicStaff, decimal phoneStaff, string passwordStaf, string requisitesStaff, string emailStaff, int roleStaff, Role roleStaffNavigation, ICollection<Contract> contracts)
        {
            IdStaff = idStaff;
            SurnameStaff = surnameStaff;
            NameStaff = nameStaff;
            PatronymicStaff = patronymicStaff;
            PhoneStaff = phoneStaff;
            PasswordStaf = passwordStaf;
            RequisitesStaff = requisitesStaff;
            EmailStaff = emailStaff;
            RoleStaff = roleStaff;
            RoleStaffNavigation = roleStaffNavigation;
            Contracts = contracts;
        }
    }
}
