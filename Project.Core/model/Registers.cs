using System.ComponentModel.DataAnnotations;

namespace projectNaomi.Core.model
{
    public class Registers
    {
        [Key]
        public string id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string codeTrip { get; set; }
        public bool status { get; set; }
        public List<Trip> trips { get; set; }
    }
}
