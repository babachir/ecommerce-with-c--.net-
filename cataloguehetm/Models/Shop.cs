using System.Collections.Generic;

public class Shop

{
    public int Id { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Zipcode { get; set; }
    public string Country { get; set; }
    public string Numphone { get; set; }
    public string Fax { get; set; }
    public virtual List<Avalaible> Avalaibles { get; set; }

}
