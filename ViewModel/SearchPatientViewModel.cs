using SchoolProject.Helpers;
using SchoolProject.Models;
using SchoolProject.Models.DbContext;
using SchoolProject.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SchoolProject.ViewModel
{
    public class SearchPatientViewModel : INotifyPropertyChanged
    {
        private SchoolDbContext _dbContext;

        private List<string> _listPatient;
        private List<tbl_Patient> _patientsearched;
        private string _patientName = string.Empty;

        private tbl_Patient _selectedPatient;
        public ICommand SearchCommand { get; }
        public ICommand GoToStudyCommand { get; }

        #region Properties
        public List<string> ListPatient
        {
            get
            {
                return _listPatient;
            }
            set { _listPatient = value; OnPropertyChanged(nameof(ListPatient)); }

        }

        public string PatientName
        {
            get { return _patientName; }
            set { _patientName = value; OnPropertyChanged(nameof(PatientName)); }
        }

        public List<tbl_Patient> PatientSearched
        {
            get { return _patientsearched; }
            set { _patientsearched = value; OnPropertyChanged(nameof(PatientSearched)); }
        }

        public tbl_Patient Patient
        {
            get { return _selectedPatient; }
            set { _selectedPatient = value; OnPropertyChanged(nameof(_selectedPatient)); }
        }
        #endregion

        public void initialize()
        {
                GlobalLog.logger.Trace("Entering the initialize method");
            try
            {
                _dbContext = new SchoolDbContext();
                //list of the patients name to search
                _listPatient = _dbContext.patient.Select(d => d.FirstName).Distinct().ToList();
                //list of all patients 
                _patientsearched = _dbContext.patient.ToList();

            }
            catch (Exception err)
            {
                GlobalLog.logger.Error("An error has ocurred: "+err.Message);
            }

                GlobalLog.logger.Trace("Leaving the initialize method");
        }

        public SearchPatientViewModel()
        {
            try
            {
            SearchCommand = new RelayCommand(SearchPatient);
            GoToStudyCommand = new RelayCommand(GoToAddStudies);

            }
            catch (Exception err)
            {
                GlobalLog.logger.Error("An error has ocurred: "+err.Message);
            }
        }

        public void GoToAddStudies()
        {

            MainWindow.FrameView.Content = new Studies(_selectedPatient.Id);
        }

        public void SearchPatient()
        {
            try
            {
                if (PatientName != string.Empty)
                {

                    var list = PatientSearched.Where(d => d.FirstName.Trim().ToLower().Equals(PatientName.ToLower().Trim())).Select(d => d);
                    if (list != null && list.Count() > 0)
                    {
                        PatientSearched = list.ToList();

                    }
                    else
                    {
                        PatientSearched = _dbContext.patient.ToList();
                        MessageBox.Show("No patient found with that name.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                else
                    PatientSearched = _dbContext.patient.ToList();

            }
            catch (Exception er)
            {
                GlobalLog.logger.Error("An error has ocurred: "+er.Message);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
