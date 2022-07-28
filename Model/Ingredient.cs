using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace webAPiINZ.Model
{
    public class Ingredient
    {
        [Key]
        public string IdIgredient { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public int HealthInfo { get; set; }
        [JsonIgnore]
        public List<Product> Products { get; set; }

    }
}
