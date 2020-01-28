using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace tp2048
{
    static class Logs
    {
        private static ILog _log = LogManager.GetLogger("2048");

        public static void Debug(string message)
        {
            _log.Debug(message);
        }
        public static void Info(string message)
        {
            _log.Info(message);
        }
        public static void Warn(string message)
        {
            _log.Warn(message);
        }
        public static void Error(string message)
        {
            _log.Error(message);
        }
        public static void Fatal(string message)
        {
            _log.Fatal(message);
        }
    }
}
