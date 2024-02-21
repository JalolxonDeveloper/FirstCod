using FirstCod.Models;

using (ApplicationDbContext db=new ApplicationDbContext())
{
    Bemor bemor1 = new Bemor { Ism = "Otabek", Familiya = "Muhiddinov", KasallikTuri = "Ko'p tashqariga chiqadi" };
    Bemor bemor2 = new Bemor { Ism = "Ali", Familiya = "Sobirov", KasallikTuri = "Shomollash" };

    db.Bemorlar.AddRange(bemor1, bemor2);
    db.SaveChanges();
    Console.WriteLine("Bazaga Saqlandi");


    var bemorlar = db.Bemorlar.ToList();

    foreach (var i in bemorlar)
    {
        Console.WriteLine($"{i.Id}.{i.Ism} {i.Familiya}  {i.KasallikTuri}");
    }
}