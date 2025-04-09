using Pg_Avanzada_api_project_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg_Avanzada_api_project_2.Services
{
    // Interface para cumplir con Dependency Inversion (SOLID)
    public interface IApiService
    {
        Task<List<CryptocurrencyModel>> GetCryptocurrenciesAsync();
    }
}
