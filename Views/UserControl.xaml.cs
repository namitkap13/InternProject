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
    /// Lógica de interacción para UserControl.xaml
    /// </summary>
    public partial class UserControl : Page
    {
        public UserControl()
        {
            InitializeComponent();
            UserControlViewModel userControlViewModel = new UserControlViewModel();
            userControlViewModel.Initialize();
            this.DataContext = userControlViewModel;
            TxtUserName.Focus();
        }

        private void PbPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            { ((dynamic)this.DataContext).Password = ((PasswordBox)sender).Password; }
        }

        
    }
}
