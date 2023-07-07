using SchoolProject.ViewModel;
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

namespace SchoolProject
{
    /// <summary>
    /// Lógica de interacción para Search.xaml
    /// </summary>
    public partial class Search : Page
    {
        public Search()
        {
            InitializeComponent();
            SearchPatientViewModel searchPatientViewModel = new SearchPatientViewModel();
            searchPatientViewModel.initialize();
            DataContext = searchPatientViewModel;
            TxtAutoComplete.Focus();
        }

        private void TxtAutoComplete_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                var viewModel = DataContext as SearchPatientViewModel;
                viewModel.SearchCommand.Execute(null);
            }
        }
    }
}
