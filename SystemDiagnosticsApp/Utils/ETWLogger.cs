using System.Diagnostics;

namespace SystemDiagnosticsApp.Utils
{
    public static class ETWLogger
    {
        public static void StartTrace()
        {
            try
            {
                using var process = Process.Start(new ProcessStartInfo
                {
                    FileName = "wpr.exe",
                    Arguments = "-start CPU -filemode",
                    UseShellExecute = false,
                    CreateNoWindow = true
                });
                process?.WaitForExit();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to start ETW trace: {ex.Message}");
            }
        }

        public static void StopTrace(string outputFile)
        {
            try
            {
                using var process = Process.Start(new ProcessStartInfo
                {
                    FileName = "wpr.exe",
                    Arguments = $"-stop {outputFile}",
                    UseShellExecute = false,
                    CreateNoWindow = true
                });
                process?.WaitForExit();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to stop ETW trace: {ex.Message}");
            }
        }
    }
}