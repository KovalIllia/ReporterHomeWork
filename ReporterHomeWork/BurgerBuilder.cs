namespace ReporterHomeWork;

public class BurgerBuilder: IBurgerBulder
{
    private Burger _burger;
    private readonly IEnumerable<Menu> _menus;
    private IBurgerBulder _burgerBulderImplementation;

    public BurgerBuilder(IEnumerable<Menu> menus)
    {
        _menus = menus;
        _burger = new Burger();
        
    }


    /*public IBurgerBulder BuildHeader()
    {
        _burger.Header=$"Recomend for you vonderful menu of restorant Verba&Caluna for: {DateTime.Now}\n";
        _burger.Header += "\n________________________________________\n";
        return this;
    }*/

    /*public IBurgerBulder BuildMenu()
    {
        _burger.Menu=string.Join(Environment.NewLine,_menus.Select(b=>))
    }*/

    public IBurgerBulder BuildHeader()
    {
        _burger.Header=$"Recomend for you vonderful menu of restorant Verba&Caluna for: {DateTime.Now}\n";
        _burger.Header += "\n________________________________________\n";
        return this;
    }

    public IBurgerBulder BuildMenu()
    {
        _burger.Menu = string.Join(Environment.NewLine, _menus.Select(b =>
            $"Burger : {b.Name}\t\tBun: {b.Bun}\t\tCotlet: {b.Cotlet}\t\tVegetables: {b.Vegetables}\t\tCaloricContent: {b.СaloricСontent}\t\tPrice: {b.Price}\t\t$"));
        return this;
    }

    public IBurgerBulder BuildMFooter()
    {
        
        _burger.Footer=$"Thanks, for arriving to our vonderful restorant";
        _burger.Footer="\n________________________________________\n";
        return this;

    }

    public Burger GetBurger()
    {
        Burger burger = _burger;
        _burger = new();
        return burger;
    }
}