using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
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
            logTextBox.AppendText($"log :{DateTime.UtcNow} \n {message}\n");
            logTextBox.ScrollToEnd();
        }

        private async  void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await ServerniIshgaTushir();
            }
            catch (Exception exception)
            {
               Log(exception.Message);
            }
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                await ClientIshlatish();
            }
            catch (Exception exception)
            {
                Log(exception.Message);
            }
        }

        private async Task ServerniIshgaTushir()
        {
            #region NetWorkStream Simple Example

            //// TCP Client yasaladi
            //using TcpClient tcpClient = new ();
            //var server = "www.google.com";

            //await tcpClient.ConnectAsync(server, 80); // Server bilan port beriladi client yasash uchun

            //// serverga bitta stream ochib olamiz
            //var stream = tcpClient.GetStream();

            ////requestni stringa yozib olamiz
            //var message = $"GET / HTTP/1.1\r\nHost: {server}\r\nConnection: Close\r\n\r\n";

            //await using var writer = new StreamWriter(stream);
            //// sobsheniyani serverga jo'natamiz
            //await writer.WriteAsync(message);
            //// Stream bufferni tozaliydi lekin streamni yopmiydi.
            //await writer.FlushAsync();

            //using var reader = new StreamReader(stream);

            //// server qaytargan javobni o'qib olamiz string ko'rinishida
            //var response = await reader.ReadToEndAsync();

            //Log(response);

            #endregion

            #region NetWorkStream Text bilan sihlashi

            var tcpListener = new TcpListener(IPAddress.Any, 8888);

            var words = new Dictionary<string, string>()
            {
                { "red", "qizil" },
                { "blue", "ko'k" },
                { "green", "yashil"},
                { "black", "qora"},
                { "white", "oq"},
                { "silver", "kumush rang"},
                { "yellow", "sariq"},
                { "pink", "pushti"}
            };

            try
            {
                tcpListener.Start();    // запускаем сервер
                Log("Server ishga tushirildi. Ulanishni kutyapti... ");

                while (true)
                {
                    // TcpClient orqali stream olamiz
                    using var tcpClient = await tcpListener.AcceptTcpClientAsync();
                    // NetworkStream dan obyekt yasaldi client bilan ishlash uchun
                    var stream = tcpClient.GetStream();

                    // StreamReader yasaymiz malumotlarni o'qib olsh uchun
                    using var streamReader = new StreamReader(stream);
                    // StreamWriter yasaymiz oq'ib olgan malumotlarni jo'natish uchun
                    await using var streamWriter = new StreamWriter(stream);

                    while (true)
                    {
                        // so'ralgan so'zni o'qib olamiz
                        var word = await streamReader.ReadLineAsync();

                        // Agar END so'zi kiritilgan bo'sa loopdan chiqamiz va client bilan aloqani uzamiz
                        if (word == "END") break;

                        Log($"Shu so'zni tarjimasi so'raldi :  {word}");

                        // Dictionarydan so'zni qidiramiz va clientga tarjimasini jo'natamiz
                        if (word is null || !words.TryGetValue(word, out var translation))
                            translation = "tarjima topilmadi!!!!";

                        // agar tarjima bo'sa orqaga jo'natamiz
                        await streamWriter.WriteLineAsync(translation);
                        // bufferni tozaliymiz lekin streamni yopmiymiz
                        await streamWriter.FlushAsync();
                    }
                }
            }
            finally
            {
                // serverni to'xtatadi
                tcpListener.Stop();
            }

            #endregion

        }

        record Product(string Id, string Name, string Company, int Count, decimal Price);

        #region TextClient
        private async Task ClientIshlatish()
        {
            // tarjimaga jo'natiladigan so'zlar
            var words = new[] { "red", "yellow", "blue", "white", "brown", "silver", "black", "pink", "purple" };

            using TcpClient tcpClient = new();
            await tcpClient.ConnectAsync("127.0.0.1", 8888);

            // NetworkStream yasiymiz server bilan bog'lanish uchun
            var stream = tcpClient.GetStream();

            // StreamReader malumotlarni o'qib olish uchun kerak
            using var streamReader = new StreamReader(stream);
            //StreamWriter malumotlarni jo'natish uchun kerak
            await using var streamWriter = new StreamWriter(stream);

            foreach (var word in words)
            {
                // serverga so'zni tarjima qilishga jo'natamiz
                await streamWriter.WriteLineAsync(word);
                await streamWriter.FlushAsync();

                // serverdan tarjiamni o'qib olamiz
                var translation = await streamReader.ReadLineAsync();
                Log($"{word} - {translation}");
            }
            // serverga client bilan aloqani uzush uchun signal jo'natamiz
            await streamWriter.WriteLineAsync("END");
            await streamWriter.FlushAsync();
        }

        #endregion
    }
}
