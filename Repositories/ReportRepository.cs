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
    public class ReportRepository
    {
        private SchoolDbContext _dbContext;

        public ReportRepository()
        {
            _dbContext = new SchoolDbContext();
        }

        public void AddReport(tbl_Reports report)
        {
            try
            {
            _dbContext.Reports.Add(report);
            _dbContext.SaveChanges();
                GlobalLog.logger.Info("New report added and saved to the database.");

            }
            catch (Exception err)
            {
                GlobalLog.logger.Error("An error has ocurred: " + err.Message);
            }
        }
    }
}
