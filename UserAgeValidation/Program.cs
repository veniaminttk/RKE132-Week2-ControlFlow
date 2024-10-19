//rakendus küsib kasutajal valida tema sugu (m/f)
//rakendus küsib kasutajaö sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi]" / "Welcome, Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Please, selecet your gender (m/f):");

char usGen = char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string (sõne) formaadis
Console.WriteLine("Please, enter your last name:");
string usLName = Console.ReadLine();

if(usGen == 'm')
{
    Console.WriteLine($"Welcome, Mr. {usLName}!");
}
else if(usGen == 'f')
{
    Console.WriteLine($"Welcome, Ms.{usLName}!");
}
else
{
    Console.WriteLine($"Welcome, {usLName}!");
}
