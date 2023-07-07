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
    public class SeriesRepository
    {
        private SchoolDbContext _dbContext;

        public SeriesRepository()
        {
            _dbContext = new SchoolDbContext();
        }

        public List<tbl_Series> GetSeries(int studyId)
        {
            try
            {

                GlobalLog.logger.Info("Searching for series for the study id: " + studyId);
                return _dbContext.Series.Where(d => d.studyId == studyId).ToList();
            }
            catch (Exception ex)
            {
                GlobalLog.logger.Error("An error has ocurred: " + ex.Message);
                return null;
            }
        }



        public int AddSeries(tbl_Series series)
        {
            try
            {
                _dbContext.Series.Add(series);
                int row = _dbContext.SaveChanges();
                if (row > 0)
                    GlobalLog.logger.Info("New serie has been added to study id: " + series.studyId + " and saved to the database");

                return row;
            }
            catch (Exception ex)
            {
                GlobalLog.logger.Error("An error has ocurred: " +ex.Message);
                return 0;

            }
        }

    }
}
