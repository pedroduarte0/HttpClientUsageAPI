using HttpClientUsageAPI.Results;

namespace HttpClientUsageAPI.Services
{
    public interface IRestCountriesCallerService
    {
        Task<CountryDetailsResult?> GetCountryDetailsAsync();
    }
}
