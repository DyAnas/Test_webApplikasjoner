﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GruppeInnlevering1.Models
{
   


public class StasjonV
{

    public int StasjonId { get; set; }
    [Required(ErrorMessage ="Feltet Stasjonnavn er obligatorisk")]
  
   
    public string StasjonNavn { get; set; }

}
}