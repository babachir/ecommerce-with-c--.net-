using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Catalogue
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Year { get; set; }
    [Required]
    public string Urlimage{ get; set; }
    public virtual List<Avalaible> Avalaibles { get; set; }
    public virtual Provider Provider { get; set; }
    public virtual List<Article> Articles { get; set; }

}
