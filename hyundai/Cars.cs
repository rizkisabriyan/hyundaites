using System.ComponentModel.DataAnnotations;

namespace hyundai
{
    public class Cars
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Nama { get; set; } = "";

        [StringLength(10)]
        public string Model { get; set; } = "";

        [StringLength(20)]
        public string Years { get; set; } = "";

        [StringLength(2000)]
        public string Image { get; set; } = "";
    }
}
