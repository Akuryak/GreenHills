using System;
using System.Collections.Generic;

#nullable disable

namespace GH.Model
{
    public partial class Client
    {
        public Client()
        {
            Contracts = new HashSet<Contract>();
            Objects = new HashSet<Object>();
        }

        public int IdClient { get; set; }
        public string SurnameClient { get; set; }
        public string NameClient { get; set; }
        public string PatronymicClient { get; set; }
        public string PhoneClient { get; set; }
        public string PasswordClient { get; set; }
        public string RequisitesClient { get; set; }
        public string EmailClient { get; set; }
        public int Role { get; set; }

        public virtual Role RoleNavigation { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<Object> Objects { get; set; }



        public Client(int idClient, string surnameClient, string nameClient, string patronymicClient, string phoneClient, string passwordClient, string requisitesClient, string emailClient, int role, Role roleNavigation, ICollection<Contract> contracts, ICollection<Object> objects)
        {
            IdClient = idClient;
            SurnameClient = surnameClient;
            NameClient = nameClient;
            PatronymicClient = patronymicClient;
            PhoneClient = phoneClient;
            PasswordClient = passwordClient;
            RequisitesClient = requisitesClient;
            EmailClient = emailClient;
            Role = role;
            RoleNavigation = roleNavigation;
            Contracts = contracts;
            Objects = objects;
        }
    }
}
