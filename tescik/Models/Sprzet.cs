using System.ComponentModel.DataAnnotations;

namespace Projekt_bazy.Models
{
    public class Sprzet
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nazwa sprzętu jest wymagana")]
        [StringLength(100, ErrorMessage = "Nazwa sprzętu nie może przekraczać 100 znaków")]
        public string NazwaSprzetu { get; set; }

        [Required(ErrorMessage = "Nazwa magazynu jest wymagana")]
        public string NazwaMagazynu { get; set; }

        [Required(ErrorMessage = "Data wstawienia jest wymagana")]
        [DataType(DataType.Date)]
        public DateTime DataWstawienia { get; set; }
    }
}
