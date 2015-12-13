using System.Collections.Generic;

public class Provider
{
    public int Id { get; set; }
    public string Entreprise { get; set; }
    public string Contact { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Zipcode { get; set; }
    public string Country { get; set; }
    public string Numphone { get; set; }
    public string Fax { get; set; }
    public virtual List<Catalogue> Catalogues { get; set; }

}
