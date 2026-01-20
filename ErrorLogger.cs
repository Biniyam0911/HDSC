using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onana_Hospital_Management_System
{
    public static class ErrorLogger
    {
        private static readonly string logDir =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");

        public static void Log(
            string reference,        // could be Invoice No or Item Code
            string message,
            string requestText = null,
            string responseText = null)
        {
            try
            {
                if (!Directory.Exists(logDir))
                    Directory.CreateDirectory(logDir);

                string filePath = Path.Combine(
                    logDir,
                    $"ERPNext_Error_{DateTime.Today:yyyyMMdd}.log"
                );

                var sb = new StringBuilder();
                sb.AppendLine("=======================================");
                sb.AppendLine($"Date       : {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                sb.AppendLine($"Reference  : {reference}");  // <-- generic
                sb.AppendLine($"Message    : {message}");

                if (!string.IsNullOrEmpty(requestText))
                {
                    sb.AppendLine("----- REQUEST -----");
                    sb.AppendLine(requestText);
                }

                if (!string.IsNullOrEmpty(responseText))
                {
                    sb.AppendLine("----- RESPONSE -----");
                    sb.AppendLine(responseText);
                }

                sb.AppendLine();

                File.AppendAllText(filePath, sb.ToString());
            }
            catch
            {
                // NEVER throw from logger
            }
        }
    }

}
