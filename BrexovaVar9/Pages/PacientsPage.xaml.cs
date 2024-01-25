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

namespace BrexovaVar9.Pages
{
    /// <summary>
    /// Логика взаимодействия для PacientsPage.xaml
    /// </summary>
    public partial class PacientsPage : Page
    {
        public PacientsPage()
        {
            InitializeComponent();
            DGPacient.ItemsSource = ClinicadbEntities.GetContext().Pacient.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new JurnalPage());
        }

        private void txbPoisk_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }
        private void Filter()
        {
            var list = ClinicadbEntities.GetContext().Pacient.ToList();
            list = list.Where(x =>
                x.Familia.ToLower().Contains(txbPoisk.Text.ToLower())).ToList();            
            DGPacient.ItemsSource = list;
        }
    }
}
