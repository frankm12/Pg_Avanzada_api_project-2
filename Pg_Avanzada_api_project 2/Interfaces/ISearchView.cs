using Pg_Avanzada_api_project_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg_Avanzada_api_project_2.Interfaces
{
    public interface ISearchView
    {
        event EventHandler<string> OnSearchRequested;
        void DisplayResult(Root model);
        void ShowError(string message);
    }
}
