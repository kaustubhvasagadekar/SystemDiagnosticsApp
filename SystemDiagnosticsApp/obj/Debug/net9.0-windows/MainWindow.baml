   M S B A M L   `   `   `  ����O  KSystemDiagnosticsApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SystemDiagnosticsAppSystemDiagnosticsApp  5   	   %    SystemDiagnosticsApp.MainWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:SystemDiagnosticsApp     5   	     � Title$  System Diagnostics App��5   	   $	��500��6(   $	��600��65   .��5	      � $��20q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $ ��System Performance Monitor��6!   $��24(�6C   $
��Bold"�6Q   $��Center=�6c   $��0,0,0,20q�6�   �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $��0,0,0,20q�6X   .+�5      �� -   5         ��Name$ CpuLabel��5      $��	CPU: ---%��6&   $��16(�6:   $��0,0,30,0q�6H   
����  �6Z   �� 5      -   5        $ RamLabel��5      $��RAM: --- MB��6&   $��16(�6<   
��� � �6J   5      �� 5   
   $��2��6   $ 
Horizontal=�6"   $��Center=�6;   $��0,0,0,20q�6X   .+�5      �� -   5         ��Name$ StartMonitoringBtn��5      $��Start Monitoring��61   $	��120��6L   $��35��6X   $��5q�6d   6o   �� 5      -   5        $ StartETWBtn��5      $��Start ETW Trace��6*   $	��120��6D   $��35��6P   $��5q�6\   6g   �� 5      -   5        $ 
StopETWBtn��5      $��Stop ETW Trace��6)   $	��120��6B   $��35��6N   $��5q�6Z   ${�False��6|   5       �� 5"   
   -   5        $ DiagnoseBtn��5"      $��3��6   $ ��Generate Diagnostic Report��63   $	��200��6X   $��40��6d   $��0,0,0,20q�6p   $��Center=�6�   �� 5%   
   $��4��6   .��5&      �� -   5         ��Name$ ReportTextBox��5&       �� 
IsReadOnly$
 True��6-    �� TextWrapping$
 Wrap=�6?   " �� VerticalScrollBarVisibility$
 Auto=�6S   $��Consolas)�6v   $��12(�6�   ���#F5F5F56�   5'      5(      5)      