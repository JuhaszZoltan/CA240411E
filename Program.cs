//StringKezeles01();
//StringKezeles03();
//StringKezeles04();
//StringKezeles05a();
//StringKezeles05b();
//StringKezeles06();
//StringKezeles09();
//StringKezeles10();
//StringKezeles11_12();
//StringKezeles13();
//StringKezeles14();
//StringKezeles15();
//StringKezeles16();
//StringKezeles17();
//StringKezeles18();
//StringKezeles20();
//StringKezeles21();
//StringKezeles22();
//StringKezeles23();
//StringKezeles24();
//StringKezelesMET();

void StringKezelesMET()
{
    string sor = "dolgok;pontosvesszővel;elválasztva";
    string[] adattagok = sor.Split(';');
    foreach (var adt in adattagok) Console.Write($"[{adt}] ");
    sor = "\t\t\n         cica \t       \t \n\n";
    Console.Write("\n");
    Console.WriteLine($"[{sor.Trim()}]");
    sor = "- ---  -   -- párduc!!!????";
    sor = sor.TrimStart('-', ' ').TrimEnd('!', '?', '.');
    Console.WriteLine(sor);
    Console.WriteLine(sor.StartsWith("pá"));
    Console.WriteLine(sor.EndsWith("lán"));
    string[] szinek = ["piros", "zöld", "kék"];
    string osszesSzin = string.Join('-', szinek);
    Console.WriteLine(osszesSzin);
}

void StringKezeles24()
{
    Random rnd = new();
    Console.CursorVisible = false;
    string szoveg = "Á r V í Z t Ű r Ő   T ü K ö R f Ú r Ó g É p";

    int startLeft = Console.WindowWidth / 2 - szoveg.Length / 2;
    Console.SetCursorPosition(startLeft, 0);
    Console.Write(szoveg);

    List<int> coords = [];
    for (int i = 0; i < szoveg.Length; i++)
        if (szoveg[i] != ' ') coords.Add(i);

    while (coords.Count > 0)
    {
        int charindex = coords[rnd.Next(coords.Count)];
        for (int row = 1; row < Console.WindowHeight / 2; row++)
        {
            Console.SetCursorPosition(startLeft + charindex, row - 1);
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine(' ');
            Console.ResetColor();
            Console.SetCursorPosition(startLeft + charindex, row);
            Console.Write(szoveg[charindex]);
            Thread.Sleep(50);
        }
        coords.Remove(charindex);
    }




}
void StringKezeles23()
{
    Random rnd = new();
    Console.CursorVisible = false;
    string szoveg = "ÁrVíZtŰrŐ TüKöRfÚrÓgÉp";

    int startLeft = Console.WindowWidth / 2 - szoveg.Length / 2;

    for (int i = 0; i < szoveg.Length; i++)
    {
        Console.SetCursorPosition(
            startLeft + i,
            Console.WindowHeight / 2);
        Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
        Console.Write(szoveg[i]);
        if (szoveg[i] != ' ') Thread.Sleep(300);
        Console.Clear();
    }

    Console.ResetColor();
    Console.CursorVisible = true;
}
void StringKezeles22()
{
    string szoveg =
        "Egy jómódú lányt szerettem,\n" +
        "osztálya elragadta tőlem.\n" +
        "Két naponként csak egyszer ettem\n" +
        "és gyomorbajos lett belőlem.\n" +
        "Éreztem, forgó, gyulladásos\n" +
        "gyomor a világ is és nyálkás,\n" +
        "gyomorbeteg szerelmünk, elménk\n" +
        "s a háború csak véres hányás.";

    Console.WriteLine($"szöveg:\n{szoveg}\n");

    szoveg = szoveg.ToLower();

    string kulombozo = string.Empty;
    foreach (var c in szoveg)
    {
        if (!kulombozo.Contains(c) && char.IsLetter(c))
            kulombozo += c;
    }

    Console.WriteLine("különböző betűk:");
    foreach (var c in kulombozo)
    {
        Console.Write($"{c}, ");
    }
    Console.WriteLine($"\nkülönböző betűk száma: {kulombozo.Length}");
}
void StringKezeles21()
{
    string[] szavak = ["juhász", "lyuk", "folyó", "hajó", "tojás"];

    Console.WriteLine("'j' vagy 'ly'? gépeld be a megoldást!\n");
    int pontszam = 0;
    for (int i = 0; i < szavak.Length; i++)
    {
        Console.Write(
            $"{i+1}.: " +
            $"{szavak[i].Replace('j', '_').Replace("ly", "_")}: ");

        string tipp = Console.ReadLine().ToLower();
        if (szavak[i].Contains(tipp))
        {
            Console.WriteLine("\thelyes!");
            pontszam++;
        }
        else
        {
            Console.WriteLine("\ttéves!");
            Console.WriteLine($"megoldás: {szavak[i]}");
        }
    }
    Console.WriteLine($"helyes megoldások száma: {pontszam}/{szavak.Length}");
    if (pontszam == szavak.Length)
        Console.WriteLine("gratulálok, hibátlan megoldás!");
}
void StringKezeles20()
{
    Console.Write("irányítószám: ");
    int irsz = int.Parse(Console.ReadLine());

    if ($"{irsz}"[0] != '1')
    {
        Console.WriteLine("nem budapesti az irányítószám");
    }
    else
    {
        int ker = int.Parse($"{irsz}"[1..3]);
        Console.WriteLine($"ez az irányítószám a {ker}. kerülethez tartozik");
    }
}
void StringKezeles18()
{
    Random rnd = new();
    string karakterek = "abcdefgh1234567890_!";

    for (int db = 0; db < 10; db++)
    {
        string jelszo = string.Empty;
        for (int i = 0; i < 8; i++)
        {
            jelszo += karakterek[rnd.Next(karakterek.Length)];
        }
        Console.WriteLine($"{db+1,2}. \"jelszó\": {jelszo}");
    }

}
void StringKezeles17()
{
    Console.Write("írj be valamit: ");
    string szo01 = Console.ReadLine();
    Console.Write("írj be még valamit: ");
    string szo02 = Console.ReadLine();

    char[] sb01 = szo01.ToLower().ToCharArray();
    Array.Sort(sb01);
    char[] sb02 = szo02.ToLower().ToCharArray();
    Array.Sort(sb02);

    if (new string(sb01) == new string(sb02)) Console.WriteLine("anagramma");
    else Console.WriteLine("nem anagramma");
}
void StringKezeles16()
{
    string szoveg = "ÁrVíZtŰrŐ TüKöRfÚrÓgÉp";
    Console.WriteLine($"szöveg: {szoveg}");

    char[] betuk = szoveg.ToCharArray();

    char[] abc = [
        'a', 'á', 'b', 'c', 'd', 'e',
        'é', 'f', 'g', 'h', 'i', 'í',
        'j', 'k', 'l', 'm', 'n', 'o',
        'ó', 'ö', 'ő', 'p', 'r', 's',
        't', 'u', 'ú', 'ü', 'ű', 'v', 
        'z'];

    for (int i = 0; i < betuk.Length - 1; i++)
    {
        for (int j = i; j < betuk.Length; j++)
        {
            char ib = char.Parse($"{betuk[i]}".ToLower());
            char jb = char.Parse($"{betuk[j]}".ToLower());

            if (Array.IndexOf(abc, ib) > Array.IndexOf(abc, jb))
            {
                (betuk[i], betuk[j]) = (betuk[j], betuk[i]);
            }
        }
    }

    Console.WriteLine($"karakterek ábécérendben: {new string(betuk)}");
}
void StringKezeles15()
{
    string szoveg = 
        "Miért legyek én tisztességes? Kiterítenek úgyis!\n" +
        "Miért ne legyek tisztességes? Kiterítenek úgyis.";

    Console.WriteLine($"eredeti szöveg: {szoveg}");
    Console.WriteLine($"szavanként:\n{szoveg.Replace(' ', '\n')}");
}
void StringKezeles14()
{
    string szoveg = "ÁrVíZtŰrŐ TüKöRfÚrÓgÉp";
    Console.WriteLine($"szöveg: {szoveg}");

    string ekezetes     = "áéíóöőúüűÁÉÍÓÖŐÚÜŰ";
    string ekezetMentes = "aeiooouuuAEIOOOUUU";
    string ekezetMentesSzoveg = string.Empty;

    foreach (var c in szoveg)
    {
        if (ekezetes.Contains(c))
        {
            int index = ekezetes.IndexOf(c);
            ekezetMentesSzoveg += ekezetMentes[index];
        }
        else ekezetMentesSzoveg += c;
    }
    Console.WriteLine($"ekezet mentes: {ekezetMentesSzoveg}");
}
void StringKezeles13()
{
    Console.Write("írj be valamit: ");
    string szoveg = Console.ReadLine().ToLower();

    string maganhangzok = "aáeéiíuúüűoóöő";

    int mghCount = 0;
    foreach (char c in szoveg)
    {
        if (maganhangzok.Contains(c)) mghCount++;
    }
    Console.WriteLine($"mghk száma: {mghCount}");
}
void StringKezeles11_12()
{
    Console.Write("írj be valamit: ");
    string szoveg = Console.ReadLine().ToLower();

    if (szoveg.Contains('j')) Console.WriteLine("van benne 'j'");
    else Console.WriteLine("nincs benne 'j'");

    if (szoveg.Contains("ly")) Console.WriteLine("van benne 'ly'");
    else Console.WriteLine("nincs benne 'ly'");
}
void StringKezeles10()
{
    Console.Write("írj be valamit: ");
    string szoveg = Console.ReadLine();

    Console.WriteLine($"{szoveg[..1].ToUpper()}{szoveg[1..]}");
}
void StringKezeles09()
{
    string szoveg = "ÁrVíZtŰrŐ TüKöRfÚrÓgÉp";
    Console.WriteLine($"eredeti: {szoveg}");
    Console.WriteLine($"kisbetűs: {szoveg.ToLower()}");
    Console.WriteLine($"nagybetűs: {szoveg.ToUpper()}");
}
void StringKezeles01()
{
    string nev = "Juhasz Zoltan Mate";

		for (int i = 0; i < nev.Length; i++)
		{
        Console.Write($"{nev[i]} ");
    }
}
void StringKezeles03()
{
    string nev = "Juhasz Zoltan Mate";

		for (int i = 0; i < nev.Length; i++)
		{
        for (int j = 0; j < i; j++)
        {
            Console.Write("  ");
        }
        Console.WriteLine($"{nev[i]}");
    }
}
void StringKezeles04()
{
    Console.Write("irj be valamit: ");
    string szo = Console.ReadLine();

    for (int i = 0; i < szo.Length+2; i++) Console.Write('*');
    Console.WriteLine($"\n*{szo}*");
    for (int i = 0; i < szo.Length+2; i++) Console.Write('*');
}
void StringKezeles05a()
{
    Console.Write("írj be valamit: ");
    string szo = Console.ReadLine();
    char[] szoBetui = szo.ToCharArray();
    Array.Reverse(szoBetui);
    szo = new(szoBetui);
    Console.WriteLine($"visszafelé: {szo}");
}
void StringKezeles05b()
{
    Console.Write("írj be valamit: ");
    string szo = Console.ReadLine();
    string forditott = "";
    for (int i = szo.Length-1; i >= 0; i--)
    {
        forditott += szo[i];
    }
    Console.WriteLine($"visszafelé: {forditott}");
}
void StringKezeles06()
{
    Console.Write("írj be valamit: ");
    string szo = Console.ReadLine().ToLower();

    int eCount = 0;
    for (int i = 0; i < szo.Length; i++)
    {
        if (szo[i] == 'e') eCount++;
    }
    //int eCount = szo.Count(c => c == 'e');
    Console.WriteLine($"'e' betűk száma: {eCount}");
}



Console.ReadKey(false);