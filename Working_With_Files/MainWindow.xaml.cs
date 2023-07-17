using System;
using System.IO;
using System.Windows;

namespace Working_With_Files
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void LogMessage(string message)
        {
            logTextBox.AppendText($"Bu loggerdan Habar:{DateTime.UtcNow} \n {message}" 
                                  + Environment.NewLine);

            logTextBox.ScrollToEnd();
        }

        private static int _counter = 0;

        private void OnLogMessageClicked(object sender, RoutedEventArgs e)
        {

            //Bizga ishlashimiz uchun Papka kerak bo'ladi
            const  string path = @"C:\Users\furqa\Desktop\YangiPapka";

            //DirectoryInfo Classdan obyekt yasaladi.
            DirectoryInfo directoryInfo = new(path);

            // Papkani bor yo'qligini tekshirib olamiz
            if (directoryInfo.Exists)
            {
                LogMessage("Papka topildi.");
            }
            else
            {
                directoryInfo.Create();
                LogMessage("Papka Yaratildi.");
            }

            // Directoridan foydalanish
            //if (Directory.Exists(path)) LogMessage("Papka bor.");
            //else
            //{
            //    Directory.CreateDirectory(path);
            //    LogMessage("Papka yaratildi.");
            //}

            // Papka haqidagi malumotlarni olamiz

            //LogMessage("Directory Name: " + directoryInfo.Name);
            //LogMessage("Full Path: " + directoryInfo.FullName);
            //LogMessage("Parent Directory: " + directoryInfo.Parent);
            //LogMessage("Creation Time: " + directoryInfo.CreationTime);
            //LogMessage("Last Write Time: " + directoryInfo.LastWriteTime);
            //LogMessage("Last Access Time: " + directoryInfo.LastAccessTime);
            //Directory.SetLastAccessTime(path,new DateTime(2023,6,30));
            //LogMessage($" Oxirgi kirilgan vaqti static classdan : {Directory.GetLastAccessTime(path)}");

            //directoryInfo.CreateSubdirectory("videocha\\kinocha");
            //LogMessage($"yangi papkacha ochildi");

            //foreach (var sub in directoryInfo.GetDirectories())
            //{
            //    LogMessage($"Sub : {sub.Name}");
            //}

            //foreach (var file in directoryInfo.GetFiles())
            //{
            //    LogMessage($"{file.Name} {file.Extension} {file.CreationTimeUtc}");
            //}

            //foreach (var sub in Directory.GetDirectories(path))
            //{
            //    LogMessage(sub);
            //}

            //foreach (var file in Directory.GetFiles(path))
            //{
            //    LogMessage(file);
            //}

            string newPath = @"C:\Example";
            if (Directory.Exists(path))
            {
                _counter++;
                Directory.Move(newPath,$"{path}{_counter}");
            }
                
            LogMessage("Papka yangi joyga ko'chirildi");



        }

    }
}
