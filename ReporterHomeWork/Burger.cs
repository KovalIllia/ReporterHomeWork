using System.Text;

namespace ReporterHomeWork;

public class Burger
{
    /*public string MenuHeader { get; set; }
    public string Bun { get; set; }
    public string Cotlet { get; set; }
    public string Tomato { get; set; }
    public string Salat { get; set; }
    public string Onion { get; set; }
    public string Sauce { get; set; }

    public override string ToString() =>
        new StringBuilder()
            .Append(Bun)
            .Append(Cotlet)
            .Append(Tomato)
            .Append(Salat)
            .Append(Onion)
            .Append(Sauce).ToString();*/
    public string Header { get; set; }
    public string Menu { get; set; }
    
    public string Footer { get; set; }
    
    public override string ToString() =>
        new StringBuilder()
            .Append(Header)
            .Append(Menu)
            .Append(Footer).ToString();
    
}