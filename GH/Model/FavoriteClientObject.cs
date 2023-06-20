using System;
using System.Collections.Generic;

#nullable disable

namespace GH.Model
{
    public partial class FavoriteClientObject
    {
        public int Id { get; set; }
        public int Object { get; set; }
        public int Client { get; set; }

        public virtual Client ClientNavigation { get; set; }
        public virtual Object ObjectNavigation { get; set; }

        public FavoriteClientObject()
        {
        }

        public FavoriteClientObject(int id, int @object, int client, Client clientNavigation, Object objectNavigation)
        {
            Id = id;
            Object = @object;
            Client = client;
            ClientNavigation = clientNavigation;
            ObjectNavigation = objectNavigation;
        }
    }
}
