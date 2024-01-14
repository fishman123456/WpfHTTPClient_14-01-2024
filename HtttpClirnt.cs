using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfHTTPClient_14_01_2024
{
    public  class HtttpClint
    {
        public  string messageAPI { get; set; }
        public   string  httpClient()
        {
            HttpMessageHandler handler = new HttpClientHandler();
            MessageBox.Show("Приложение начало работу");

            using (var client = new HttpClient(handler, false))
            {
                using var result = client.GetAsync("https://google.com");
                MessageBoxResult messageBoxResult = MessageBox.Show(result.Result.ToString());
                messageAPI = result.Status.ToString();
            }
            MessageBox.Show("Приложение завершило работу");
            return messageAPI;
        }
    }
}
