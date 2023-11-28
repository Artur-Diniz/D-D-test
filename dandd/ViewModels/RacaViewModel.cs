
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;
using dandd.Models;
using dandd.Views;

namespace dandd.ViewModels
{
    internal partial class RacaViewModel : ObservableObject , IDisposable
    {
        HttpClient client;

        JsonSerializerOptions _serializerOptions;
        string baseUrl = "https://www.dnd5eapi.co/api/races";

        [ObservableProperty]
        public string _index;

        [ObservableProperty]
        public string _name;

        [ObservableProperty]
        public string _url;

        [ObservableProperty]
        public ObservableCollection<Raca> _raca;

        public RacaViewModel()
        {
            client = new HttpClient();
            _raca = new ObservableCollection<Raca>();
            _serializerOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public ICommand getRacasCommand => new Command(async () => await LoadRacaAsync());

        private async Task LoadRacaAdync()
        {
            var url = $"{baseUrl}/racas";
            if (HttpResponseMessage.IsSucessStatusCode)
            {
                string content = await response.Content.ReadasStringAsync();
            }
        }



    }
}
