using System.ComponentModel.DataAnnotations;

namespace hyundaiClient.Models
{
    public class Cars
    {
        [Key]
        public int id { get; set; }

        [StringLength(50)]
        public string nama { get; set; } = "";

        [StringLength(10)]
        public string model { get; set; } = "";

        [StringLength(20)]
        public string years { get; set; } = "";

        [StringLength(2000)]
        public string image { get; set; } = "";
    }

}
