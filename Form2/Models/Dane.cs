using System.ComponentModel.DataAnnotations;

namespace Form2.Models
{
    public class Dane
    {
        [Required(ErrorMessage = "Prosze podaj Imie")]
        [MinLength(2, ErrorMessage = "Imię musi mieć co najmniej 2 znaki")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Prosze podaj Nazwisko")]
        [MinLength(2, ErrorMessage = "Nazwisko musi mieć co najmniej 2 znaki")]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Prosze podaj Email")]
        [EmailAddress(ErrorMessage = "Niepoprawny format adresu e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Prosze podaj Haslo")]
        [MinLength(8, ErrorMessage = "Hasło musi mieć co najmniej 8 znaków.")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).+$", ErrorMessage = "Hasło musi zawierać co najmniej jedną dużą literę, jedną małą literę i jedną cyfrę.")]
        [DataType(DataType.Password)]
        public string Haslo { get; set; }

        [Required(ErrorMessage = "Prosze potwierdzic Haslo")]
        [MinLength(8, ErrorMessage = "Hasło musi mieć co najmniej 8 znaków.")]
        [Compare("Haslo", ErrorMessage = "Hasla musza sie zgadzac")]
        [DataType(DataType.Password)]
        public string PotwierdzHaslo { get; set; }

        [Required(ErrorMessage = "Prosze podaj numer Telefonu")]
        [RegularExpression(@"^(\+48\s?)?(\d{3}\s?\d{3}\s?\d{3})$",
            ErrorMessage = "Wprowadz prawidlowy numer Telefonu, np. +48 123 456 789 lub 123 456 789")]
        public string Telefon { get; set; }

        [Required(ErrorMessage = "Prosze podaj Wiek")]
        [Range(18, 100, ErrorMessage = "Wiek musi być między 18 a 100")]
        public int Wiek { get; set; }

        [Required(ErrorMessage = "Prosze wybrac Miasto")]
        public Miasta Miasto { get; set; }

        public enum Miasta
        {
            Krakow,
            Warszawa,
            Rzeszow,
            Wroclaw,
            Poznan
        }
    }
}
