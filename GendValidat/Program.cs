//rakendus küsib kasutajal valida tema sugu (m/f)
//rakendus küsib kasutajaö sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi]" / "Welcome, Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Please, selecet your gender (m/f):");

char userGender = char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string (sõne) formaadis
Console.WriteLine("Please, enter your last name:");
string UsLName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {UsLName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms.{UsLName}!");
}
else
{
    Console.WriteLine($"Welcome, {UsLName}!");
}
