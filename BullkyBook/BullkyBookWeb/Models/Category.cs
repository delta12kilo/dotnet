using System.ComponentModel.DataAnnotations;

namespace BullkyBookWeb.Models
{
    public class Category
    {
        [Key]
        public int Id{ get; set; }

        [Required]
        public String? Name { get; set; }

        public int DisplayOrder { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
