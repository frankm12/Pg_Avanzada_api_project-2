using Pg_Avanzada_api_project_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg_Avanzada_api_project_2._View
{
    public interface ICryptocurrencyView
    {
        event EventHandler LoadDataRequested;
        void DisplayCryptocurrencies(List<CryptocurrencyModel> cryptocurrencies);
        void ShowError(string message);
    }
}
