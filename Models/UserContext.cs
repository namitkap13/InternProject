using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Models
{
    internal class UserContext
    {
        public static UserContext _instance;
        public tbl_User User { get; set; }

        private UserContext()
        {
        }

        public static UserContext Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserContext();
                }
                return _instance;
            }
        }
    }
}
