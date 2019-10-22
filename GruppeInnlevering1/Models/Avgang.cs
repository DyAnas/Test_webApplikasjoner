﻿using System;
using System.ComponentModel.DataAnnotations;

namespace GruppeInnlevering1.Models
{
    public class Avgang
    {
        public int AvgangId { get; set; }
        public TimeSpan Tid { get; set; }
        public virtual Tog Tog { get; set; }
        public virtual Stasjon Stasjon { get; set; }

    }
}



public class avgangs
{
    public int AvgangId { get; set; }
    [Required(ErrorMessage ="Feltet AvgangId er obligatorisk.")]
    [DataType(DataType.Time)]
    public TimeSpan Tid { get; set; }
    [Required(ErrorMessage = "Feltet Tid er obligatorisk.")]
    public int TogId { get; set; }
    [Required(ErrorMessage = "Feltet TogId er obligatorisk.")]
    public int StasjonId { get; set; }
   
}