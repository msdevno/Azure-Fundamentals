using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ContactList.Models;
using Swashbuckle.Swagger.Annotations;

namespace ContactList.Controllers
{
    public class CountryController : ApiController
    {
        private const string FILENAME = "countries.json";
        private GenericStorage _storage;

        public CountryController()
        {
            _storage = new GenericStorage();
        }

        private async Task<IEnumerable<Country>> GetCountries()
        {
            var countries = await _storage.Get<Country>(FILENAME);
            if (countries == null)
            {
                await _storage.Save(new []{
                        new Country { Id = 1, Name = "Norway", CountryCode = "NO"},
                        new Country { Id = 2, Name = "USA", CountryCode = "US"},
                        new Country { Id = 3, Name = "England", CountryCode = "ENG"}
                    }, FILENAME);
            }

            return countries;
        }

        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK,
            Type = typeof (IEnumerable<Country>))]
        [Route("~/countries")]
        public async Task<IEnumerable<Country>> Get()
        {
            return await GetCountries();
        }

        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK,
            Description = "OK",
            Type = typeof (IEnumerable<Country>))]
        [SwaggerResponse(HttpStatusCode.NotFound,
            Description = "Country not found",
            Type = typeof (IEnumerable<Country>))]
        [SwaggerOperation("GetCountryByName")]
        [Route("~/countries/{name}")]
        public async Task<Country> Get([FromUri] string name)
        {
            var countries = await GetCountries();
            return countries.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
        }

        [HttpPost]
        [SwaggerResponse(HttpStatusCode.Created,
            Description = "Created",
            Type = typeof (Country))]
        [Route("~/countries")]
        public async Task<Country> Post([FromBody] Country country)
        {
            var countries = await GetCountries();
            var countryList = countries.ToList();
            countryList.Add(country);
            await _storage.Save<Country>(countryList, FILENAME);
            return country;
        }

        [HttpDelete]
        [SwaggerResponse(HttpStatusCode.OK,
            Description = "OK",
            Type = typeof (bool))]
        [SwaggerResponse(HttpStatusCode.NotFound,
            Description = "Country not found",
            Type = typeof (bool))]
        [Route("~/countries/{name}")]
        public async Task<HttpResponseMessage> Delete([FromUri] string name)
        {
            var countries = await GetCountries();
            var countryList = countries.ToList();

            if (!countryList.Any(x => x.Name == name))
            {
                return Request.CreateResponse<bool>(HttpStatusCode.NotFound, false);
            }

            countryList.RemoveAll(x => x.Name == name);
            await _storage.Save<Country>(countryList, FILENAME);
            return Request.CreateResponse<bool>(HttpStatusCode.OK, true);
        }

    }
}
