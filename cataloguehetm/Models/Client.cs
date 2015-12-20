using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Client
{
    public int Id { get; set; }
    [Required]
    public string Firstname { get; set; }
    [Required]
    public string Lastname { get; set; }
    [Required]
    public string Email { get; set; }
    public virtual List<Commande> Commandes { get; set; }
}
