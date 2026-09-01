using CaO;
using System.Numerics;


Player p1 = new Player("Link");
Player p2 = new Player("Link");

Player p3 = p2;

//Console.WriteLine(p1.GetHealh());

p1.Health = 100;

Console.WriteLine($"Player 1's name is {p1.Name}");
Console.WriteLine($"Player 1's health is {p1.Health}");


//p1.Name = "Zelda"; // This line will cause a compilation error because Name has an init-only setter."
