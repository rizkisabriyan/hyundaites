using System.ComponentModel.DataAnnotations;

namespace hyundaiClient.Models
{
    public class Customer
    {
        [Key]
        public int id { get; set; }

        [StringLength(50)]
        public string nama { get; set; } = "";

        [StringLength(50)]
        public string email { get; set; } = "";

        [StringLength(20)]
        public string phone { get; set; } = "";

        [StringLength(20)]
        public string book_dt { get; set; } = "";
    }

}
