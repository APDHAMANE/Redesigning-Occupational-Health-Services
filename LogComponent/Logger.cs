using log4net;
using System;

namespace LogComponent {
    public static class Logger {
        //Constants.
        const string debugTask = "Debug_Task";
        const string errorTask = "Error_Task";

        //Static Fields.
        static ILog debugLogger;
        static ILog errorLogger;

        //Constructor.
        static Logger() {
            debugLogger = LogManager.GetLogger(debugTask);
            errorLogger = LogManager.GetLogger(errorTask);
        }

        //Static Methods.
        public static void Debug(object message, Exception exception) {
            debugLogger.Debug(message, exception);
        }

        public static void Error(object message, Exception exception) {
            errorLogger.Error(message, exception);
        }

        public static void Warning(object message, Exception exception) {
        }

        public static void Info(object message, Exception exception) {
        }

        public static void Fatal(object message, Exception exception) {
        }
    }
}