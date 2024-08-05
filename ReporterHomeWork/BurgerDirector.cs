namespace ReporterHomeWork;

public class BurgerDirector
{
    private readonly IBurgerBulder _burger;

    public BurgerDirector(IBurgerBulder burger)
    {
        _burger = burger;
    }

    public void Build()
    {
        _burger.BuildHeader();
        _burger.BuildMenu();
        _burger.BuildMFooter();
    }


}