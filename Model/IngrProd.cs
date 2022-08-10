using System.ComponentModel.DataAnnotations;

namespace webAPiINZ.Model
{
    public class IngrProd
    {
        [Key]
        public int Id { get; set; }
        public string prodId { get; set; }
        public int ingredietnId { get; set; }
    }
}
