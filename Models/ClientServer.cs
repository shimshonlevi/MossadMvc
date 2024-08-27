using Newtonsoft.Json;

namespace Mosad1View.Models
{
    public class ClientServer
    {
        private readonly HttpClient _httpClient;

        public ClientServer(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Agent>> GetAgentsAsync()
        {
            
            var response = await _httpClient.GetFromJsonAsync<List<Agent>>("http://localhost:5192/Agents" );

            //Console.WriteLine(content);
            return response;
           //JsonConvert.DeserializeObject<List<Agent>>();
        }

        public async Task<List<Target>> GetTargetsAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<Target>>("http://localhost:5192/Targets");
            return response;
            //response.EnsureSuccessStatusCode();
            //var content = await response.Content.ReadAsStringAsync();
            //Console.WriteLine(content);
            //return JsonConvert.DeserializeObject<List<Target>>(content);
        }

        public async Task<List<Mission>> GetMissionsAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<Mission>>("http://localhost:5192/Missions");
            return response;
            //response.EnsureSuccessStatusCode();
            //var content = await response.Content.ReadAsStringAsync();
            //Console.WriteLine(content);
            //return JsonConvert.DeserializeObject<List<Mission>>(content);
        }

    }
    
}
