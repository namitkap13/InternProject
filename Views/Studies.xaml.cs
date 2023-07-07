using SchoolProject.Repositories;
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

namespace SchoolProject.Views
{
    /// <summary>
    /// Lógica de interacción para Studies.xaml
    /// </summary>
    public partial class Studies : Page
    {
        public Studies(int patientId)
        {
            InitializeComponent();
            StudiesViewModel viewModel = new StudiesViewModel();
            viewModel.initialize(patientId);
            this.DataContext = viewModel;

        }
    }
}
