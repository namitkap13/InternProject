using SchoolProject.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SchoolProject.Models.DbContext;
using System.Data.Entity;
using SchoolProject.Helpers;

namespace SchoolProject.Repositories
{
    public class RecordRepository
    {
        private SchoolDbContext _dbContext;

        public RecordRepository()
        {
            _dbContext = new SchoolDbContext();
        }

        public tbl_Patient AddPatient(tbl_Patient patient)
        {
            try
            {
                tbl_Patient PatientAdded = _dbContext.patient.Add(patient);
                _dbContext.SaveChanges();
                GlobalLog.logger.Info("New patient added successfully and saved to the database");

                return PatientAdded;

            }
            catch (Exception err)
            {
                GlobalLog.logger.Info("An error has ocurred: " + err.Message);
                return null;
            }

        }

        public tbl_Patient getPatientById(int id)
        {
            try
            {
                GlobalLog.logger.Trace("Finding patient by id...");
                return _dbContext.patient.Find(id);

            }
            catch (Exception err)
            {
                GlobalLog.logger.Error("An error has ocurred: "+err.Message);
                return null;
            }
        }
    }
}

