using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cascading_dropdown.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string EmailId { get; set; }

        [Required]
        [ForeignKey("Country")]
        [DisplayName("Country")]
        public int countryid { get; set; }
        public virtual Country Country { get; set; }


        [Required]
        [ForeignKey("State")]
        [DisplayName("State")]
        public int Stateid { get; set; }
        public virtual State State { get; set; }


        [Required]
        [ForeignKey("City")]
        [DisplayName("City")]
        public int Cityid { get; set; }
        public virtual City City { get; set; }


    }
}
