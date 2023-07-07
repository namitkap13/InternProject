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
    public class StudiesRepository
    {
        private SchoolDbContext _dbContext;

        public StudiesRepository()
        {
            _dbContext = new SchoolDbContext();
        }

        public int AddStudy(tbl_Study study)
        {
            try
            {
                _dbContext.Study.Add(study);
                int row = _dbContext.SaveChanges();
                if (row > 0)
                    GlobalLog.logger.Info("New study added to the patient id: " + study.patientId + " and saved to the database");
                return row;
            }
            catch (Exception err)
            {
                GlobalLog.logger.Error("An error has ocurred: " +err.Message);
                return 0;
            }
        }

        public List<tbl_Study> GetStudyList(int patientId)
        {
            try
            {
                GlobalLog.logger.Info("Getting all studies for the patient id: " +patientId);
                return _dbContext.Study.Where(d => d.patientId == patientId).ToList();
            }
            catch (Exception err)
            {
                GlobalLog.logger.Error("An error has ocurred: "+err.Message);
                return null;
            }
        }

    }
}
