using SchoolProject.Helpers;
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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Frame FrameView { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            FrameView = FrmPages;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login view = new Login();
            view.Show();
            view.Activate();
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Page currentPage = FrameView.Content as Page;

            if (currentPage != null)
            {
                DataViewModel videoPageViewModel = currentPage.DataContext as DataViewModel;

                if (videoPageViewModel != null)
                {
                    videoPageViewModel.ClosingVideo();
                    GlobalLog.logger.Info("Closing app");
                }
            }
        }
    }
}
