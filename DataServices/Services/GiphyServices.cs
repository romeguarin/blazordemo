using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using DataServices.Data;
using System.Text.Json;

namespace DataServices.Services
{
    public class GiphyServices
    {
        private const string _apiKey = @"Ub9MJvXJWw1DbNNTUT7P3SaoXQXyFGUr";

        private readonly HttpClient httpClient;
        
        public GiphyServices(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public virtual async Task<string> GetRandomGifUrl(string tag = "")
        {
            var giphyData = await GetRandomGif(tag);
            if (giphyData == null)
            {
                return "";
            }

            return giphyData.Data?.EmbedUrl ?? "";
        }

        public virtual async Task<GiphyData> GetRandomGif(string tag = "")
        {
            try
            {
                var giphyEndpoint = @"https://api.giphy.com/v1/gifs/random";

                var apiKey = string.Format(@"?api_key={0}", _apiKey);
                var tagValue = string.Format(@"&tag={0}", tag ?? "");

                var uriBuilder = new StringBuilder();
                uriBuilder.Append(giphyEndpoint).Append(apiKey).Append(tagValue);

                var response = await httpClient.GetAsync(uriBuilder.ToString());
                var body = await response.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<GiphyData>(body);

                return result;
            }
            catch (NotSupportedException e)
            {
                var message = e.Message;
            }
            catch (Exception ex)
            {
                var message = ex.Message;
            }

            return null;
        }
    }
}
