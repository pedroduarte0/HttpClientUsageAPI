using HttpClientUsageAPI.Models;
using HttpClientUsageAPI.Results;

namespace HttpClientUsageAPI.Extensions
{
    public static class CountryDetailsMapper
    {
        public static CountryDetailsResult ToDto(this CountryDetails countryDetails)
        {
            return new CountryDetailsResult
            {
                Name = new NameResult
                {
                    Common = countryDetails.Name.Common,
                    Official = countryDetails.Name.Official,
                    NativeName = new NativeNameResult
                    {
                        Por = new PorResult
                        {
                            Official = countryDetails.Name.NativeName.Por.Official,
                            Common = countryDetails.Name.NativeName.Por.Common
                        }
                    }
                }
            };
        }
    }
}
