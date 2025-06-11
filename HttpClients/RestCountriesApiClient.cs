using HttpClientUsageAPI.Helpers;
using HttpClientUsageAPI.Models;
using System.Net.Http.Headers;
using System.Text.Json;

namespace HttpClientUsageAPI.HttpClients
{
    public class RestCountriesApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptionsWrapper _jsonSerializerOptionsWrapper;

        public RestCountriesApiClient(HttpClient httpClient, JsonSerializerOptionsWrapper jsonSerializerOptionsWrapper)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://restcountries.com");
            _httpClient.Timeout = TimeSpan.FromSeconds(30);

            _jsonSerializerOptionsWrapper = jsonSerializerOptionsWrapper;
        }

        public async Task<CountryDetails?> GetPortugalDetails()
        {
            var request = new HttpRequestMessage(
                HttpMethod.Get,
                "/v3.1/name/Portugal?fullText=true");

            request.Headers.Add("Accept", "application/json");

            var product = new ProductInfoHeaderValue("HttpClientUsageAPI", "1.0");
            var comment = new ProductInfoHeaderValue("(+https://github.com/pedroduarte0/HttpClientUsageAPI)");
            request.Headers.UserAgent.Add(product);
            request.Headers.UserAgent.Add(comment);

            var response = await _httpClient.SendAsync(request);

            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();

            //if (response.Content.Headers.ContentType?.MediaType == "application/json")  // not needed since we are asking only for JSON at the accept headers.
            //{
            CountryDetails[]? detailsArray = JsonSerializer.Deserialize<CountryDetails[]>(content, _jsonSerializerOptionsWrapper.Options);
            return detailsArray?.FirstOrDefault();
            //}
        }
    }
}
