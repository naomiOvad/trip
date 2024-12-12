using System.ComponentModel.DataAnnotations;

namespace projectNaomi.Core.model
{
    public class Trip
    {
        [Key]
        public string code { get; set; }
        public string location { get; set; }
        public DateTime date { get; set; }
        public int numRegisters { get; set; }
        public string idGuide { get; set; }
        public Guide guide { get; set; }
        public List<Registers> registers { get; set; }
    }
}
