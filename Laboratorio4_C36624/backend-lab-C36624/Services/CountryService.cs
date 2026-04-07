using backend_lab_C36624.Models;
using backend_lab_C36624.Repositories;

namespace backend_lab_C36624.Services
{
    public class CountryService
    {
        private readonly CountryRepository countryRepository;
        public CountryService()
        {
            countryRepository = new CountryRepository();
        }
        public List<CountryModel> GetCountries()
        {
            // Add any missing business logic when it is neccesary
        return countryRepository.GetCountries();
        }
    }
}
