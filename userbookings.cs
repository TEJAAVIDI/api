using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class userbookings
    {
        [Key]
        public Guid passenhgerId { get; set; }
        public string passengername { get; set; }
        public int passengerage { get; set; }
    }
}
