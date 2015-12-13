using System.Collections.Generic;

public class Client
{
    public int Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public virtual List<Commande> Commandes { get; set; }
}
