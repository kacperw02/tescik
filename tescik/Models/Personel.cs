using System.ComponentModel.DataAnnotations;

namespace Projekt_bazy.Models
{
    public class Personel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Imię jest wymagane")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        public string Nazwisko { get; set; }

        [Range(18, 65, ErrorMessage = "Wiek musi być w zakresie 18-65 lat")]
        public int Wiek { get; set; }

        [Required(ErrorMessage = "Stopień jest wymagany")]
        public string Stopien { get; set; }

        [Required(ErrorMessage = "Nazwa magazynu jest wymagana")]
        public string PrzynaleznoscDoMagazynu { get; set; }
    }
}
