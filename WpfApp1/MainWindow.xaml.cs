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
        private string key = "wYLZJ6LIQ+eLJy+nBWKjUw==cQl9W74cLT2QvmoT";
        public MainWindow()
        {
            InitializeComponent();
           
        }
        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                string countryName = tb.Text;
                string url = $"https://api.api-ninjas.com/v1/country?name={countryName}";

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("X-Api-Key", key);

                    var response = await client.GetAsync(url);

                    if (response != null)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();

                        // Используйте List<CountryInfo> для десериализации массива объектов
                        List<CountryInfo> countryInfoList = JsonConvert.DeserializeObject<List<CountryInfo>>(jsonString);

                        if (countryInfoList.Count > 0)
                        {
                            // Выводим результаты на элементы XAML (в примере берется первый элемент из списка)
                            cityName.Text = $"Страна: {countryInfoList[0].Name}";
                            temperature.Text = $"Столица: {countryInfoList[0].Capital}";
                        }
                        else
                        {
                            MessageBox.Show("Страна не найдена");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

     

        public class CountryInfo
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("capital")]
            public string Capital { get; set; }

            // Добавьте другие свойства в соответствии с тем, что возвращает API о стране
        }
        public partial class Welcome
        {
            public long Gdp { get; set; }
            public double SexRatio { get; set; }
            public long SurfaceArea { get; set; }
            public double LifeExpectancyMale { get; set; }
            public double Unemployment { get; set; }
            public long Imports { get; set; }
            public double HomicideRate { get; set; }
            public Currency Currency { get; set; }
            public string Iso2 { get; set; }
            public double EmploymentServices { get; set; }
            public double EmploymentIndustry { get; set; }
            public double UrbanPopulationGrowth { get; set; }
            public double SecondarySchoolEnrollmentFemale { get; set; }
            public double EmploymentAgriculture { get; set; }
            public string Capital { get; set; }
            public double Co2Emissions { get; set; }
            public double ForestedArea { get; set; }
            public long Tourists { get; set; }
            public long Exports { get; set; }
            public double LifeExpectancyFemale { get; set; }
            public double PostSecondaryEnrollmentFemale { get; set; }
            public double PostSecondaryEnrollmentMale { get; set; }
            public double PrimarySchoolEnrollmentFemale { get; set; }
            public double InfantMortality { get; set; }
            public double GdpGrowth { get; set; }
            public long ThreatenedSpecies { get; set; }
            public long Population { get; set; }
            public double UrbanPopulation { get; set; }
            public double SecondarySchoolEnrollmentMale { get; set; }
            public string Name { get; set; }
            public double PopGrowth { get; set; }
            public string Region { get; set; }
            public long PopDensity { get; set; }
            public double InternetUsers { get; set; }
            public double GdpPerCapita { get; set; }
            public double Fertility { get; set; }
            public double Refugees { get; set; }
            public double PrimarySchoolEnrollmentMale { get; set; }
        }

        public partial class Currency
        {
            public string Code { get; set; }
            public string Name { get; set; }
        }

    }
}
