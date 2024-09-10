using LINQ240910;

#region DOGS
List<Dog> dogs =
[
    new() //01
    {
        Name = "Kira",
        Birth = DateTime.Parse("2019-05-10"),
        Sex = false,
        Breed = "tacskó",
        Weight = 5.5F,
    },
    new() //02
    {
        Name = "Rex",
        Birth = DateTime.Parse("2014-04-20"),
        Sex = true,
        Breed = "németjuhász",
        Weight = 35.2F,
    },
    new() //03
    {
        Name = "Igor",
        Birth = DateTime.Parse("2017-11-20"),
        Sex = false,
        Breed = "kaukázusi farkasölő",
        Weight = 95.0F,
    },
    new() //04
    {
        Name = "Thomas Edison",
        Birth = DateTime.Parse("2001-02-07"),
        Sex = true,
        Breed = "németjuhász",
        Weight = 40.3F,
    },
    new() //05
    {
        Name = "Princess",
        Birth = DateTime.Parse("2022-12-24"),
        Sex = false,
        Breed = "palotapincsi",
        Weight = 4.2F,
    },
];
#endregion

//milyen prog tételeket ismerünk?
/*
 * megszámlálás
 * "rendezések"
 * sorozatszámítás (összegzés) -> átlagszámítás
 * szélsőérték meghatározás (min, max) (hely és érték)
 * eldönttés
 * kiválasztás
 * lineáris keresés
 * szétválogatás (csoportosítás)
 * kiválogatás
 * "halmaztételek"
*/


#region megszámlálás
// adott tulajdonságú elemek száma a kollekcióban
// 3 évnél öregebb kutyák száma
int haromEvnelIdosebb = 0;
foreach (var dog in dogs)
{
    if (dog.Age >= 3) haromEvnelIdosebb++;
}
Console.WriteLine($"3 évnél idősebb kutyák száma: {haromEvnelIdosebb} db");

int linqHaromEvnelIdosebb = dogs.Count(d => d.Age > 3);
Console.WriteLine($"eredmény count LINQ-val: {linqHaromEvnelIdosebb}");

// szukák száma
int szukakSzama = 0;
for (int i = 0; i < dogs.Count; i++)
{
    if (!dogs[i].Sex) szukakSzama++;
}
Console.WriteLine($"Szuka kutyák száma: {szukakSzama} db");
int linqSzukakSzama = dogs.Count(d => !d.Sex);
Console.WriteLine($"eredmény count LINQ-val: {linqSzukakSzama}");

//TODO: összetett feltétel!
#endregion