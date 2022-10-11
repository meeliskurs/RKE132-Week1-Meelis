// This is a comment to my code

//rakendus küsib kasutajalt tema nime  
//rakendus tervitab kasutajat nimepidi
Console.WriteLine("Enter your name:"); //output
//string - sõne
string userName;


userName = Console.ReadLine();  //input

Console.WriteLine("Hello" + ", " + userName + "!");  //output
//string interpolation

Console.WriteLine($"Hello, {userName}!");  //output
    