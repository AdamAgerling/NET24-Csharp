﻿
int x = 7;

if (x == 7)
{
    Console.WriteLine("x är exakt 7");
}
else if(x > 3 && x < 10)
{
    Console.WriteLine("x är inte 7, men mellan 3 och 10");
}
else
{
    Console.WriteLine("x är mindre än 4, eller större än 9");    
}


int y = 6;

if (y > 3)
{
    if (y < 10)
    {
        Console.WriteLine("y är mellan 3 och 10");
    }
}


// Ternary operator
Console.WriteLine(false ? "Japp!" : "Nope!");

x = 15;
y = (x < 10 ? 5 : 8);

// Ovanståend är samma som:
if (x < 10)
{
    y = 5;
}
else
{
    y = 8;
}

Console.WriteLine("y = " + y);


int numberOfPeople = 0;
Console.WriteLine($"{numberOfPeople} person{(numberOfPeople==1?"":"er")}");

// OBS! Undvik nestlade ternary operators.
y = (x < 10 ? 5 : (x > 20 ? 6 : 9));

