using System.ComponentModel.DataAnnotations;

namespace hyundai
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        
        [StringLength(50)]
        public string Nama { get; set; } = "";

        [StringLength(50)]
        public string Email { get; set; } = "";

        [StringLength(20)]
        public string Phone { get; set; } = "";

        [StringLength(20)]
        public string book_dt { get; set; } = "";
    }
}
