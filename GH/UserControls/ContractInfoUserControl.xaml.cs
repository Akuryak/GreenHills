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
    /// Логика взаимодействия для ContractInfoUserControl.xaml
    /// </summary>
    public partial class ContractInfoUserControl : UserControl
    {
        public ContractInfoUserControl(Contract contract)
        {
            InitializeComponent();

            ContractTypeTextBlock.Text = contract.StringTypeObject;
            BuyerFullNameTextBlock.Text = "Покупатель: " + Environment.NewLine + contract.BuyerFullName;
            StaffFullNameTextBlock.Text = "Продавец: " + Environment.NewLine + contract.StaffFullName;
            AddressAndTypeTextBlock.Text = $"{contract.IdObjectContractNavigation.TypeObjectNavigation.NameTypeObject} {contract.ObjectAddress}";
            StartDateTextBlock.Text = "Дата заключения: " + Environment.NewLine + contract.DateConclusionContract.ToString("yyyy-MM-dd");
            EndDateTextBlock.Text = "Действителен до: " + Environment.NewLine + contract.ValidUntilContract.ToString("yyyy-MM-dd");
        }
    }
}
