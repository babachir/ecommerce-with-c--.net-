using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Commande
{
    public int Id { get; set; }
    [Required]
    public DateTime Dateorder { get; set; }
    [Required]
    public DateTime Datedelivry { get; set; }
    [Required]
    public int Quantity { get; set; }
    [Required]
    public string Address { get; set; }
    [Required]
    public string City { get; set; }
    [Required]
    public string Zipcode { get; set; }
    [Required]
    public string Namecard { get; set; }
    [Required]
    public string Numcard { get; set; }
    [Required]
    public DateTime Expirationdate { get; set; }
    [Required]
    public string Cvv { get; set; }
    public virtual Client Client { get; set; }
    public List<Conserned> Conserneds { get; set; }

}
