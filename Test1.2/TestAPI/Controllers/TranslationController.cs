using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using TestAPI.Models;
using TestAPI.Models.WordDataModels;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranslationController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public TranslationController(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<IActionResult> Translate([FromQuery] string text)
        {
            try
            {
                string apiUrl = $"{_configuration["DictionaryApi"]}/{text}";

                var client = _httpClientFactory.CreateClient();

                var response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    var translation = JsonSerializer.Deserialize<List<WordData>>(content)?.First();

                    return Ok(translation);
                }
                else
                {
                    return BadRequest("Failed to fetch translation data from the third-party API.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
