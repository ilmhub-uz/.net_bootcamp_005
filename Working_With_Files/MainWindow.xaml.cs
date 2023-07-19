using System;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
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

            //using(FileStream filestream=new FileStream(@"D:\MyFile\myfile.txt",FileMode.OpenOrCreate))
            //{
            //    string s = "ygurhjfedshkngwrilkfmdcjbknndfskljnw.k" +
            //               "hgikjrefndj5123154685ergfn" +
            //               "ger.mf";
            //    byte[] bytes=Encoding.UTF8.GetBytes(s);

            //    filestream.Write(bytes,0,bytes.Length);
            //}

            //using (StreamWriter sw = new StreamWriter(@"D:\MyFile\myfile.txt"))
            //{
            //    sw.WriteLine("filega yozamiz");
            //}

            //File.AppendAllText(@"D:\MyFile\myfile.txt", "SAmandar,fdb");


            //using var memoryStream = new MemoryStream();
            //using var someFile1 = new FileStream(@"C:\\Users\\furqa\\Desktop\\TestPapka\\windowsback1.jpg", FileMode.Open, FileAccess.Read);
            //{
            //    someFile1.CopyTo(memoryStream);

            //    using var someFile2 = new FileStream(@"C:\\Users\\furqa\\Desktop\\TestPapka\\windowsback2.jpg",
            //        FileMode.Create, FileAccess.Write);
            //    {
            //        someFile1.CopyTo(someFile2);
            //    }
            //}

            //using var memoryStream = new MemoryStream();
            //using var someFile1 = new FileStream(@"C:\\Users\\furqa\\Desktop\\TestPapka\\windowsback1.jpg", FileMode.Open, FileAccess.Read);
            //someFile1.CopyTo(memoryStream);

            //using var someFile2 = new FileStream(@"C:\\Users\\furqa\\Desktop\\TestPapka\\windowsback2.jpg",
            //    FileMode.Create, FileAccess.Write);
            //memoryStream.Seek(0, SeekOrigin.Begin); // Reset the memoryStream position to the beginning
            //memoryStream.CopyTo(someFile2);
            ////someFile1.CopyTo(someFile2); /// ishlamidi
        }

    }
}
