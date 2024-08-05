namespace ReporterHomeWork;

public interface IBurgerBulder
{
    IBurgerBulder BuildHeader();
    IBurgerBulder BuildMenu();
    IBurgerBulder BuildMFooter();
    /*IBurgerBulder BuildCotlet();
    IBurgerBulder BuildTomato();
    IBurgerBulder BuildSalat();
    IBurgerBulder BuildOnion();
    IBurgerBulder BuildSauce();*/
    Burger GetBurger();

}