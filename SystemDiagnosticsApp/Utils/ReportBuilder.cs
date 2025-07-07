using System.Text;

namespace SystemDiagnosticsApp.Utils
{
    public static class ReportBuilder
    {
        public static string Analyze(float cpu, float availableMemory)
        {
            var report = new StringBuilder();
            report.AppendLine("=== System Diagnostic Report ===");
            report.AppendLine($"Timestamp: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            report.AppendLine($"CPU Usage: {cpu:F1}%");
            report.AppendLine($"Available Memory: {availableMemory:F0} MB");
            report.AppendLine();

            // Analysis
            report.AppendLine("=== Analysis ===");
            if (cpu > 80)
            {
                report.AppendLine("⚠️ HIGH CPU USAGE detected - likely causing system slowdown/freeze");
                report.AppendLine("Recommendation: Check Task Manager for high CPU processes");
            }
            else if (cpu > 50)
            {
                report.AppendLine("⚠️ MODERATE CPU USAGE detected");
            }
            else
            {
                report.AppendLine("✅ CPU usage is normal");
            }

            if (availableMemory < 200)
            {
                report.AppendLine("⚠️ LOW MEMORY available - may cause application freezes");
                report.AppendLine("Recommendation: Close unnecessary applications or add more RAM");
            }
            else if (availableMemory < 500)
            {
                report.AppendLine("⚠️ MODERATE memory pressure detected");
            }
            else
            {
                report.AppendLine("✅ Memory availability is good");
            }

            if (cpu <= 50 && availableMemory >= 500)
            {
                report.AppendLine("✅ System appears to be running normally");
                report.AppendLine("If experiencing freezes, consider checking disk I/O or specific application issues");
            }

            return report.ToString();
        }
    }
}