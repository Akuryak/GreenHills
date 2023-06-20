using GH.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GH
{
    /// <summary>
    /// Логика взаимодействия для SaleDocument.xaml
    /// </summary>
    public partial class SaleDocument : Page
    {
        public static staff Staff { get; set; }
        public static Client Client { get; set; }
        public static Contract Contract { get; set; }
        public SaleDocument(staff staff, Client client, Contract contract)
        {
            InitializeComponent();
            Staff = staff;
            Client = client;
            Contract = contract;
        }

        private void ready_button_Click(object sender, RoutedEventArgs e)
        {
            if (Staff != null)
                PageManagerClass.MainFrame.Navigate(new Realtor_cabinet_(Staff));
            else if (Client != null)
                PageManagerClass.MainFrame.Navigate(new Client_cabinet_(Staff, Client));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (Staff != null)
                nameuser.Content = Staff.FullName;
            else if (Client != null)
                nameuser.Content = $"{Client.SurnameClient} {Client.NameClient} {Client.PatronymicClient}";

            number_label.Content = Contract.IdContract;
            city_label.Content = Contract.IdObjectContractNavigation.CityObject;
            data_label.Content = Contract.DateConclusionContract;
            nameAndSurnameClient_label.Content = $"{Contract.IdByerContractNavigation.SurnameClient} {Contract.IdByerContractNavigation.NameClient}";
            requisitesClient_label.Content = Contract.IdByerContractNavigation.RequisitesClient;
            typeObject_label.Content = Contract.IdObjectContractNavigation.TypeObjectNavigation.NameTypeObject;
            addressObject_label.Content = $"г. {Contract.IdObjectContractNavigation.CityObject} ул. {Contract.IdObjectContractNavigation.AddressObject}";
            costObject.Content = Contract.IdObjectContractNavigation.PriceObject;
            validUntil_label.Content = Contract.ValidUntilContract;
            RealtorName_label.Content = Contract.StaffFullName;
            BuyerName_label.Content = Contract.BuyerFullName;
        }
    }
}
