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
    /// Логика взаимодействия для JurnalPage.xaml
    /// </summary>
    public partial class JurnalPage : Page
    {
        public JurnalPage()
        {
            InitializeComponent();
            DGJurnal.ItemsSource = ClinicadbEntities.GetContext().Jurnal_lecheniya.ToList();

            cmbSort.ItemsSource = ClinicadbEntities.GetContext().Sostoyanie.ToList();
        }

        private void BtnPacient_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PacientsPage());
        }
        
        private void cmbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            cmbSort.SelectedItem = null;
            txbPoisk.Text = String.Empty;
            DGJurnal.ItemsSource = ClinicadbEntities.GetContext().Jurnal_lecheniya.ToList();
        }

        private void txbPoisk_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            Filter();
        }
        
        private void Filter()
        {            
            var list = ClinicadbEntities.GetContext().Jurnal_lecheniya.ToList();
            list = list.Where(x =>
                x.Pacient.Familia.ToLower().Contains(txbPoisk.Text.ToLower())).ToList();
            if (cmbSort.SelectedItem != null)
            {
                int sortir = Convert.ToInt32(cmbSort.SelectedValue);               
                list = list.Where(x => x.id_Sostoyanie == sortir).ToList();
            }
            DGJurnal.ItemsSource = list;
        }
    }
}
