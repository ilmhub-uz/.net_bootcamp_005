using System;
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


        private void Log(string message)
        {
            logTextBox.AppendText($"Bu loggerdan Habar:{DateTime.UtcNow} \n {message}" 
                                  + Environment.NewLine);

            logTextBox.ScrollToEnd();
        }

        private void OnLogMessageClicked(object sender, RoutedEventArgs e)
        {
            //const string From = @"C:\Rasmlar";
            //const string To = @"C:\Users\furqa\Desktop\TestPapka\Test2.txt";
            ////const string filePath = @"C:\Users\furqa\OneDrive\Рабочий стол\TestPapka\Test.txt";
            ////const string filePath2 = @"C:\Users\furqa\OneDrive\Рабочий стол\TestPapka\Test2.txt";

            //var stream = new FileStream(To,FileMode.Open);
            //byte[] buffer = new byte[stream.Length];
            ////var malumot = @"// Directoridan foydalanish
            //////if (Directory.Exists(path)) LogMessage(""Papka bor."");
            //////else
            //////{
            //////    Directory.CreateDirectory(path);
            //////    LogMessage(""Papka yaratildi."");
            //////}

            //int read = stream.Read(buffer, 0, buffer.Length);
            //// Papka haqidagi malumotlarni olamiz

            ////LogMessage(""Directory Name: "" + directoryInfo.Name);
            ////LogMessage(""Full Path: "" + directoryInfo.FullName);
            ////LogMessage(""Parent Directory: "" + directoryInfo.Parent);
            ////LogMessage(""Creation Time: "" + directoryInfo.CreationTime);
            ////LogMessage(""Last Write Time: "" + directoryInfo.LastWriteTime);
            ////LogMessage(""Last Access Time: "" + directoryInfo.LastAccessTime);
            ////Directory.SetLastAccessTime(path,new DateTime(2023,6,30));
            ////LogMessage($"" Oxirgi kirilgan vaqti static classdan : {Directory.GetLastAccessTime(path)}"");

            ////directoryInfo.CreateSubdirectory(""videocha\\kinocha"");
            ////LogMessage($""yangi papkacha ochildi"");

            ////foreach (var sub in directoryInfo.GetDirectories())
            ////{
            ////    LogMessage($""Sub : {sub.Name}"");
            ////}

            ////foreach (var file in directoryInfo.GetFiles())
            ////{
            ////    LogMessage($""{file.Name} {file.Extension} {file.CreationTimeUtc}"");
            ////}

            ////foreach (var sub in Directory.GetDirectories(path))
            ////{
            ////    LogMessage(sub);
            ////}

            ////foreach (var file in Directory.GetFiles(path))
            ////{
            ////    LogMessage(file);
            ////}

            ////string newPath = @""C:\Example"";
            ////if (Directory.Exists(path))
            ////{
            ////    _counter++;
            ////    Directory.Move(newPath,$""{path}{_counter}"");
            ////}
                
            ////LogMessage(""Papka yangi joyga ko'chirildi"");

            ////directoryInfo.Delete();
            ////Log($""Papka o'chirildi"");

            ////Directory.Delete(path);
            ////Log(""Papka Topilmadi"");";

            //var file = new FileInfo(filePath);

            // ---------------------------File Write Alltext bilan yasash -------------------------------------------------//

            // Yangi Fayl yasab unga Text ko'rinishida malumotlarni yozadi agar fayl uja bo'sa uni qaytadan yozvoradi

            //File.WriteAllText(filePath,malumot);
            //Log("Text Fayl Wrtie AllText Orqali yasaldi");

            //--------------------------------File AppendAllText ---------------------------------------------------------//

            // Yangi Fayl yasab unga Text ko'rinishida malumotlarni yozadi agar fayl uja bo'sa uni davomiga yozvoradi
            //File.AppendAllText(filePath, malumot + Environment.NewLine);
            //Log("Text Fayl Append AllText Orqali yasaldi");

            //// ---------------------------File Create Methodi Orqali --------------------------------------------------//

            //FileStream fileStream = File.Create(filePath);
            //fileStream.Close(); // Fayl Streamni yopadi va resurslarni tozalaydi.
            //fileStream.Dispose(); // Fayl Streamni barcha resurslarini tozalab beradi.

            //Log("Text Fayl Create Methodi bilan yasaldi");

            //// ------------------------------File Write All Bytes orqali ----------------------------------------------------// 

            //string filePath2 = @"C:\Users\furqa\OneDrive\Рабочий стол\TestPapka\example.bin";
            //byte[] data = { 0x48, 0x65, 0x6C, 0x6C, 0x6F }; // "Hello" in ASCII bytes

            //// Yangi Fayl yasab unga byte ko'rinishida malumotlarni yozadi agar fayl uja bo'sa uni qaytadan yozvoradi
            //File.WriteAllBytes(filePath2, data);

            //Log($"Byte File yasaldi {DateTime.Now}");

            //LogMessage(Encoding.UTF8.GetString(buffer));
            
            
            // -------------------------------Move to Methodi original faylni boshqa joyga ko'chiradi eskisini udalit qiladi ----------------------//
            //file.MoveTo(filePath);
            //Log("Fayl joyi o'zgartirildi");

            // ------------------------------------Copy to methodi ------------------------------------------------------------------------------//
            //if (!File.Exists(filePath2))
            //{
            //    file.CopyTo(filePath2);
            //    Log("Kopiya fayl yasaldi");
            //}
            //else
            //{
            //    using var stream = file.AppendText();
            //    stream.WriteLine("Fayl uja bor ekan undan kopiy aolib bo'lmaydi");
            //    Log("Fayl o'zgartitildi");
            //}

            

            // ------------------------------------------------------------- FileStream Bilan Ishlash -----------------------------------------------------------------//

            //----------------------------File Modes tushuntirilgan --------------------------------//

            // var stream  = file.Open(FileMode.Create); // Har Safar faylni ichini o'chirib yenginarsa yozadi.
            // var stream = file.Open(FileMode.CreateNew); // Har Safar yangi fayl yozishga hrakat qiladi agar fayl bosa Exception otadi.
            // var stream = file.Open(FileMode.OpenOrCreate); // Fayl oldindan bo'sa ochadi bo'masa yengi yasiydi.
            // var stream = file.Open(FileMode.Truncate); // Bor faylli ochadi va uni ichini tozalab tashiydi 
            // var stream = file.Open(FileMode.Append); //Fayl bor bo'sa ochib ichiga malumotni ochirmasdan davomiga yozib ketadi.



            //DirectoryInfo source = new(From);

            //var papkalar = source.GetDirectories();
            //var files = source.GetFiles();

            //foreach (FileInfo file in files)
            //{
            //    string faylBoradiganJoy = Path.Combine(To, file.Name);
            //    using (FileStream oqiydiganStream = file.OpenRead())
            //    using (FileStream yozadiganStream = File.Create(faylBoradiganJoy))
            //        oqiydiganStream.CopyTo(yozadiganStream);

            //    file.Delete();
            //}
            // var bytes = Encoding.UTF8.GetBytes(malumot);


            //foreach (DirectoryInfo subdirectory in papkalar)
            //{
            //    string papkanIchidagiPapkalarBoradiganJoy = Path.Combine(To, subdirectory.Name);
            //    PopkaniYoz(subdirectory.FullName, papkanIchidagiPapkalarBoradiganJoy);
            //    subdirectory.Delete();
            //}
            //stream.Write(bytes, 0, bytes.Length);
            //stream.Close();
            //Log("Fayl yasaldi");

            //static void PopkaniYoz(string originalPapkaTurganJoy, string popkaYoziladiganJoy)
            //{
            //    Directory.CreateDirectory(popkaYoziladiganJoy);

            //    foreach (string file in Directory.GetFiles(originalPapkaTurganJoy))
            //    {
            //        string faylBoradiganJoy = Path.Combine(To, Path.GetFileName(file));

            //        using (FileStream oqiydiganStream = File.Open(file,FileMode.OpenOrCreate))
            //        using (FileStream yozadiganStream = File.Create(faylBoradiganJoy))
            //                    oqiydiganStream.CopyTo(yozadiganStream);

            //        File.Delete(file);
            //    }

            //    foreach (string subdirectory in Directory.GetDirectories(originalPapkaTurganJoy))
            //    {
            //        string ichidigiPopkaTuradiganJoy = Path.Combine(popkaYoziladiganJoy, Path.GetFileName(subdirectory));
            //        PopkaniYoz(subdirectory, ichidigiPopkaTuradiganJoy);
            //        Directory.Delete(subdirectory);
            //    }
            //}
            //----------------------------Faylarni ko'chirildi --------------------------------------------------------------//
            //var faylPath = @"C:\Users\furqa\OneDrive\Изображения\Снимки экрана";
            //var adressToMove = @"C:\Users\furqa\OneDrive\Рабочий стол\TestPapka";

            //LogMessage("Ishladi");

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
            //var files = new DirectoryInfo(faylPath).GetFiles();

            //stream.Write(bytes,0,bytes.Length);
            ////stream.Close();
            //stream.Dispose();

            //LogMessage("Faylga malumot yozildi.");
            //if (Directory.Exists(faylPath))
            //{
            //    foreach (var rasm in files)
            //    {
            //        rasm.MoveTo($@"{adressToMove}\{rasm.Name}");
            //        Log("rasm ko'chirildi");
            //    }
            //}

            // ------------------------------------------------------------------ Memory Stream --------------------------------------------------------------------//

            //File.AppendAllLines(From,malumot.Split("//"));
            ////File.WriteAllBytes(To,bytes);
            ////File.Copy(From,To);
            //LogMessage("Ishladi");
            //using MemoryStream memoryStream = new ();
            //byte[] bytes = System.Text.Encoding.UTF8.GetBytes(malumot);
            //memoryStream.Write(bytes, 0, bytes.Length);

        }
            //byte[] buffer = memoryStream.ToArray();
            //string memoryContent = System.Text.Encoding.UTF8.GetString(buffer);
            //Log("Memory Contents:");
            //Log(memoryContent);
    }
}




