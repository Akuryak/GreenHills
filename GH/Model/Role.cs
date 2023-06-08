using System;
using System.Collections.Generic;

#nullable disable

namespace GH.Model
{
    public partial class Role
    {
        public Role()
        {
            Clients = new HashSet<Client>();
            staff = new HashSet<staff>();
        }

        public int IdRole { get; set; }
        public string NameRole { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<staff> staff { get; set; }
    }
}
