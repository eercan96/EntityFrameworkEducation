using System.ComponentModel.DataAnnotations;

namespace EFCodeFirst.Model
{
    public class Test
    {
        //data annatations

        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage ="Name alını zorunlu")]
        public string Name { get; set; }

        [MaxLength(100,ErrorMessage ="Yaş en fazla 100 olabilir")]
        [Required(ErrorMessage = "Age alını zorunlu")]
        public int Age { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage ="Telefon alanı zorunludur")]
        public int Tel { get; set; }
    }
}
