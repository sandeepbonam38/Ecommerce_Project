using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Arrest
    {
        [Key]
        public int Id { get; set; }
        public string PersonName { get; set; }
        public string Race { get; set; }
        public DateTime ArrestDate { get; set; }
    }
}
