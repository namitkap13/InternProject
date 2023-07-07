using SchoolProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace SchoolProject.ViewModel
{
    public class MainWindowViewModel
    {
        public ICommand NavigateToPage1Command { get; }
        public ICommand NavigateToPage2Command { get; }
        public ICommand NavigateToPage3Command { get; }

        public MainWindowViewModel()
        {
            NavigateToPage1Command = new RelayCommand(NavigateToPage1);
            NavigateToPage2Command = new RelayCommand(NavigateToPage2);
            NavigateToPage3Command = new RelayCommand(NavigateToPage3);
        }

        private void NavigateToPage1()
        {
            MainWindow.FrameView.Content = new addRecord();
        }

        private void NavigateToPage2()
        {
            MainWindow.FrameView.Content = new Search();
        }
        private void NavigateToPage3()
        {
            MainWindow.FrameView.Content = new UserControl();
        }


    }
}
