using System.ComponentModel.DataAnnotations;
using System;

namespace PrijaviSusjeda.Data
{
    public class Person
    {
        [Required] 
        public string Ime { get; set; }
        [Required] 
        public string Prezime { get; set; }
        [Required] 
        public string Adresa { get; set; }
        [Required]
        public string Grad { get; set; }
        [Required] 
        public string Zupanija { get; set; }
        [Required] 
        [StringLength(5, MinimumLength = 5, ErrorMessage = "Poštanski broj mora imati minimalno 5 brojeva!")]
        public string PostanskiBroj { get; set; }
        public string BrojNoge { get; set; }
    }
}