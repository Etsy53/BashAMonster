using System;

Mario newMario = new Mario();
Goomba newGoomba = new Goomba();

Console.WriteLine($"Goomba HP: {newGoomba.HP}");
Console.WriteLine($"Mario HP: {newMario.HP}");

Console.WriteLine("press button to attack goomba");
Console.ReadKey(true);

newGoomba.HP -= 100;

Console.WriteLine($"Goomba HP: {newGoomba.HP}");

Console.WriteLine("congrats you've defeated the goomba!");
Console.ReadKey(true);
