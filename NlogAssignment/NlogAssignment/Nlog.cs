using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogAssignment
{
    public class Nlog
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        //Debug Method.
        public void LogDebug(string str)
        {
            logger.Debug(str);
        }
        //Error Method.
        public void LogError(string str)
        {
            logger.Error(str);
        }
        //Info Method.
        public void LogInfo(string str)
        {
            logger.Info(str);
        }
        //Warning Method.
        public void LogWarning(string str)
        {
            logger.Warn(str);
        }
    }
}
