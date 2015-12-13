using System;
using System.Collections.Generic;

public class Commande
{
    public int Id { get; set; }
    public DateTime Dateorder { get; set; }
    public DateTime Datedelivry { get; set; }
    public int Quantity { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Zipcode { get; set; }
    public string Namecard { get; set; }
    public string Numcard { get; set; }
    public DateTime Expirationdate { get; set; }
    public string Cvv { get; set; }
    public virtual Client Client { get; set; }
    public List<Conserned> Conserneds { get; set; }

}
