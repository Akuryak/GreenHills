using System;
using System.Collections.Generic;

#nullable disable

namespace GH.Model
{
    public partial class Object
    {
        public Object()
        {
            Contracts = new HashSet<Contract>();
        }

        public int IdObject { get; set; }
        public int TypeObject { get; set; }
        public decimal PriceObject { get; set; }
        public int? NumRoomsObject { get; set; }
        public string LivingAreaObject { get; set; }
        public string PlotAreaObject { get; set; }
        public int? FloorObject { get; set; }
        public int IdSobObject { get; set; }
        public string CityObject { get; set; }
        public string DistrictObject { get; set; }
        public string AddressObject { get; set; }
        public string ImagesObject { get; set; }

        public virtual Client IdSobObjectNavigation { get; set; }
        public virtual Typeobject TypeObjectNavigation { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }

        public Object(int idObject, int typeObject, decimal priceObject, int? numRoomsObject, string livingAreaObject, string plotAreaObject, int? floorObject, int idSobObject, string cityObject, string districtObject, string addressObject, string imagesObject, Client idSobObjectNavigation, Typeobject typeObjectNavigation, ICollection<Contract> contracts)
        {
            IdObject = idObject;
            TypeObject = typeObject;
            PriceObject = priceObject;
            NumRoomsObject = numRoomsObject;
            LivingAreaObject = livingAreaObject;
            PlotAreaObject = plotAreaObject;
            FloorObject = floorObject;
            IdSobObject = idSobObject;
            CityObject = cityObject;
            DistrictObject = districtObject;
            AddressObject = addressObject;
            ImagesObject = imagesObject;
            IdSobObjectNavigation = idSobObjectNavigation;
            TypeObjectNavigation = typeObjectNavigation;
            Contracts = contracts;
        }
    }
}
