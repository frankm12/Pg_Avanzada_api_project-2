using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg_Avanzada_api_project_2.Model
{
    public class TrendingCryptocurrencyModel
    {
        public string Name { get; set; }
        public double? Price { get; set; }
    }

    public class TrendingItem
    {
        public Item Item { get; set; }
    }

    public class Item
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Data Data { get; set; }
    }

    public class Data
    {
        public double? Price { get; set; }
    }
    public class TrendingRoot
    {
        public List<TrendingItem> coins { get; set; }
    }

}
