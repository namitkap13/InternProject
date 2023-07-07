using Org.BouncyCastle.Crypto.Agreement;
using SchoolProject.Helpers;
using SchoolProject.Models;
using SchoolProject.Models.DbContext;
using SchoolProject.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SchoolProject.ViewModel
{
    public class UserControlViewModel : INotifyPropertyChanged
    {
        private string _username = string.Empty;
        private string _password = string.Empty;
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private string _email = string.Empty;
        private SchoolDbContext _dbContext;
        private int _gender = 2;
        private DateTime _DOB = new DateTime(2000, 01, 01);
        private List<tbl_Roles> _listRoles = new List<tbl_Roles>();
        private tbl_Roles _selectedRole;
        private bool _EnabledUser = UserContext.Instance.User.roleId == 1 ? true : false;
        private Regex ValidEmail = new Regex(@"^[\w\.-]+@[\w\.-]+\.\w+$");

        private string _CurrentUser = UserContext.Instance.User.FirstName;

        private string _CurrentGroup;

        public ICommand UserCommand { get; }
        #region Properties
        public string UserName
        {
            get { return _username; }
            set { _username = value; OnPropetyChange(nameof(UserName)); }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; OnPropetyChange(nameof(Password)); }
        }

        public string FirstName
        {
            get => _firstName;
            set { _firstName = value; OnPropetyChange(nameof(FirstName)); }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; OnPropetyChange(nameof(LastName)); }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; OnPropetyChange(nameof(Email)); }
        }

        public int Gender
        {
            get { return _gender; }
            set
            { _gender = value; OnPropetyChange(nameof(Gender)); }
        }

        public bool EnabledUser
        {
            get { return _EnabledUser; }
            set { _EnabledUser = value; OnPropetyChange(nameof(EnabledUser)); }
        }
        public string CurrentGroup
        {
            get { return _CurrentGroup; }
            set { _CurrentGroup = value; OnPropetyChange(nameof(CurrentGroup)); }
        }
        public string CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; OnPropetyChange(nameof(CurrentUser)); }
        }
        public DateTime DOB
        {
            get { return _DOB; }
            set { _DOB = value; OnPropetyChange(nameof(DOB)); }
        }
        public List<tbl_Roles> ListRoles
        {
            get { return _listRoles; }
            set { _listRoles = value; OnPropetyChange(nameof(ListRoles)); }

        }

        public tbl_Roles SelectedRole
        {
            get { return _selectedRole; }
            set { _selectedRole = value; OnPropetyChange(nameof(SelectedRole)); }
        }
        #endregion

        public UserControlViewModel()
        {
            try
            {
                UserCommand = new RelayCommand(AddUser);

            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err);
            }
        }
        public void Initialize()
        {
            try
            {
                _dbContext = new SchoolDbContext();
                _listRoles = _dbContext.roles.ToList();

                if (UserContext.Instance.User.roleId == 1)
                    _CurrentGroup = "Administrator";
                else if (UserContext.Instance.User.roleId == 2)
                    _CurrentGroup = "Doctor";
                else if (UserContext.Instance.User.roleId == 3)
                    _CurrentGroup = "Operator";
                else
                    _CurrentGroup = "Unknow";
                GlobalLog.logger.Info($"Initializing: Group[{_CurrentGroup}] User[{_CurrentUser}]");
            }
            catch (Exception err)
            {
                GlobalLog.logger.Error("An error has ocurred: " + err.Message);
            }
        }


        public void ClearData()
        {
            try
            {
                UserName = string.Empty;
                //Know how to clean passwordbox
                //Password = string.Empty;
                FirstName = string.Empty;
                LastName = string.Empty;
                Email = string.Empty;
                Gender = 2;
                DOB = new DateTime();
                SelectedRole = null;
                GlobalLog.logger.Info("Clearing data");
            }
            catch (Exception err)
            {
                GlobalLog.logger.Error("An error has ocurred: " + err.Message);
            }
        }
        public void AddUser()
        {
            try
            {
                if (UserContext.Instance.User.roleId == 1)
                {
                 
                    DateTime Date = Convert.ToDateTime(_DOB.ToString("dd/MM/yyyy"));
                    string gender = Gender == 0 ? "Male" : "Female";

                    if (Date.Year > DateTime.Now.Year || (Date.Month > DateTime.Now.Month && Date.Year > DateTime.Now.Year))
                    {
                        MessageBox.Show("The date of birth cannot be higher than the current one", "Error", MessageBoxButton.OK);
                        return;
                    }

                    if (Date.Year < 1600)
                    {
                        MessageBox.Show("The date of birth year cannot be lower than 1600", "Error", MessageBoxButton.OK);
                        return;
                    }
                    if (Date != null && FirstName != string.Empty && LastName != string.Empty && Email != string.Empty
                        && UserName != string.Empty && Password != string.Empty && SelectedRole != null && Gender != 2)
                    {
                        if (!ValidEmail.IsMatch(Email))
                        {
                            MessageBox.Show("Email has a bad format or empty", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                            GlobalLog.logger.Warn("Email has a bad format or empty");
                            return;

                        }
                        tbl_User user = new tbl_User()
                        {
                            UserName = UserName,
                            Password = Password,
                            FirstName = FirstName,
                            LastName = LastName,
                            DOB = Date,
                            Email = Email,
                            roleId = SelectedRole.Id,
                            Gender = gender
                        };
                        UserRepository Repository = new UserRepository();
                        var row = Repository.addUser(user);

                        if (row > 0)
                        {
                            MessageBox.Show("User add successfully", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                            ClearData();
                        }
                        else
                            MessageBox.Show("No user added, try it again", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

                    }
                    else
                        MessageBox.Show("Please fill in all required data", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

                }
                else
                    MessageBox.Show("Only admins can add users.", "Warning", MessageBoxButton.OK, MessageBoxImage.Information);


            }
            catch (Exception err)
            {
                GlobalLog.logger.Error("An error has ocurred: " + err.Message);

            }

        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropetyChange(string propertyName)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
