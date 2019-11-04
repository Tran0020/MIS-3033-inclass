using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace PokemonParticipation
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

        private void PokemonBtn_Click(object sender, RoutedEventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(@"https://pokeapi.co/api/v2/pokemon?limit=964").Result;
                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                   // Pokemon pk 
                    var stuff= JsonConvert.DeserializeObject<Pokemon>(content);

                    //string x = JsonConvert.SerializeObject(pk);
                    foreach (var poke in stuff.results)
                    {
                        PokemonLB.Items.Add(poke.name);
                    }
                    //PokemonLB.Items.Add(pk);// = gq.quote + "\n" + "-" + gq.character;
                }
            }
        }
    }
}