﻿using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace PrijaviSusjeda.Data
{
    public class Person
    {
        [Required] public string Ime { get; set; }
        [Required] public string Prezime { get; set; }
        [Required] public string Adresa { get; set; }
        [Required] public string Grad { get; set; }
        [Required] public string Zupanija { get; set; }
        [StringLength(5, MinimumLength = 5, ErrorMessage = "Poštanski broj mora imati minimalno 5 brojeva!")]
        public string PostanskiBroj { get; set; }
        [Range(1, 60, ErrorMessage = "To nije validan broj noge!")]
        public int BrojNoge { get; set; }
        public bool Rukavica { get; set; }
        public bool Ruka { get; set; }
        public bool Maska { get; set; }
        public bool Kaslje { get; set; }
        public bool Blid { get; set; }
        public bool Samoizolacija { get; set; }
        public bool Distanca { get; set; }
        public int Rezultat { get; set; }
        public void Kalkuliraj()
        {
            if (Rukavica) Rezultat++;
            if (Ruka) Rezultat++;
            if (Maska) Rezultat++;
            if (Kaslje) Rezultat++;
            if (Blid) Rezultat++;
            if (Samoizolacija) Rezultat++;
            if (Distanca) Rezultat++;
        }
    }
}