using System.Configuration;
using System.Diagnostics;
using System.IO;

namespace SearchNow.src.objects
{
    /// <summary>
    /// The Logger class provides a static method to write log messages to a file.
    /// </summary>
    public class Logger
    {
        /// <summary>
        /// Writes a log message to a file. The file path is read from the App.config file.
        /// If the file does not exist, it will be created. If it does exist, the log message will be appended to the file.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        /// <param name="error">If true, the message is logged as an error; otherwise, it is logged as information.</param>
        public static void WriteLog(string message, bool error)
        {
            // Read the log file path from the App.config file
            string logFilePath = ConfigurationManager.AppSettings["logFilePath"];

            try
            {
                // Check if the log file path is not null or empty
                if (!string.IsNullOrEmpty(logFilePath))
                {
                    // If the error parameter is true, log the message as an error
                    if (error == true)
                    {
                        string logMessage = $"ERROR :  [{DateTime.Now}]: {message}\n";
                        using (StreamWriter writer = new StreamWriter(logFilePath, true))
                        {
                            writer.WriteLine(logMessage);
                        }
                    }
                    // Otherwise, log the message as information
                    else
                    {
                        string logMessage = $"LOG : [{DateTime.Now}]: {message}\n";
                        using (StreamWriter writer = new StreamWriter(logFilePath, true))
                        {
                            writer.WriteLine(logMessage);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // If an exception occurs, log the exception message as an error
                WriteLog(ex.Message, error);
            }
        }
    }
}
