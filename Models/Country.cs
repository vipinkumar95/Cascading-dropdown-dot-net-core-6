using System.ComponentModel.DataAnnotations;

namespace Cascading_dropdown.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string CountryName { get; set; }
    }
}
