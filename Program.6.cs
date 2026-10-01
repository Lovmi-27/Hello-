Console.WriteLine("Podaj cene za jedną noc");
decimal cena = decimal.Parse(Console.ReadLine());
Console.WriteLine("Podaj ilość nocy");
int iLoscNocy = int Parse(Console.ReadLine());
decimal koszt = cena * iloscNocy;
Console.WriteLine($"Koszt pobytu wynosi: {koszt}zł")