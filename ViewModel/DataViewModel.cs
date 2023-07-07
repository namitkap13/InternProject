using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;
using Accord.Video.FFMPEG;
using SchoolProject.Models;
using SchoolProject.Models.DbContext;
using SchoolProject.Repositories;
using iText.IO.Font;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Pdfa;
using iText.Layout;
using SchoolProject.Helpers;
using Microsoft.Win32;


namespace SchoolProject.ViewModel
{
    public class DataViewModel : INotifyPropertyChanged
    {


        private tbl_Patient patient;
        private tbl_Series series = new tbl_Series();
        private SchoolDbContext _dbContext;
        private string CapturesFolder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Captures");
        private string VideoFolder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Videos");
        private string videopath;
        private string capturePath;
        private int _SelectedCameraIndex;

        private List<string> _WebCamsList = new List<string>() { "Choose camera" };

        private FilterInfoCollection _MyDevices;
        private VideoCaptureDevice _WebCam = null;
        private VideoFileWriter _VideoWriter = null;
        private BitmapSource _frameCam;
        public ICommand SelectedCommand { get; }
        public ICommand SavePictureCommmand { get; }
        public ICommand CreateReportCommand { get; }
        public ICommand SaveRecordCommand { get; }
        public ICommand StopRecordCommand { get; }


        #region Properties
        public List<string> WebCamList
        {
            get { return _WebCamsList; }
            set { _WebCamsList = value; OnPropertyChanged(nameof(WebCamList)); }
        }

        public int SelectedCameraIndex
        {
            get => _SelectedCameraIndex;
            set { _SelectedCameraIndex = value; OnPropertyChanged(nameof(SelectedCameraIndex)); }
        }

        public BitmapSource FrameCam
        {
            get { return _frameCam; }
            set { _frameCam = value; OnPropertyChanged(nameof(FrameCam)); }
        }
        #endregion

        public DataViewModel()
        {
            GlobalLog.logger.Trace("Entering in the constructor");
            _dbContext = new SchoolDbContext();
            SelectedCommand = new RelayCommand(StartVideo);
            SavePictureCommmand = new RelayCommand(TakePicture);
            SaveRecordCommand = new RelayCommand(StartVideoRecording);
            StopRecordCommand = new RelayCommand(StopVideoRecording);
            CreateReportCommand = new RelayCommand(CreateReport);
            GlobalLog.logger.Trace("Leaving the constructor");
        }
        public void initialize(int patientId, int seriesId)
        {
            GlobalLog.logger.Trace("Entering in the initialize method");
            try
            {
                _MyDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (_MyDevices != null && _MyDevices.Count > 0)
                {
                    for (int i = 0; i < _MyDevices.Count; i++)
                        _WebCamsList.Add(_MyDevices[i].Name.ToString());
                }

                RecordRepository record = new RecordRepository();
                patient = record.getPatientById(patientId);
                series.Id = seriesId;
                GlobalLog.logger.Info("All primary data charged successfully");
            }
            catch (Exception err)
            {
                GlobalLog.logger.Error("An error has ocurred: " + err.Message);
            }
            GlobalLog.logger.Trace("Leaving the initialize method");
        }

        public void StartVideo()
        {
            GlobalLog.logger.Trace("Entering in the startVideo method");
            try
            {
                if (_WebCam != null && _WebCam.IsRunning)
                {
                    _WebCam.SignalToStop();
                    _WebCam = null;
                    FrameCam = null;
                    GlobalLog.logger.Info("An video has initiated before, stoping the video");
                }
                if (SelectedCameraIndex != 0 && _MyDevices.Count > 0)
                {

                    int i = _SelectedCameraIndex - 1;
                    string videoName = _MyDevices[i].MonikerString;
                    _WebCam = new VideoCaptureDevice(videoName);
                    _WebCam.NewFrame += new NewFrameEventHandler(FrameCapture);
                    _WebCam.Start();
                    GlobalLog.logger.Info("new camera selected, starting live view");
                }
            }
            catch (Exception err)
            {
                GlobalLog.logger.Error("An error has ocurred.");
            }
            GlobalLog.logger.Trace("Leaving the startvideo method");
        }

        private void FrameCapture(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    FrameCam = ConvertBitmapToBitmapImage(eventArgs.Frame.Clone() as Bitmap);

                    if (_VideoWriter != null && _VideoWriter.IsOpen)
                        _VideoWriter.WriteVideoFrame(eventArgs.Frame);
                });

            }
            catch (Exception err)
            {
                GlobalLog.logger.Error("An error has ocurred: " + err.Message);
            }
        }

        private void TakePicture()
        {
            GlobalLog.logger.Trace("Entering in the TakePicture method");
            try
            {
                if (_WebCam != null && _WebCam.IsRunning)
                {
                    BitmapEncoder encoder = new JpegBitmapEncoder();  // to encode the picture
                    encoder.Frames.Add(BitmapFrame.Create(FrameCam));
                    string pathcombine = patient.FirstName + "-" + DateTime.Now.ToString("ddMMyyyyHHmss") + ".jpg";
                    capturePath = Path.Combine(CapturesFolder, pathcombine);

                    //creating the file saving the photo
                    using (var fileStream = new FileStream(capturePath, FileMode.Create))
                    {
                        encoder.Save(fileStream);
                        GlobalLog.logger.Info("Picture saved in: " + capturePath);
                        tbl_Images image = new tbl_Images()
                        {
                            ImageName = capturePath,
                            seriesId = series.Id
                        };

                        ImagesRepository imagesRepository = new ImagesRepository();
                        imagesRepository.AddImages(image);

                        MessageBox.Show("Pictured saved succesfully", "Succes", MessageBoxButton.OK, MessageBoxImage.Information);
                    }

                }
                else
                    GlobalLog.logger.Warn("Webcam not selected or not running");
            }
            catch (Exception err)
            {
                GlobalLog.logger.Error("An error has ocurred: " + err.Message);
            }
            GlobalLog.logger.Trace("Leaving the TakePicture method");
        }

        public void StartVideoRecording()
        {
            GlobalLog.logger.Trace("Entering in the StartVideoRecording method");
            try
            {
                if (_VideoWriter != null && _VideoWriter.IsOpen)
                {
                    MessageBox.Show("Already recording", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    GlobalLog.logger.Error("Trying to start recording when there is already recording");
                    return;
                }

                if (_WebCam != null && _WebCam.IsRunning)
                {
                    // Configurar la ruta y el nombre del archivo de video
                    string fileName = patient.FirstName + "-" + DateTime.Now.ToString("ddMMyyyyHHmss") + ".mp4";
                    videopath = Path.Combine(VideoFolder, fileName);

                    _VideoWriter = new VideoFileWriter();
                    _VideoWriter.Open(videopath, 1280, 720, 30, VideoCodec.MPEG4);
                    GlobalLog.logger.Info("Starting recording");
                }
                else
                {
                    MessageBox.Show("Choose a camera first to start recording", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    GlobalLog.logger.Warn("No camera selected to start recording");
                }
            }
            catch (Exception err)
            {
                GlobalLog.logger.Error("An error has ocurred: " + err.Message);
            }
            GlobalLog.logger.Trace("Leaving the StartVideoRecording method");
        }
        public void StopVideoRecording()
        {
            GlobalLog.logger.Trace("Entering the StopVideoRecording method");
            try
            {
                if (_WebCam != null && _WebCam.IsRunning && _VideoWriter != null && _VideoWriter.IsOpen)
                {
                    _VideoWriter.Close();
                    _VideoWriter = null;
                    GlobalLog.logger.Info("Stoped video recording");
                    tbl_Videos video = new tbl_Videos()
                    {
                        Name = videopath,
                        Date = DateTime.Now,
                        seriesId = series.Id
                    };
                    VideoRepository videoRepository = new VideoRepository();
                    videoRepository.AddVideos(video);
                    GlobalLog.logger.Info("The video was saved in: " + videopath);
                    MessageBox.Show("Video saved succesfully", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Start recording first", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    GlobalLog.logger.Warn("User trying to stop recording when there is no recording");
                }
            }
            catch (Exception err)
            {
                GlobalLog.logger.Error("An error has ocurred: " + err.Message);
            }
            GlobalLog.logger.Trace("Leaving the StopVideoRecording method");
        }

        public void ClosingVideo()
        {
            GlobalLog.logger.Trace("Entering ClosingVideo method");
            try
            {
                if (_WebCam != null && _WebCam.IsRunning)
                {
                    _WebCam.SignalToStop();
                    _WebCam = null;
                }

                if (_VideoWriter != null && _VideoWriter.IsOpen)
                {
                    _VideoWriter.Close();
                    _VideoWriter = null;
                }
                GlobalLog.logger.Info("All video cleared");
            }
            catch (Exception err)
            {
                GlobalLog.logger.Error("An error has ocurred: " + err.Message);
            }
            GlobalLog.logger.Trace("Leaving ClosingVideo method");
        }

        public void CreateReport()
        {
            GlobalLog.logger.Trace("Entering in the CreateReport method");
            try
            {
                if (_WebCam != null && _WebCam.IsRunning)
                {

                    string filePDF = Environment.CurrentDirectory + "\\PDFResources\\sRGB_CS_profile.icm";
                    string filePDFFONT = Environment.CurrentDirectory + "\\PDFResources\\FreeSans.ttf";

                    System.Windows.Forms.FolderBrowserDialog folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
                    var result = folderBrowserDialog.ShowDialog();
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {

                        string fileName = Path.Combine(folderBrowserDialog.SelectedPath, patient.FirstName + "-" + $"{DateTime.Now:yyyyMMdd HHmm}-.pdf");
                        PdfADocument pdf = new PdfADocument(
                        new PdfWriter(fileName),
                        PdfAConformanceLevel.PDF_A_1B,
                        new PdfOutputIntent("Custom", "", "http://www.color.org", "sRGB IEC61966-2.1",
                        new FileStream(filePDF, FileMode.Open, FileAccess.Read)));

                        PdfFont font = PdfFontFactory.CreateFont(filePDFFONT, PdfEncodings.WINANSI,
                        PdfFontFactory.EmbeddingStrategy.FORCE_EMBEDDED);
                        Document document = new Document(pdf);

                        document.SetFont(font);

                        Paragraph Pname = new Paragraph($"Patient Name: {patient.FirstName} {patient.LastName}").SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).SetFontSize(15);
                        document.Add(Pname);
                        Paragraph PDob = new Paragraph($"Patient DOB: {patient.DOB.ToString("dd-MMM-yyyy HH:mm:ss tt")}").SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).SetFontSize(15);
                        document.Add(PDob);
                        Paragraph PGender = new Paragraph($"Patient Gender: {patient.Gender}").SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).SetFontSize(15);
                        document.Add(PGender);
                        Paragraph PUser = new Paragraph($"Patient Report Exported By: {UserContext.Instance.User.FirstName}").SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).SetFontSize(15);
                        document.Add(PUser);

                        //adding image
                        ImageData imageData = ImageDataFactory.Create(UtilsPdf.ConvertBitmapSourceToByteArray(FrameCam));

                        iText.Layout.Element.Image imagen = new iText.Layout.Element.Image(imageData);
                        imagen.ScaleAbsolute(250, 220).SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.LEFT).SetMarginTop(15);
                        document.Add(imagen);

                        document.Flush();
                        document.Close();

                        tbl_Reports report = new tbl_Reports()
                        {
                            Date = DateTime.Now,
                            Name = fileName,
                            seriesId = series.Id
                        };

                        ReportRepository reportRepository = new ReportRepository();
                        reportRepository.AddReport(report);
                        GlobalLog.logger.Info("Reported saved in: " + fileName);
                        MessageBox.Show("Report exported successfully", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    }


                }
                else
                {
                    MessageBox.Show("First start the view chosing the camera", "Warning", MessageBoxButton.OK, MessageBoxImage.Information);
                    GlobalLog.logger.Warn("The user try to create the PDF but theres no camera to take the picture of the patient.");
                }

            }
            catch (Exception ex)
            {
                GlobalLog.logger.Error("An error has ocurred: " + ex.Message);
            }
            GlobalLog.logger.Trace("Leaving in the CreateReport method");
        }
        private BitmapImage ConvertBitmapToBitmapImage(Bitmap bitmap)
        {
            try
            {
                MemoryStream memoryStream = new MemoryStream();
                bitmap.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = new MemoryStream(memoryStream.ToArray());
                bitmapImage.EndInit();
                return bitmapImage;
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err);
                return null;
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyChanged)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyChanged));
        }

    }
}
