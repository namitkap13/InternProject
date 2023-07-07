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
using System.Windows.Shapes;

namespace SchoolProject
{
    /// <summary>
    /// Lógica de interacción para Loginxaml.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
            TxtUserName.Focus();
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            { ((dynamic)this.DataContext).Password = ((PasswordBox)sender).Password; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool log = (DataContext as LoginViewModel).Login();
            if (log)
            {
                MainWindow view = new MainWindow();
                view.Show();
                this.Close();
                view.Activate();

            }
        }
    }
}
