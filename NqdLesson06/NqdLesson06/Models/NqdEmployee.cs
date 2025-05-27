using System.ComponentModel.DataAnnotations;

namespace NqdLesson06.Models
{
    public class NqdEmployee
    {
        public int NqdId { get; set; }
        public string NqdName { get; set; }
        public DateTime NqdBirthDay { get; set; }
        public string NqdEmail { get; set; }
        public string NqdPhone { get; set; }
        public decimal NqdSalary { get; set; }
        public bool NqdStatus { get; set; }
    }
}