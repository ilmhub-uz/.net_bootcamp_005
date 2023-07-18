using System;
using System.IO;
using System.Linq;
using System.Text;
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

        private void OnLogMessageClicked(object sender, RoutedEventArgs e)
        {
            const string From = @"C:\Users\furqa\source\repos\CSharp\Working_With_Files\Working_With_Files.csproj";
            const string To = @"C:\Users\furqa\Desktop\TestPapka";

            DirectoryInfo source = new(From);
           
            var papkalar = source.GetDirectories();
            var files = source.GetFiles();

            foreach (FileInfo file in files)
            {
                string faylBoradiganJoy = Path.Combine(To, file.Name);
                using (FileStream oqiydiganStream = file.OpenRead())
                using (FileStream yozadiganStream = File.Create(faylBoradiganJoy))
                    oqiydiganStream.CopyTo(yozadiganStream);
                
                file.Delete();
            }

           
            foreach (DirectoryInfo subdirectory in papkalar)
            {
                string papkanIchidagiPapkalarBoradiganJoy = Path.Combine(To, subdirectory.Name);
                PopkaniYoz(subdirectory.FullName, papkanIchidagiPapkalarBoradiganJoy);
                subdirectory.Delete();
            }

            static void PopkaniYoz(string originalPapkaTurganJoy, string popkaYoziladiganJoy)
            {
                Directory.CreateDirectory(popkaYoziladiganJoy);

                foreach (string file in Directory.GetFiles(originalPapkaTurganJoy))
                {
                    string faylBoradiganJoy = Path.Combine("./", Path.GetFileName(file));

                    using (FileStream oqiydiganStream = File.Open(file,FileMode.OpenOrCreate))
                    using (FileStream yozadiganStream = File.Create(faylBoradiganJoy))
                                oqiydiganStream.CopyTo(yozadiganStream);

                    File.Delete(file);
                }

                foreach (string subdirectory in Directory.GetDirectories(originalPapkaTurganJoy))
                {
                    string ichidigiPopkaTuradiganJoy = Path.Combine(popkaYoziladiganJoy, Path.GetFileName(subdirectory));
                    PopkaniYoz(subdirectory, ichidigiPopkaTuradiganJoy);
                    Directory.Delete(subdirectory);
                }
            }

            LogMessage("Ishladi");

            //var file = new FileInfo(From);
            
            //var stream = file.Open(FileMode.OpenOrCreate);
            //var stream = file.Open(FileMode.Append);
            //var stream = file.Open(FileMode.Create);
            //var stream = file.Open(FileMode.Open);
            //var stream = file.Open(FileMode.CreateNew);
            //var stream = file.Open(FileMode.Truncate);

            //LogMessage($"{file.Name} {file.CreationTime}");

            //var malumot2 = "salom";

            //var bytes = Encoding.UTF8.GetBytes(malumot2);

            //stream.Write(bytes,0,bytes.Length);
            ////stream.Close();
            //stream.Dispose();

            //LogMessage("Faylga malumot yozildi.");

            //File.AppendAllLines(From,malumot.Split("//"));
            ////File.WriteAllBytes(To,bytes);
            ////File.Copy(From,To);
            //LogMessage("Ishladi");

        }


    }
}
