using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class AddTrain
    {
        [Key]
        public Guid TrainId { get; set; }

        public int trainNumber { get; set; }
        public string Trainname { get; set; }

        public string trainFrom { get; set;}
        public string trainTo { get; set; }

        public string trainDepatTime { get; set; }

        public int totalseats { get; set; }
        public int bookedseats { get; set; }
    }
}
