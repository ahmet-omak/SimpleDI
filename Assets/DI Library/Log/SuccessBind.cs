using SimpleDI.Message;
using UnityEngine;

namespace SimpleDI.Log
{
    public class SuccessBind : DiLogger
    {
        public SuccessBind(string logMessage = Messages.ContractRegistered, LogType logType = LogType.Log) : base(logMessage, logType)
        {
        }
    }
}