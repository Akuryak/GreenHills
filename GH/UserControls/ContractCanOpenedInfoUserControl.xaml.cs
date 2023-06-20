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

namespace GH.UserControls
{
    /// <summary>
    /// Логика взаимодействия для DocumentInfoUserControl.xaml
    /// </summary>
    public partial class DocumentInfoUserControl : UserControl
    {
        public static Client Client { get; set; }
        public static staff Staff { get; set; }
        public static Contract Contract { get; set; }
        public DocumentInfoUserControl(Client client, staff staff, Contract contract)
        {
            InitializeComponent();
            Client = client;
            Staff = staff;
            Contract = contract;

            ContractTypeTextBlock.Text = contract.StringTypeObject;
            BuyerFullNameTextBlock.Text = "Покупатель: " + Environment.NewLine + contract.BuyerFullName;
            StaffFullNameTextBlock.Text = "Продавец: " + Environment.NewLine + contract.StaffFullName;
            AddressAndTypeTextBlock.Text = $"{contract.IdObjectContractNavigation.TypeObjectNavigation.NameTypeObject} {contract.ObjectAddress}";
            StartDateTextBlock.Text = "Дата заключения: " + Environment.NewLine + contract.DateConclusionContract.ToString("yyyy-MM-dd");
            EndDateTextBlock.Text = "Действителен до: " + Environment.NewLine + contract.ValidUntilContract.ToString("yyyy-MM-dd");
        }

        private void OpenContractButton_Click(object sender, RoutedEventArgs e)
        {
            if (Contract.TypeContract == 1)
            {
                PageManagerClass.MainFrame.Navigate(new BuyDocument(Staff, Client, Contract));
            }
            else if (Contract.TypeContract == 2)
            {
                PageManagerClass.MainFrame.Navigate(new SaleDocument(Staff, Client, Contract));
            }
        }
    }
}
