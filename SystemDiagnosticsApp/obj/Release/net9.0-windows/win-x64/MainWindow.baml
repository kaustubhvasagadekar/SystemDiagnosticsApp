   M S B A M L   `   `   `  ���� O  KSystemDiagnosticsApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SystemDiagnosticsAppSystemDiagnosticsApp  %    SystemDiagnosticsApp.MainWindow   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     4local"clr-namespace:SystemDiagnosticsApp       � Title$  System Diagnostics App��$	��500��$	��600��.��� $��20q� � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $��* �.+��� $��0��$ ��System Performance Monitor��$��24(�$
��Bold"�$��Center=�$��0,0,0,20q��� $��1�� �� Orientation$ 
Horizontal=�$��Center=�$��0,0,0,20q�.+��� -    ��Name$ CpuLabel��$��	CPU: ---%��$��16(�$��0,0,30,0q�
����  ��� -   $ RamLabel��$��RAM: --- MB��$��16(�
��� � ��� $��2��$ 
Horizontal=�$��Center=�$��0,0,0,20q�.+��� -    ��Name$ StartMonitoringBtn��$��Start Monitoring��$	��120��$��35��$��5q��� -   $ StartETWBtn��$��Start ETW Trace��$	��120��$��35��$��5q��� -   $ 
StopETWBtn��$��Stop ETW Trace��$	��120��$��35��$��5q�${�False���� -   $ DiagnoseBtn��$��3��$ ��Generate Diagnostic Report��$	��200��$��40��$��0,0,0,20q�$��Center=��� $��4��.���� -    ��Name$ ReportTextBox�� �� 
IsReadOnly$
 True�� �� TextWrapping$
 Wrap=�" �� VerticalScrollBarVisibility$
 Auto=�$��Consolas)�$��12(����#F5F5F5