using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Helpers
{
    
    public static class GlobalLog
    {
        public static readonly Logger logger = LogManager.GetLogger("file");

    }
}
