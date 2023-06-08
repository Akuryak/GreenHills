using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GH.Model
{
    public partial class Contract
    {
        public string BuyerFullName { get { return $"{IdByerContractNavigation.SurnameClient} {IdByerContractNavigation.NameClient} {IdByerContractNavigation.PatronymicClient}"; } }

        public string ObjectAddress { get { return $"г. {IdObjectContractNavigation.CityObject} ул. {IdObjectContractNavigation.AddressObject}"; } }

        public string StaffFullName { get { return $"{IdStaffContractNavigation.SurnameStaff} {IdStaffContractNavigation.NameStaff} {IdStaffContractNavigation.PatronymicStaff}"; } }

        public string StringTypeObject { get { return TypeContractNavigation.NameTypeContract; } }
    }
}
