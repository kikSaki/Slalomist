

using Slalomist;

List<(int y, int x0, int x1)> ovire = new List<(int y, int x0, int x1)>{  (1, 1, 3), (1, 5, 6), (1, 8, 8), (1, 10, 10),
                             (2, 5, 6), (2, 13, 16),
                             (4, 9, 11), (4, 13, 14),
                             (5, 1, 3), (5, 15, 17),
                             (6, 5, 6), (6, 8, 9),
                             (7, 12, 13),
                             (8, 10, 10),
                             (9, 1, 2), (9, 14, 16),
                             (10, 4, 4), (10, 12, 12),
                             (11, 17, 17),
                             (12, 13, 15),
                             (13, 1, 5), (13, 7, 11), (13, 17, 17),
                             (14, 16, 16),
                             (15, 3, 4), (15, 10, 11),
                             (16, 15, 15),
                             (17, 2, 3), (17, 5, 9), (17, 11, 13), (17, 16, 16)};


//Steza steza = new Steza(17, 18, ovire);
//Console.WriteLine(steza.zaprto(10, 1));
//var item = steza.konec(9, 10, '^');
//Console.WriteLine($"({item.x}, {item.y})");

/*
AvtonomniKolesar kolesar = new AvtonomniKolesar(12, 1, new Steza(17, 18, ovire), "><<>><>");
Console.WriteLine(kolesar.ToString());
kolesar.premik();
Console.WriteLine(kolesar.ToString());
kolesar.premik();
Console.WriteLine(kolesar.ToString());
kolesar.premik();
Console.WriteLine(kolesar.ToString());
kolesar.premik();
Console.WriteLine(kolesar.ToString());
kolesar.premik();
Console.WriteLine(kolesar.ToString());
kolesar.premik();
Console.WriteLine(kolesar.ToString());
kolesar.premik();
Console.WriteLine(kolesar.ToString());
kolesar.premik();
Console.WriteLine(kolesar.ToString());
kolesar.premik();
Console.WriteLine(kolesar.ToString());
kolesar.premik();
Console.WriteLine(kolesar.ToString());
kolesar.premik();
Console.WriteLine(kolesar.ToString());
kolesar.premik();
Console.WriteLine(kolesar.ToString());
kolesar.premik();
Console.WriteLine(kolesar.ToString());
kolesar.premik();
Console.WriteLine(kolesar.ToString());
*/

/*
VzvratniKolesar kolesar = new VzvratniKolesar(11, 1, new Steza(19, 17, ovire));
Console.WriteLine(kolesar.ToString());
kolesar.premik('>');
Console.WriteLine(kolesar.ToString());
kolesar.nazaj();
Console.WriteLine(kolesar.ToString());
kolesar.nazaj();
Console.WriteLine(kolesar.ToString());
kolesar.nazaj();
Console.WriteLine(kolesar.ToString());
*/


/*
PametniKolesar kolesar = new PametniKolesar(12, 1, new Steza(17, 18, ovire));
(int prevozeno, String pot) najmanj = kolesar.nacrt();
Console.WriteLine($"{najmanj.prevozeno}, {najmanj.pot}");
Console.WriteLine(kolesar.ToString());
*/

Console.ReadKey();