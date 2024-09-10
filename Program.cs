using LINQ240910;

#region DOGS
List<Dog> dogs = new()
{
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
        Sex = false,
        Breed = "utcamix",
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
};
#endregion