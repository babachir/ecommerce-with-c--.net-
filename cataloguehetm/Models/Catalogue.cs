using System;
using System.Collections.Generic;

public class Catalogue
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Year { get; set; }
    public string Urlimage{ get; set; }
    public virtual List<Avalaible> Avalaibles { get; set; }
    public virtual Provider Provider { get; set; }
    public virtual List<Article> Articles { get; set; }

}
