using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class AllStations
    {
        [Key]
        public Guid stationId { get; set; }
            
        public string stationName { get; set; }

    }
}
