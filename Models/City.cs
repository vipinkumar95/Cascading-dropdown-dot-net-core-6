using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cascading_dropdown.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string CityName { get; set; }

        [ForeignKey("State")]
        public int stateId { get; set; }

        public virtual State State { get; set; }
    }
}
