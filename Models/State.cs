using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cascading_dropdown.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }
        public string StateName { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
    }
}
