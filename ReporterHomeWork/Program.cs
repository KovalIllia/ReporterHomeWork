using ReporterHomeWork;

List<Menu> menus=new ()
{
    new Menu{Name="King",Bun = "french",Cotlet="beef",Vegetables = "onion", СaloricСontent = "550 calories", Price = "100 UAH"},
    new Menu{Name="BigMac",Bun = "brioch",Cotlet="pork",Vegetables = "tomatos", СaloricСontent = "1050 calories", Price = "800 UAH"},
    new Menu{Name="Gamburger",Bun = "baton",Cotlet="chiken",Vegetables = "garlic", СaloricСontent = "850 calories", Price = "500 UAH"},
    
};
var builder=new BurgerBuilder(menus);
var director = new BurgerDirector(builder);
director.Build();
var result=builder.GetBurger();
Console.WriteLine(result);
Console.ReadKey();