using System.Collections.Generic;
using DailySharePriceAPI.Models;

namespace DailySharePriceAPI.Repository.IRepository
{
    public interface IStockRepository
    {
        ICollection<Stock> GetStocks();
        Stock GetStock(int stockId);
        bool StockExists(string stockName);
        bool StockExists(int stockId);
        bool CreateStock(Stock stock);
        bool UpdateStock(Stock stock);
        bool DeleteStock(Stock stock);
        bool Save();
    }
}
