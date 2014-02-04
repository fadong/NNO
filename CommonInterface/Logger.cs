using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Logging;

namespace CommonInterface {
    public static class CLogger {

        public static void LogError(Exception ex, string additionalMessage) {
            log.Error(additionalMessage, ex);
        }

        public static void LogTrace(string message) {
            log.Info(message);
        }

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    }
}
