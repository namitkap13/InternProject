using SchoolProject.Helpers;
using SchoolProject.Models;
using SchoolProject.Models.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SchoolProject.Repositories
{
    public class ImagesRepository
    {
        private SchoolDbContext _Dbcontext;
        public ImagesRepository()
        {
            _Dbcontext = new SchoolDbContext();
        }

        public void AddImages(tbl_Images image)
        {
            try
            {
                _Dbcontext.Images.Add(image);
                _Dbcontext.SaveChanges();
                GlobalLog.logger.Info("New image added successfully and saved to the database");
            }
            catch (Exception err)
            {
                GlobalLog.logger.Error("An error has ocurred: "+err.Message);

            }
        }
    }
}
