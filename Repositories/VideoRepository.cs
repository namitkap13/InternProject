using SchoolProject.Models.DbContext;
using SchoolProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SchoolProject.Helpers;

namespace SchoolProject.Repositories
{
    public class VideoRepository
    {
        private SchoolDbContext _Dbcontext;
        public VideoRepository()
        {
            _Dbcontext = new SchoolDbContext();
        }

        public void AddVideos(tbl_Videos video)
        {
            try
            {
                _Dbcontext.Videos.Add(video);
                _Dbcontext.SaveChanges();
                GlobalLog.logger.Info("Video saved to the database");
            }
            catch (Exception err)
            {
                GlobalLog.logger.Error("An error has ocurred: "+err.Message);

            }
        }
    }
}
