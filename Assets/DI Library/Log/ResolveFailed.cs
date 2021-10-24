using SimpleDI.Message;
using UnityEngine;

namespace SimpleDI.Log
{
    public class ResolveFailed : DiLogger
    {
        public ResolveFailed(string logMessage = Messages.ContractResolveFailed, LogType logType = LogType.Error) : base(logMessage, logType)
        {
        }
    }
}