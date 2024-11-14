// Semefo.Web/ApiClient.cs
using SemefoApp.Models.Entities;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Semefo.Web
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;

        public ApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<List<CuerpoModel>> GetCuerposAsync(string path)
        {
            return _httpClient.GetFromJsonAsync<List<CuerpoModel>>(path);
        }
    }
}