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
    /// Логика взаимодействия для ClientInfoUserControl.xaml
    /// </summary>
    public partial class ClientInfoUserControl : UserControl
    {
        public ClientInfoUserControl(Client client)
        {
            InitializeComponent();

            FullNameTextBlock.Text = $"{client.SurnameClient} {client.NameClient} {client.PatronymicClient}";
            PhoneNumberTextBlock.Text = client.PhoneClient;
            EmailTextBlock.Text = client.EmailClient;
        }
    }
}
