using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Article
{
    public int Id { get; set; }

    public string Name { get; set; }

    public float Priceht { get; set; }

    public float Tva { get; set; }

    public int Qtstock { get; set; }

    public string Type { get; set; }
  
    public string Urlimage { get; set; }
    public virtual List<Conserned> Conserneds { get; set; }
    public virtual Catalogue Catalogue { get; set; }
}
