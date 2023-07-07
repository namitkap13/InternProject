using SchoolProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace SchoolProject.Views
{
    /// <summary>
    /// Lógica de interacción para Data.xaml
    /// </summary>
    public partial class DataView : Page
    {
        public DataView(int patientId, int seriesId)
        {
            DataViewModel viewModel = new DataViewModel();
            viewModel.initialize(patientId, seriesId);
            DataContext = viewModel;
            InitializeComponent();
        }

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {
            (DataContext as DataViewModel).ClosingVideo();
        }
    }
}
