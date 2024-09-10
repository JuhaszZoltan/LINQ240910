using LINQ240910;

#region DOGS lista
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
        Sex = true,
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
 * sorozatszámítás (összegzés) -> átlagszámítás
 * szélsőérték meghatározás (min, max) (hely és érték)
 * eldönttés
 * kiválasztás
 * lineáris keresés
 * "rendezések"
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

//azon hím kutyák száma, akik neve tartalmaz 'e' betűt

int linqEbhk = dogs.Count(d => d.Sex && d.Name.ToLower().Contains('e'));
Console.WriteLine($"azon hím kutyák száma, akik nevében van 'e' betű: {linqEbhk}");

Console.WriteLine("-----------------------");
#endregion

#region összegzés
int kutyakOsszEletkora = 0;
foreach (var dog in dogs)
{
    kutyakOsszEletkora += dog.Age;
}
Console.WriteLine($"kutyák összéletkora: {kutyakOsszEletkora} év");

int linqKutyakOsszEletkora = dogs.Sum(d => d.Age);
Console.WriteLine($"eredmény sum LINQ-val: {linqKutyakOsszEletkora} év");

Console.WriteLine("-----------------------");
#endregion

# region átlagszámítás
float kutyakAtlagEletkora = kutyakOsszEletkora / (float)dogs.Count;
Console.WriteLine($"kutyák átlagéletkora: {kutyakAtlagEletkora} év");

double linqKutyakAtlagEletkora = dogs.Average(d => d.Age);
Console.WriteLine($"eredmény average LINQ-val {linqKutyakAtlagEletkora} év");

Console.WriteLine("-----------------------");
#endregion

#region szélsőérték meghatározás
//legnagyobb súlyú kutya súlya
//legnagyobb súlyú kutya neve
//legnagyobb súlyú kutya indexe a listában

int lnski = 0;
for (int i = 1; i < dogs.Count; i++)
{
    if (dogs[i].Weight > dogs[lnski].Weight)
    {
        lnski = i;
    }
}
Console.WriteLine($"legnagyobb súlyú kutya súlya: {dogs[lnski].Weight} Kg");
Console.WriteLine($"legnagyobb súlyú kutya neve: {dogs[lnski].Name} Kg");
Console.WriteLine($"legnagyobb súlyú kutya indexe: {lnski}");
Console.WriteLine($"legnagyobb súlyú kutya sorszáma: {lnski + 1}.");

float linqLnskS = dogs.Max(d => d.Weight);
Console.WriteLine($"eredmény max LINQ-val: {linqLnskS}");
Dog linqLnsk = dogs.MaxBy(d => d.Weight);
Console.WriteLine($"eredmény maxby LINQ-val: {linqLnsk.Name}");

DateTime linqLfkszd = dogs.Min(d => d.Birth);
Console.WriteLine($"eredmény min LINQ-val: {linqLfkszd:yyyy-MM-dd}");
Dog linqLfk = dogs.MinBy(d => d.Birth);
Console.WriteLine($"eredmény minby LINQ-val: {linqLfk.Name}");

Console.WriteLine("-----------------------");
#endregion

//TODO::::
#region keresés (és "kiválasztás")
//dogs.First();
//dogs.FirstOrDefault();

//dogs.Last();
//dogs.LastOrDefault();

//dogs.Single();
//dogs.SingleOrDefault();

//dogs.Find()     <-- nem LINQ
//dogs.FindAll()  <-- nem LINQ
//IndexOf()       <-- nem LINQ

Console.WriteLine("-----------------------");
#endregion

//TODO:::
#region eldöntés
//dogs.Any();
//dogs.Contains() <-- nem LINQ
#endregion