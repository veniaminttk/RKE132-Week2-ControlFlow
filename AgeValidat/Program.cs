//rakendus küsib kasutajal sisestada tema vanuse
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
//"You are too young to use Instagram"
//muul juhul
//konsoolis kuvatakse "Welcome to Instagram"

Console.WriteLine("Enter your age:");

string usAge = Console.ReadLine();

int usAgeNum = 0;

//boolean - true/false

bool isAgeNum = Int32.TryParse(usAge, out usAgeNum);

//int usAge = Int32.Parse(Console.ReadLine()); // "13" - heap, 13 - stack

//if (usAge >= 13)
//{
//    Console.WriteLine("Welcome to Instagram!");
//}

//else if (UsAge == 13)
//{
//    Console.WriteLine("Welcome to Instagram!");

//else
//{
//    Console.WriteLine("You are too young to use Instagram.");
//}

Console.WriteLine($"Parse result {isAgeNum}. User is {usAgeNum} years old.");

if(isAgeNum == true)
{
    if (usAgeNum > 13)
    { Console.WriteLine("Welcome to IG."); }
    else
    { Console.WriteLine("You are too young to use IG."); }
}
else
{
    Console.WriteLine("Could not read ur age.");
}