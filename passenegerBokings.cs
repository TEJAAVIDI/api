using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class passenegerBokings
    {
        [Key]
        public Guid id { get; set; }
        public string passengername { get; set; }
        public int passage { get; set; }
        public string parentId { get; set; }
    }
}
