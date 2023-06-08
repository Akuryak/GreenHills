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
    }
}
