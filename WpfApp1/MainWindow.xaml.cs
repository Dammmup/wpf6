using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Security.Policy;
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
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string key = "ObxELfFr164BicsLjQI4hA==PtuJSMqFfpFZtPrr";
        public MainWindow()
        {
            InitializeComponent();
            img.Source = new BitmapImage(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSc8L75nL48MTzvkkQ32xKx6kdlf_c1qdJznw&usqp=CAU"));
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string url= "https://www.boredapi.com/api/activity";
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(url);
                    if(response != null)
                    {
                        var jsonstring = await response.Content.ReadAsStringAsync();
                        ActivityResponse res = JsonConvert.DeserializeObject<ActivityResponse>(jsonstring);
                        MessageBox.Show(res.Activity);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                string txt = tb.Text;
                string url = "https://api.api-ninjas.com/v1/animals?name=" + txt;
                using(HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("X-Api-Key", key);
                    var response = await client.GetAsync(url);
                    if(response != null)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        List<ApiNinjaAnimal> res = JsonConvert.DeserializeObject<List<ApiNinjaAnimal>>(jsonString);
                        MessageBox.Show(res.First().Name );
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        public class WeatherData
        {
            [JsonProperty("name")]
            public string Name { get; set; }
            public MainData Main { get; set; }
            public List<Weather> Weather { get; set; }
        }

        public class MainData
        {
            public double Temp { get; set; }
        }

        public class Weather
        {
            public string Main { get; set; }
            public string Icon { get; set; }
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double shir = double.Parse(lat.Text);
            double dol = double.Parse(len.Text);
            string url = "https://api.openweathermap.org/data/2.5/weather?lat=" + shir + "&lon=" + dol + "&appid=99b8bddba48b08ad938fecc4a018546b";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);

                try
                {

                    string result = await response.Content.ReadAsStringAsync();
                    WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(result);

                    string city = weatherData.Name;
                    double temp = weatherData.Main.Temp;
                    string weather = weatherData.Weather[0].Main;
                    string iconUrl = "http://openweathermap.org/img/w/" + weatherData.Weather[0].Icon + ".png";

                    cityName.Text = "Город: " + city;
                    temperature.Text = "Температура: " + temp.ToString() + "°C";
                    weatherDesc.Text = "Погода: " + weather;
                    img1.Source = new BitmapImage(new Uri(iconUrl));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
              
            }
        }
    }
}
