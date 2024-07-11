using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class bookeduser
    {
        [Key]
        public Guid passenhgerId { get; set; }
        public List<bookeduser> bookedusers { get; set; }
    }
}
