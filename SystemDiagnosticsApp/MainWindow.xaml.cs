using System.IO;
using System.Windows;
using System.Windows.Threading;
using SystemDiagnosticsApp.Utils;

namespace SystemDiagnosticsApp;

public partial class MainWindow : Window
{
    private DispatcherTimer? timer;
    private PerformanceTracker? tracker;


    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnStartMonitoringClick(object sender, RoutedEventArgs e)
    {
        if (timer?.IsEnabled == true)
        {
            timer.Stop();
            StartMonitoringBtn.Content = "Start Monitoring";
            tracker?.Dispose();
            return;
        }

        try
        {
            tracker = new PerformanceTracker();
            timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            
            timer.Tick += (s, e) =>
            {
                var cpu = tracker.GetCpuUsage();
                var mem = tracker.GetAvailableMemory();
                CpuLabel.Content = $"CPU: {cpu:F1}%";
                RamLabel.Content = $"RAM: {mem:F0} MB";
            };
            
            timer.Start();
            StartMonitoringBtn.Content = "Stop Monitoring";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error starting monitoring: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void OnStartETWClick(object sender, RoutedEventArgs e)
    {
        try
        {
            ETWLogger.StartTrace();

            StartETWBtn.IsEnabled = false;
            StopETWBtn.IsEnabled = true;
            MessageBox.Show("ETW trace started successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error starting ETW trace: {ex.Message}\n\nMake sure Windows Performance Toolkit is installed and run as Administrator.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void OnStopETWClick(object sender, RoutedEventArgs e)
    {
        try
        {
            string outputFile = Path.Combine(Environment.CurrentDirectory, "trace.etl");
            ETWLogger.StopTrace(outputFile);

            StartETWBtn.IsEnabled = true;
            StopETWBtn.IsEnabled = false;
            MessageBox.Show($"ETW trace saved to: {outputFile}", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error stopping ETW trace: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void OnDiagnoseClick(object sender, RoutedEventArgs e)
    {
        try
        {
            if (tracker == null)
            {
                MessageBox.Show("Please start monitoring first to collect performance data.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var cpu = tracker.GetCpuUsage();
            var mem = tracker.GetAvailableMemory();
            var report = ReportBuilder.Analyze(cpu, mem);
            
            ReportTextBox.Text = report;
            
            string reportFile = Path.Combine(Environment.CurrentDirectory, "diagnostic_report.txt");
            File.WriteAllText(reportFile, report);
            
            MessageBox.Show($"Diagnostic report generated and saved to: {reportFile}", "Report Generated", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error generating report: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    protected override void OnClosed(EventArgs e)
    {
        timer?.Stop();
        tracker?.Dispose();
        base.OnClosed(e);
    }
}