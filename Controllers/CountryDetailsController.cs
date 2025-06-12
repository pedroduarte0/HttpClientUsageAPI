using HttpClientUsageAPI.Results;
using HttpClientUsageAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace HttpClientUsageAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryDetailsController : ControllerBase
    {
        private readonly IRestCountriesCallerService _restCountriesCallerService;

        public CountryDetailsController(IRestCountriesCallerService restCountriesCallerService)
        {
            _restCountriesCallerService = restCountriesCallerService;
        }

        [HttpGet(Name = "GetCountryDetails")]
        [ProducesResponseType<CountryDetailsResult>(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CountryDetailsResult>> GetCountryDetails()
        {
            var result = await _restCountriesCallerService.GetCountryDetailsAsync();
            
            if (result == null) return NotFound();

            return Ok(result);
        }
    }
}
