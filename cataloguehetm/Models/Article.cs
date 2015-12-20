using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Article
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public float Priceht { get; set; }
    [Required]
    public float Tva { get; set; }
    [Required]
    public int Qtstock { get; set; }
    [Required]
    public string Type { get; set; }
    [Required]
    public string Urlimage { get; set; }
    public virtual List<Conserned> Conserneds { get; set; }
    public virtual Catalogue Catalogue { get; set; }
}
