using SimpleDI.Message;
using UnityEngine;

namespace SimpleDI.Log
{
    public abstract class DiLogger
    {
        private static ILogger logger = Debug.unityLogger;

        public DiLogger(string logMessage = Messages.DefaultMessage, LogType logType = LogType.Log)
        {
            if (logType == LogType.Error || logType == LogType.Exception)
            {
                Debug.Break();
            }

            logger.Log(logType, logMessage);
        }
    }
}