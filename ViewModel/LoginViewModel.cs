
using SchoolProject.Helpers;
using SchoolProject.Models;
using SchoolProject.Models.DbContext;
using SchoolProject.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace SchoolProject.ViewModel
{
    internal class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private SchoolDbContext _dbContext;

        private string _UserName = string.Empty;
        private string _Password = string.Empty;
        private string _isVisible = "Hidden";

        #region Properties
        public string Username
        {
            get { return _UserName; }
            set
            {
                _UserName = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        public string Password
        {
            get { return _Password; }
            set
            {
                _Password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public string IsVisible
        {
            get { return _isVisible; }
            set
            {
                _isVisible = value;
                OnPropertyChanged(nameof(IsVisible));
            }
        }
        #endregion
        public LoginViewModel()
        {
            GlobalLog.logger.Trace("Entering in the constructor");
            _dbContext = new SchoolDbContext();
            GlobalLog.logger.Trace("Leaving the constructor");

        }



        public bool Login()
        {
            GlobalLog.logger.Trace("Entering in the Login method");
            try
            {

                UserRepository userRepository = new UserRepository();
                tbl_User user = userRepository.GetUser(Username, Password);
                if (user != null)
                {
                    UserContext.Instance.User = user;
                    GlobalLog.logger.Trace("Leaving the Login method");
                    return true;
                }
                else
                {
                    IsVisible = "Visible";
                    GlobalLog.logger.Info("Log in failed");
                    return false;
                }


            }
            catch (Exception error)
            {
                GlobalLog.logger.Error("An error has ocurred: "+error.Message);
                return false;
            }
        }

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
