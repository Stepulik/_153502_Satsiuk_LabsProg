using Task_1;


var glass = new Beer("Jhatetskiy gus", 220, 12, 300);
Console.WriteLine($"cost of glass of {glass.Name} : {glass.cost}");
Console.WriteLine($"strenght of {glass.Name} : {glass.strenght}%");
Console.WriteLine($"volume of glass {glass.volume}");
glass.pour();
glass.callFriends(false);
glass.drink();

Console.WriteLine("\n");

var glass1 = new Whisky("BlackJesus", 750, 34, 110);
Console.WriteLine($"cost of glass of {glass1.Name} : {glass1.cost}");
Console.WriteLine($"strenght of {glass1.Name} : {glass1.strenght}%");
Console.WriteLine($"volume of drink {glass1.volume}");
glass1.pour();
glass1.addice();
if (glass1.whithice) 
    Console.WriteLine("Add ice into whisky");
Console.WriteLine($"strenght of {glass1.Name} : {glass1.strenght}%");
Console.WriteLine($"volume of drink {glass1.volume}");
glass1.depression();
glass1.drink();

Console.Write('\n');

var glass2 = new AlcoholMix(42, 150);
glass2.isNormal = false;
Console.WriteLine($"strenght of Alcohol Mix : {glass2.strenght}%");
Console.WriteLine($"volume of drink {glass2.volume}");
glass2.pour();
glass2.drink();



Console.WriteLine("\n");
Alcohol alc = new AlcoholMix(13, 400);
alc.pour();