using SchoolProject.Helpers;
using SchoolProject.Models;
using SchoolProject.Models.DbContext;
using SchoolProject.Repositories;
using SchoolProject.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SchoolProject.ViewModel
{
    public class AddRecordViewModel : INotifyPropertyChanged
    {
        private string _firstName = string.Empty;
        private string _LastName = string.Empty;
        private DateTime _DOB = new DateTime(2000, 01, 01);
        private int _Gender = 2;
        private string _Email = string.Empty;
        private SchoolDbContext _dbContext;
        private Regex ValidEmail = new Regex(@"^[\w\.-]+@[\w\.-]+\.\w+$");
        public ICommand AddRecordCommand { get; }
        public ICommand RadioCommand { get; }

        #region Properties
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                _LastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        public DateTime DOB
        {
            get
            {
                return _DOB.Date;
            }
            set
            {
                _DOB = value;
                OnPropertyChanged(nameof(DOB));
            }

        }

        public int Gender
        {
            get
            {
                return _Gender;
            }
            set
            {
                _Gender = value;
                OnPropertyChanged(nameof(Gender));
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }
        #endregion

        public AddRecordViewModel()
        {
            GlobalLog.logger.Trace("Entering the constructor");
            AddRecordCommand = new RelayCommand(addRecord);
            _dbContext = new SchoolDbContext();
            GlobalLog.logger.Trace("leaving  the constructor");
        }

        private void addRecord()
        {
            try
            {
                GlobalLog.logger.Trace("Entering to the add record method.");
                if (UserContext.Instance.User.roleId == 1)
                {

                    
                    if (Email != string.Empty && FirstName != string.Empty && LastName != string.Empty)
                    {
                        if (!ValidEmail.IsMatch(Email))
                        {
                            MessageBox.Show("Email has a bad format or empty", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                            GlobalLog.logger.Warn("Email has a bad format or empty");
                            return;

                        }
                        DateTime Date = Convert.ToDateTime(DOB.ToString("dd/MM/yyyy"));
                        string gender = Gender == 0 ? "Male" : "Female";

                        if (Date == null && Date.Year > DateTime.Now.Year && Date.Month > DateTime.Now.Month)
                            MessageBox.Show("The date of birth cannot be higher than the current one");

                        tbl_Patient patient = new tbl_Patient()
                        {
                            DOB = Date,
                            FirstName = FirstName,
                            Email = Email,
                            Gender = gender,
                            LastName = LastName
                        };
                        RecordRepository Repository = new RecordRepository();
                        var row = Repository.AddPatient(patient);
                        if (row != null)
                        {
                            ClearData();
                            MessageBox.Show("New patient added successfully", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                            GoToAddStudies(row);

                        }
                        else
                            MessageBox.Show("No patient added, try it again", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

                    }
                    else
                    {
                        MessageBox.Show("Please fill in all required data", "Warning", MessageBoxButton.OK, MessageBoxImage.Information);
                        GlobalLog.logger.Warn("Please fill in all required data");
                    }

                }
                else
                {
                    MessageBox.Show("Only admins can add patients", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    GlobalLog.logger.Warn("Only admins can add patients");
                }

                GlobalLog.logger.Trace("Leaving the addrecord method");


            }
            catch (Exception err)
            {
                GlobalLog.logger.Error("An error has ocurred: " + err.Message);
            }
        }
        public void GoToAddStudies(tbl_Patient patient)
        {
            GlobalLog.logger.Info("Go to add studies and series for this patient");
            MainWindow.FrameView.Content = new Studies(patient.Id);
        }
        public void ClearData()
        {
            GlobalLog.logger.Trace("Entering in the clear data method");
            try
            {
                DOB = new DateTime(2000, 01, 01);
                FirstName = string.Empty;
                LastName = string.Empty;
                Email = string.Empty;
                Gender = 2;

            }
            catch (Exception err)
            {
                GlobalLog.logger.Error("An error has ocurred: " + err.Message);
            }
            GlobalLog.logger.Trace("Leaving the clear data method");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
