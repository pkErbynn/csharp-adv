using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace async_await_with_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //DownloadHtmlAsync("https://turntabl.io/");
            var html = await GetHtmlAsync("https://turntabl.io/");
            MessageBox.Show(html.Substring(0, 10));
        }

        //public void DownloadHtml(string url)
        //{
        //    var webClient = new WebClient();
        //    var html = webClient.DownloadString(url);

        //    using(var streamWriter = new StreamWriter(@"C:\Users\Mr. Erbynn\source\repos\learn\result.html"))
        //    {
        //        streamWriter.Write(html);
               
        //    }
        //}

        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadDataTaskAsync(url);

            using (var streamWriter = new StreamWriter(@"C:\Users\Mr. Erbynn\source\repos\learn\result.html"))
            {
                await streamWriter.WriteAsync(html.ToString());
            }
        }

        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync(url);
        }
    }
}
