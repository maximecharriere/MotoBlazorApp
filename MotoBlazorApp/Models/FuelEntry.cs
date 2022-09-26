using System.ComponentModel.DataAnnotations;

namespace MotoBlazorApp.Models
{
    public class FuelEntry
    {
        [Required]
        [Range(0.0, Double.MaxValue, ErrorMessage = "{0} can't be negative")]
        public double? Price { get; set; }

        [Required]
        [Range(0.0, Double.MaxValue, ErrorMessage = "{0} can't be negative")]
        public double? Distance { get; set; }

        [Required]
        [Range(0.0, Double.MaxValue, ErrorMessage = "{0} can't be negative")]
        public double? Quantity { get; set; }

        public double? PriceByUnit
        {
            get
            {
                return Price / Quantity;
            }

        }

    }
}
