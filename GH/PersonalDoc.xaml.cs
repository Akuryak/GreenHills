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
    /// Логика взаимодействия для PersonalDoc.xaml
    /// </summary>
    public partial class PersonalDoc : Page
    {
        public static Client Client { get; set; }
        public PersonalDoc(Client client)
        {
            InitializeComponent();
            Client = client;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UsernameLable.Content = $"{Client.SurnameClient} {Client.NameClient}";

            CountDocumentsTextBlock.Text = App.Context.Contracts.ToList().Where(x => x.IdByerContract == Client.IdClient || x.IdStaffContract == Client.IdClient).Count().ToString();

            if (App.Context.Contracts.ToList().Where(x => x.IdByerContract == Client.IdClient || x.IdStaffContract == Client.IdClient).Count() <= 0)
            {
                ContactsClientListBox.Items.Add(new ListBoxItem() { Content = "У вас нет оформленных договоров" });
                return;
            }

            foreach (Contract contract in App.Context.Contracts.ToList().Where(x => x.IdByerContract == Client.IdClient || x.IdStaffContract == Client.IdClient))
            {
                ContactsClientListBox.Items.Add(new UserControls.DocumentInfoUserControl(Client, null, contract));
            }
        }
    }
}
