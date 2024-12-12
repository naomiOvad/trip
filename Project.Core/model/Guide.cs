using System.ComponentModel.DataAnnotations;

namespace projectNaomi.Core.model
{
    public class Guide
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public bool status { get; set; }
        public List<Trip> Trips { get; set; }
    }
}
