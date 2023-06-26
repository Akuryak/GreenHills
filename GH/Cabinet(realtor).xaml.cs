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
    /// Логика взаимодействия для Cabinet_realtor_.xaml
    /// </summary>
    public partial class Cabinet_realtor_ : Page
    {
        public static staff Staff { get; set; }
        public Cabinet_realtor_(staff staff)
        {
            InitializeComponent();
            Staff = staff;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            nameuser.Content = Staff.FullName;

            ClientsCountTextBlock.Text = (App.Context.Contracts.ToList().Where(x => x.IdStaffContract == Staff.IdStaff).Count() * 2).ToString();
            ObjectsCountTextBlock.Text = App.Context.Contracts.ToList().Where(x => x.IdStaffContract == Staff.IdStaff).Count().ToString();
            DocumentsCountTextBlock.Text = App.Context.Contracts.ToList().Where(x => x.IdStaffContract == Staff.IdStaff).Count().ToString();
        }
    }
}
