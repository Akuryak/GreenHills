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
    /// Логика взаимодействия для RealtorsInfoUserControl.xaml
    /// </summary>
    public partial class RealtorsInfoUserControl : UserControl
    {
        public RealtorsInfoUserControl(staff staff)
        {
            InitializeComponent();

            FullNameTextBlock.Text = $"{staff.SurnameStaff} {staff.NameStaff} {staff.PatronymicStaff}";
            PhoneNumberTextBlock.Text = staff.PhoneStaff.ToString();
            EmailTextBlock.Text = staff.EmailStaff.ToString();
            RatingTextBlock.Text = $"{staff.Rating} звезд";
        }
    }
}
