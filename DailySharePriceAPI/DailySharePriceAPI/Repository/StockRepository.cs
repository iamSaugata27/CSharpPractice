using System.Collections.Generic;
using System.Linq;
using DailySharePriceAPI.Data;
using DailySharePriceAPI.Models;
using DailySharePriceAPI.Repository.IRepository;

namespace DailySharePriceAPI.Repository
{
    public class StockRepository : IStockRepository
    {
        private readonly ApplicationDbContext _db;
        public StockRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool CreateStock(Stock stock)
        {
            _db.Stocks.Add(stock);
            return Save();
        }

        public bool DeleteStock(Stock stock)
        {
            _db.Stocks.Remove(stock);
            return Save();
        }

        public Stock GetStock(int stockId)
        {
            return _db.Stocks.FirstOrDefault(stock => stock.StockId == stockId);
        }

        public ICollection<Stock> GetStocks()
        {
            return _db.Stocks.OrderBy(stock => stock.StockName).ToList();
        }

        public bool StockExists(string stockName)
        {
            return _db.Stocks.Any(stock => stock.StockName.ToLower().Trim() == stockName.ToLower().Trim());
        }

        public bool StockExists(int stockId)
        {
            return _db.Stocks.Any(stock => stock.StockId == stockId);
        }

        public bool UpdateStock(Stock stock)   
        {
            _db.Stocks.Update(stock);
            return Save();
        }
        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }
    }
}
