using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Commande
{
    public int Id { get; set; }

    public string Firstname { get; set; }
    public string Lastname { get; set; }

    public string Email { get; set; }
  
    public int Quantity { get; set; }
  
    public string Address { get; set; }
  
  

  
    public string Numcard { get; set; }
  
  
    public string Cvv { get; set; }

    public virtual Article Article { get; set; }

}
