using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class register
    {
        [Key]
        public Guid userid { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int phonenumber { get; set; }

    }
}
