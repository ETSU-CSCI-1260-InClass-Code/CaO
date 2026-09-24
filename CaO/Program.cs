using CaO;
using System.Numerics;

int num = 1;


Player p1 = new Player("Link");
Player p2 = new Player("Zelda");

Player p3 = new Player(p2);




p3.AllowForNameChange("Ganondorf");


//Console.WriteLine(p1.GetHealh());

p1.Rebirth();

//Console.WriteLine($"Player 1's name is {p1.Name}");
//Console.WriteLine($"Player 1's health is {p1.Health}");

Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);



//p1.Name = "Zelda"; // This line will cause a compilation error because Name has an init-only setter."


//Make changes to my super new code stuff!!!!!!!!!!!!!!!!!!
