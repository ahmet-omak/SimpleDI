using SimpleDI.Message;
using UnityEngine;

namespace SimpleDI.Log
{
    public class BindFailed : DiLogger
    {
        public BindFailed(string logMessage = Messages.ContractFailed, LogType logType = LogType.Error) : base(logMessage, logType)
        {
        }
    }
}