using System.ComponentModel.DataAnnotations;

namespace Projekt_bazy.Models
{
    public class Zamowienie
    {
        [Key]
        public int IdZamowienia { get; set; }

        [Required(ErrorMessage = "Nazwa sprzętu jest wymagana")]
        public string NazwaSprzetu { get; set; }

        [Required(ErrorMessage = "Data zamówienia jest wymagana")]
        [DataType(DataType.Date)]
        public DateTime DataZamowienia { get; set; }
    }
}
