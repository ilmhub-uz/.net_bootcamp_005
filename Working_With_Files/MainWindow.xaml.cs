using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
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
            logTextBox.AppendText(message + Environment.NewLine);
            logTextBox.ScrollToEnd();
        }

        private void EncryptButton_Click(object sender, RoutedEventArgs e)
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
       
            string textToEncrypt = InputTextBox.Text;
            string encryptedText = Encrypt(textToEncrypt);
            Log(encryptedText);
        }

        private void DecryptButton_Click(object sender, RoutedEventArgs e)
        {
            string encryptedText = logTextBox.Text;
            string decryptedText = Decrypt(encryptedText);
            Log(decryptedText);
        }

        private string Encrypt(string oddiyText)
        {
            // Bu ikkalasi encrypt qilingan data bilan IV ni saqlash uchun kerak
            // IV haqida to'liq malumot quyidagi silkada https://cybr.com/certifications-archives/initialization-vector-iv-attacks-with-wep-comptia-security/
            byte[] encryptedBytes;
            byte[] iv;

            // Advanced Encryption Standard digan base clasdan object yasaladi
            // AES uchun quyidagi linkaga o'ting https://www.simplilearn.com/tutorials/cryptography-tutorial/aes-encryption
            using (Aes aes = Aes.Create())
            {
                // UTF 8 bo'yicha encode qilingan kalit yasaldi bu kalit shifrlashda kere bo'ladi
                aes.Key = Encoding.UTF8.GetBytes("Assalomu Alaykum"); 
                // random generatisya qilingan raqamalar shifrlashda ishlatiladi va xavfsizlikni oshiradi.
                iv = aes.IV;
                // Memory stream malumotni vaqtinchalik saqlash uchun kerak.
                using MemoryStream memoryStream = new();
                // CryptoStream shifrlash protsesini boshqarib o'zida ushlab turadi.
                using CryptoStream cryptoStream = new(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write);

                // kirib kegan stringdan byte larini ovolamiz
                byte[] oddiyTexniBayti = Encoding.UTF8.GetBytes(oddiyText);

                // Streamga encrypt qilingan stringni bytelarini yozadi
                cryptoStream.Write(oddiyTexniBayti, 0, oddiyTexniBayti.Length);
                // Stream bufferidigi oxirgi malumotlani tozalab tashiydi
                cryptoStream.FlushFinalBlock();
                // Shifrlangan bytelani arrayga copya qivoladi.
                encryptedBytes = memoryStream.ToArray();
            }

            // Yengi array kere encrypt qilingan array + random arrayi ko'piya qivolishga
            byte[] combinedBytes = new byte[iv.Length + encryptedBytes.Length];
            // Random arrayi kopiya qiladi
            Array.Copy(iv, 0, combinedBytes, 0, iv.Length);
            // encrypt qilingan arrayni kopiya qiladi
            Array.Copy(encryptedBytes, 0, combinedBytes, iv.Length, encryptedBytes.Length);
            // Rezultati Base string 64 da qaytariladi yanada havfsiz bo'lishi uchun
            return Convert.ToBase64String(combinedBytes);
        }

        private string Decrypt(string encryptedText)
        {
            // Shifrlangan datani bytelarini beradi .
            byte[] combinedBytes = Convert.FromBase64String(encryptedText);

            // 128 bit 16 byte dan oshiymidi IV ni qiymati.
            byte[] iv = new byte[16];
            // encrypt qilingan datani uzunligini topish uchun kere 
            byte[] encryptedBytes = new byte[combinedBytes.Length - iv.Length];

            // combinatsiya qilingan datadan 16 tali random arrayi oladi
            Array.Copy(combinedBytes, 0, iv, 0, iv.Length);

            // combinatsiya qilingan datadan encrpted byte lani ko'chirib oladi
            Array.Copy(combinedBytes, iv.Length, encryptedBytes, 0, encryptedBytes.Length);

            // decrypt uchun aes object kere.
            using Aes aes = Aes.Create();

            // shu kalit bo'masa decryption o'xshamiydi exception beradi
            aes.Key = Encoding.UTF8.GetBytes("Assalomu Alaykum"); 

            // random byte array ni aes IV siga beramiz
            aes.IV = iv;

            // vaqtinchalik hotirada saqlash uchun kere bu memory stream.
            using MemoryStream memoryStream = new();
            // decrypt qilish protsesini aes obyekti orqali qiladi.
            using (CryptoStream cryptoStream = new(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write))
            {
                // streamga yozadi
                cryptoStream.Write(encryptedBytes, 0, encryptedBytes.Length);
                cryptoStream.FlushFinalBlock();
            }
            // byte array dan stringa parse qiladi
            return Encoding.UTF8.GetString(memoryStream.ToArray());
        }
    }
}
