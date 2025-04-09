using Pg_Avanzada_api_project_2.Model;
using System;
using System.Collections.Generic;

public interface ITrendingCryptocurrencyView
{
    event EventHandler LoadTrendingDataRequested;
    void DisplayTrendingCryptocurrencies(List<TrendingCryptocurrencyModel> cryptocurrencies);
    void ShowError(string message);
}