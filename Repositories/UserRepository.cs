using SchoolProject.Helpers;
using SchoolProject.Models;
using SchoolProject.Models.DbContext;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SchoolProject.Repositories
{
    internal class UserRepository
    {

        private SchoolDbContext _dbContext;

        public UserRepository()
        {
            _dbContext = new SchoolDbContext();
        }

        public tbl_User GetUser(string username, string password)
        {
            try
            {
                GlobalLog.logger.Info($"Log in with Username[{username}] and password[{password}]");
                return _dbContext.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);

            }
            catch (Exception err)
            {
                GlobalLog.logger.Info("An error has ocurred: "+err.Message);
                return null;
            }
        }   
        
        public int addUser(tbl_User user)
        {
            try
            {
                _dbContext.Users.Add(user);
              int row = _dbContext.SaveChanges();
                if (row > 0)
                    GlobalLog.logger.Info("User saved to the database");
                return row;

            }
            catch (Exception err)
            {
                GlobalLog.logger.Error("An error has ocurred: "+err);
                return 0;
            }
        }



    }


}
