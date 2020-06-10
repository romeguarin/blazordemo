using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BlazorApp.Data;

namespace BlazorApp.Services
{
    public class GiphyService
    {
        private const string _apiKey = @"Ub9MJvXJWw1DbNNTUT7P3SaoXQXyFGUr";

        private readonly HttpClient _httpClient;

        public GiphyService(HttpClient client)
        {
            _httpClient = client;
        }

        public virtual async Task<GiphyData> GetRandmonGif(string tag = "") 
        {
            try 
            {
                var randomEndpoint = @"https://api.giphy.com/v1/gifs/random";
                var apiKey = string.Format(@"?api_key={0}", _apiKey);
                var tagValue = string.Format(@"&tag={0}", tag ?? "");
                var uriBuilder = new StringBuilder();
                uriBuilder.Append(randomEndpoint).Append(apiKey).Append(tagValue);

                var response = await _httpClient.GetAsync(uriBuilder.ToString());
                var body = await response.Content.ReadAsStringAsync();

                var attempt = JsonSerializer.Deserialize<GiphyData>(body);

                return attempt;
            }
            catch (NotSupportedException e) 
            {
                var message = e.Message;
                //lol
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                //lol
            }

            return null;
        }
    }
}