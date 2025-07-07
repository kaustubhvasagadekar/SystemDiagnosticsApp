using System.Diagnostics;

namespace SystemDiagnosticsApp.Utils
{
    public class PerformanceTracker : IDisposable
    {
        private readonly PerformanceCounter cpuCounter;
        private readonly PerformanceCounter ramCounter;
        private bool disposed = false;

        public PerformanceTracker()
        {
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            // Initial call to prime the counter
            cpuCounter.NextValue();
        }

        public float GetCpuUsage()
        {
            return cpuCounter.NextValue();
        }

        public float GetAvailableMemory()
        {
            return ramCounter.NextValue();
        }

        public void Dispose()
        {
            if (!disposed)
            {
                cpuCounter?.Dispose();
                ramCounter?.Dispose();
                disposed = true;
            }
        }
    }
}