using OOPZooHw.Models;

Animal tiger = new Animal { Name = "Ghost", Species = "Tiger" };
Animal lion = new Animal { Name = "Predator", Species = "Lion" };
Animal penguin = new Animal { Name = "BlackandWhite", Species = "Penguin" };
Animal eagle = new Animal { Name = "Sharpeye", Species = "Eagle" };
Animal horse = new Animal { Name = "Wind", Species = "Horse" };

AnimalSitter sitter1 = new AnimalSitter { Id = 1, Name = "Leo" };
AnimalSitter sitter2 = new AnimalSitter { Id = 2, Name = "Justin"};
AnimalSitter sitter3 = new AnimalSitter { Id = 3, Name = "Bella" };

var AnimalList = new List<Animal>{ tiger, lion, penguin, eagle, horse };
var SitterList = new List<AnimalSitter> { sitter1, sitter2, sitter3 };

foreach(Animal x in AnimalList)
{
    Animal.Add(x);
    Console.WriteLine();
}

foreach(AnimalSitter x in SitterList)
{
    AnimalSitter.Add(x);
    Console.WriteLine();
}

sitter1.Feed(tiger);
Console.WriteLine();
sitter2.AttentionToAnimal(eagle);
Console.WriteLine();
sitter3.AttentionToAnimal(horse);
Console.WriteLine();
sitter3.PlayWithAnimal(horse);
