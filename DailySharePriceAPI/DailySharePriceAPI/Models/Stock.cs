using System.ComponentModel.DataAnnotations;

namespace DailySharePriceAPI.Models
{
    public class Stock
    {
        [Key]
        public int StockId { get; set; }
        [Required]
        public string StockName { get; set; }
        [Required]
        public int StockValue { get; set; }
    }
}
