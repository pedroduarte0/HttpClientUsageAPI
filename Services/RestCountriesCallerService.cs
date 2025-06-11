using HttpClientUsageAPI.Extensions;
using HttpClientUsageAPI.HttpClients;
using HttpClientUsageAPI.Models;
using HttpClientUsageAPI.Results;

namespace HttpClientUsageAPI.Services
{
    public class RestCountriesCallerService : IRestCountriesCallerService
    {
        private readonly RestCountriesApiClient _restCountriesApiClient;

        public RestCountriesCallerService(RestCountriesApiClient restCountriesApiClient)
        {
            _restCountriesApiClient = restCountriesApiClient;
        }

        public async Task<CountryDetailsResult?> GetCountryDetailsAsync()
        {
            CountryDetails? details = await _restCountriesApiClient.GetPortugalDetails();
            if (details == null)
            {
                return null;
            }
            return details.ToDto();
        }
    }
}
