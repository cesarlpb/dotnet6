using Serilog;
using System;
using System.IO;

namespace Logger
{
    public static class FileLogger
    {
        private const string FilePath = "log.txt";
        public static void Log(string mensaje)
        {
            using var fileStream = new FileStream(FilePath, FileMode.Append);
            using var writer = new StreamWriter(fileStream);
                writer.WriteLine(mensaje);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger.Log("Nuevo mensaje");
            var logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();

            logger.Verbose("ejemplo");
            logger.Error("error aqui");
            logger.Fatal("fatal");
        }
    }
}
