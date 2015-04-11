using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehcizat
{
    static class User
    {
        private static int _globalUserId;
        private static string _globalUsername;

        public static int GlobalUserId
        {
            get { return _globalUserId; }
            set { _globalUserId = value; }
        }

        public static string GlobalUsername
        {
            get { return _globalUsername; }
            set { _globalUsername = value; }
        }
    }
}
