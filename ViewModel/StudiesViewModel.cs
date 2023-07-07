using SchoolProject.Helpers;
using SchoolProject.Models;
using SchoolProject.Models.DbContext;
using SchoolProject.Repositories;
using SchoolProject.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SchoolProject.ViewModel
{
    public class StudiesViewModel : INotifyPropertyChanged
    {
        private string _studyName = string.Empty;
        private string _seriesName = string.Empty;
        private int _patientId;

        private tbl_Study _selectedStudy;
        private tbl_Series _selectedSeries;

        private List<tbl_Study> _studyList;
        private List<tbl_Series> _seriesList;

        private SchoolDbContext _dbContext;

        public ICommand AddStudyCommand { get; }
        public ICommand AddSeriesCommand { get; }

        public ICommand SelectionChanged { get; }
        public ICommand ChangeViewCommand { get; }
        #region Properties
        public string StudyName
        {
            get { return _studyName; }
            set { _studyName = value; OnPropertyChanged(nameof(StudyName)); }
        }

        public string SeriesName
        {
            get { return _seriesName; }
            set { _seriesName = value; OnPropertyChanged(nameof(SeriesName)); }
        }

        public List<tbl_Study> StudyList
        {
            get { return _studyList; }
            set { _studyList = value; OnPropertyChanged(nameof(StudyList)); }
        }

        public List<tbl_Series> SeriesList
        {
            get { return _seriesList; }
            set { _seriesList = value; OnPropertyChanged(nameof(SeriesList)); }
        }

        public int PatientId
        {
            get { return _patientId; }
            set { _patientId = value; OnPropertyChanged(nameof(PatientId)); }
        }

        public tbl_Study SelectedStudy
        {
            get { return _selectedStudy; }
            set { _selectedStudy = value; OnPropertyChanged(nameof(SelectedStudy)); }
        }

        public tbl_Series SelectedSeries
        {
            get { return _selectedSeries; }
            set { _selectedSeries = value; OnPropertyChanged(nameof(SelectedSeries)); }
        }
        #endregion
        public StudiesViewModel()
        {
            try
            {
                AddStudyCommand = new RelayCommand(addStudy);
                AddSeriesCommand = new RelayCommand(addSeries);
                SelectionChanged = new RelayCommand(StudyChanged);
                ChangeViewCommand = new RelayCommand(ChangeView);
            }
            catch (Exception err)
            {
                GlobalLog.logger.Error("An error has ocurred: " + err.Message);
            }
        }
        private void ChangeView()
        {
            try
            {
                if (SelectedSeries != null)
                    MainWindow.FrameView.Content = new DataView(_patientId, SelectedSeries.Id);
                else
                    MessageBox.Show("First select a series to add the data", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            catch (Exception err)
            {
                GlobalLog.logger.Error("An error has ocurred: "+ err.Message);
            }

        }
        public void initialize(int patientId)
        {
            
            try
            {
                _dbContext = new SchoolDbContext();
                StudiesRepository studiesRepository = new StudiesRepository();
                _studyList = studiesRepository.GetStudyList(patientId);
                _patientId = patientId;
                GlobalLog.logger.Info("All data loaded");
                //SeriesList = studiesRepository.GetStudyList(PatientId);

            }
            catch (Exception err)
            {
                GlobalLog.logger.Error("An error has ocurred: " +err.Message);
            }

        }

        public void addStudy()
        {
            GlobalLog.logger.Trace("Entering in the add study method");
            try
            {
                if (StudyName == string.Empty)
                {
                    MessageBox.Show("Write a study name", "Warning", MessageBoxButton.OK, MessageBoxImage.Information);
                    GlobalLog.logger.Warn("The user has no write a study name");
                    return;
                }
                tbl_Study study = new tbl_Study()
                {
                    Date = DateTime.Now,
                    Name = StudyName,
                    patientId = PatientId
                };

                StudiesRepository studiesRepository = new StudiesRepository();
                int row = studiesRepository.AddStudy(study);
                if (row != 0)
                {
                    MessageBox.Show("Study added successfully.", "Added", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    StudyName = string.Empty;
                }
                else
                    MessageBox.Show("No study added, try again.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

                StudyList = studiesRepository.GetStudyList(PatientId);


            }
            catch (Exception ex)
            {
                GlobalLog.logger.Error("An error has ocurred: "+ex.Message);
            }
            GlobalLog.logger.Trace("Leaving the add study method");
        }

        public void StudyChanged()
        {
            try
            {
                GlobalLog.logger.Info("Study selected changed");
                if (SelectedStudy != null)
                {
                    SeriesRepository seriesRepository = new SeriesRepository();
                    SeriesList = seriesRepository.GetSeries(SelectedStudy.Id);
                }
            }
            catch (Exception err)
            {
                GlobalLog.logger.Error("An error has ocurred: "+err.Message);
            }
        }

        public void addSeries()
        {
            GlobalLog.logger.Trace("Entering in addseries method");
            try
            {
                if (SeriesName != string.Empty && SelectedStudy != null)
                {
                    tbl_Series series = new tbl_Series()
                    {
                        Date = DateTime.Now,
                        Name = SeriesName,
                        studyId = SelectedStudy.Id
                    };

                    SeriesRepository seriesRepository = new SeriesRepository();
                    int row = seriesRepository.AddSeries(series);
                    if (row != 0)
                    {
                        MessageBox.Show("Series added successfully.", "Added", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                        SeriesName = string.Empty;
                    }
                    else
                        MessageBox.Show("No series added try again.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

                    SeriesList = seriesRepository.GetSeries(SelectedStudy.Id);
                }
            }
            catch (Exception err)
            {
                GlobalLog.logger.Error("An error has ocurred: "+err.Message);
            }
            GlobalLog.logger.Trace("Leaving the addseries method");
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyChange)
        {
            try
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyChange));

            }
            catch (Exception err)
            {
                GlobalLog.logger.Error("An error has ocurred: "+err.Message);
            }
        }
    }
}
