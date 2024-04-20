using System.Configuration;

namespace SearchNow.src.objects
{
    public class Logger
    {
        public static void WriteLog(string message, bool error)
        {
            string logMessage = string.Empty;
            if (!error)
            {
                logMessage = $"LOG [{DateTime.Now}]: {message}\n";

            }
            else
            {
                logMessage = $"ERROR [{DateTime.Now}]: {message}\n";
            }

            File.AppendAllText(ConfigurationManager.AppSettings["LogFilePath"], logMessage);
        }

        
    }
}
