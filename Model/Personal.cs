using System.ComponentModel.DataAnnotations;

namespace webAPiINZ.Model
{
    public class Personal
    {
        [Key]
        public int Id { get; set; }
        public Guid IdUser { get; set; }
        public string Mass { get; set; } = string.Empty;
        public string Height { get; set; } = string.Empty;
        public string Age { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string Pal { get; set; } = string.Empty;
        public string Target { get; set; } = string.Empty;
        public string CPM { get; set; } = string.Empty;
        public string Protein { get; set; } = string.Empty;
        public string Carbonates { get; set; } = string.Empty;
        public string Fat { get; set; } = string.Empty;
        public string CPMTarget { get; set; } = string.Empty;
        public string IdealBodyMass { get; set; } = string.Empty;
        public double ProteinPer { get; set; }
        public double CarbonatesPer { get; set; }
        public double FatPer { get; set; }
        public DateTime SaveTime { get; set; }
    }
}
