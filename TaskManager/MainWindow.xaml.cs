using System;
using System.Diagnostics;
using System.Windows;

namespace TaskManager
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            taskManager.ItemsSource = Process.GetProcesses();
        }

        private void ButtonKillClick(object sender, RoutedEventArgs e)
        {
            foreach (var processTaskManager in Process.GetProcesses())
            {
                if ((taskManager.SelectedItem as Process).Id == processTaskManager.Id)
                {
                    try
                    {
                        processTaskManager.Kill();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Нет Доступа, не хватает прав");
                    }                   
                }
            }
        }
    }
}
