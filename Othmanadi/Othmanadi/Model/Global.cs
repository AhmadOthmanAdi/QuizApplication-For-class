using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Othmanadi.Model
{
    public static class Global
    {
        
        private static int _loggedInUserId;

        public static int LoggedInUserId
        {
            get { return _loggedInUserId; }
            set { _loggedInUserId = value; }
        }

       
    }
}
