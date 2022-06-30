using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace webAPiINZ.Model
{
    public class Product
    {
        [Key]
        public string Barcode { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public string Producer { get; set; } = string.Empty;
        public string ProductWeight { get; set; } = string.Empty;
        public string Kcal100 { get; set; } = string.Empty;
        public string KcalTotal { get; set; } = string.Empty;
        public string Fat { get; set; } = string.Empty;
        public string SaturatesFat{ get; set; } = string.Empty;
        public string Carbohydrate { get; set; } = string.Empty;
        public string Sugar { get; set; } = string.Empty;
        public string Protein { get; set; } = string.Empty;
        public string Salt { get; set; } = string.Empty;
        public List<Ingredient> Ingredients { get; set; }
    }
}
