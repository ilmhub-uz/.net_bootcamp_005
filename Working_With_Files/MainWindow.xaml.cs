using System;
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
            logTextBox.AppendText(message);
            logTextBox.LineDown();
            logTextBox.ScrollToEnd();
        }

        private void EncryptButton_Click(object sender, RoutedEventArgs e)
        {
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

        private string Encrypt(string plainText)
        {
            byte[] encryptedBytes;
            byte[] iv;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes("Assalomu Alaykum"); // shifrlash uchun kalit so'zi
                iv = aes.IV;

                using MemoryStream memoryStream = new();
                using CryptoStream cryptoStream = new(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
                byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                cryptoStream.FlushFinalBlock();
                encryptedBytes = memoryStream.ToArray();
            }

            byte[] combinedBytes = new byte[iv.Length + encryptedBytes.Length];
            Array.Copy(iv, 0, combinedBytes, 0, iv.Length);
            Array.Copy(encryptedBytes, 0, combinedBytes, iv.Length, encryptedBytes.Length);

            return Convert.ToBase64String(combinedBytes);
        }

        private string Decrypt(string encryptedText)
        {
            byte[] combinedBytes = Convert.FromBase64String(encryptedText);

            byte[] iv = new byte[16];
            byte[] encryptedBytes = new byte[combinedBytes.Length - iv.Length];
            Array.Copy(combinedBytes, 0, iv, 0, iv.Length);
            Array.Copy(combinedBytes, iv.Length, encryptedBytes, 0, encryptedBytes.Length);

            using Aes aes = Aes.Create();
            aes.Key = Encoding.UTF8.GetBytes("Assalomu Alaykum"); // Shifr kalit so'zi kerak bo'ladi
            aes.IV = iv;

            using MemoryStream memoryStream = new();
            using (CryptoStream cryptoStream = new(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write))
            {
                cryptoStream.Write(encryptedBytes, 0, encryptedBytes.Length);
                cryptoStream.FlushFinalBlock();
            }
            string decryptedText = Encoding.UTF8.GetString(memoryStream.ToArray());

            return decryptedText;
        }
    }
}
