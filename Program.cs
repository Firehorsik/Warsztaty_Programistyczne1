/*//Zadanie 1
Console.Write("Cześć! Jestem ");
Console.WriteLine("Patryk Duba");
Console.WriteLine("Kierunek: Informatyka");
Console.WriteLine("Chcę się nauczyć programowania");

//Zadanie 2
string name = "Patryk";
int age = 20;
string game = "Doom Eternal";
Console.WriteLine("+--------------------------+");
Console.WriteLine("|       WIZYTÓWKA          |");
Console.WriteLine("+--------------------------+");
Console.WriteLine($"| Imie: {name}             |");
Console.WriteLine($"| Wiek:  {age}                |");
Console.WriteLine($"| Gra: {game}        |");
Console.WriteLine("+--------------------------+");

//Zadanie 3
string name2;
string color;
Console.Write("Jak masz na imię? ");
name2 = Console.ReadLine();
Console.Write("Jaki jest twój ulubiony kolor? ");
color = Console.ReadLine();
Console.Write($"Cześć {name2}! ");
Console.WriteLine($"{color} to twój ulubiony kolor.");

//Zadanie 4
int age2;
Console.Write("Podaj swój wiek: ");
age2 = int.Parse(Console.ReadLine());
age2++;
Console.Write($"Za rok będziesz mial {age2} lat, ");
age2 += 4;
Console.WriteLine($"a za 5 lat {age2}");

//Zadanie 5
int dni;
int trasa;
int ckm;
Console.Write("Kilometry do celu: ");
trasa = int.Parse(Console.ReadLine());
Console.Write("Kilometry pokonywane codziennie: ");
ckm = int.Parse(Console.ReadLine());
dni = trasa / ckm;
Console.WriteLine($"Trasa: {trasa}");
Console.WriteLine($"Codzienne kilometry: {ckm}");
Console.WriteLine($"dni: {dni}");

//Zadanie 6
int zm = 100;
int sm = 10;
int mm = 1;
int a;
int suma;

Console.Write("Złote monety: ");
a = int.Parse(Console.ReadLine());
zm *= a;

Console.Write("Srebrne moenty: ");
a = int.Parse(Console.ReadLine());
sm *= a;

Console.Write("Miedziane monety: ");
a = int.Parse(Console.ReadLine());
mm *= a;

suma = zm + sm + mm;
Console.WriteLine($"Wartość sakiewki: {suma}");

//Zadanie 7
int mikstury;
int krysztaly = 3;
int ziola = 2;
Console.Write("Mikstury: ");
mikstury = int.Parse(Console.ReadLine());
krysztaly *= mikstury;
ziola *= mikstury;
Console.WriteLine("SKŁADNKI");
Console.WriteLine($"Kryształy: {krysztaly}");
Console.WriteLine($"Zioła: {ziola}");

//Zadanie 8
decimal cena;
int noce;
decimal koszt;

Console.Write("cena: ");
cena = decimal.Parse(Console.ReadLine());

Console.Write("Noce: ");
noce = int.Parse(Console.ReadLine());

koszt = cena * noce;

Console.WriteLine($"Koszt: {koszt}");

//Zadanie 9
int s;
int m = 0;

Console.Write("Sekundy: ");
s = int.Parse(Console.ReadLine());

m = s / 60;
s = s % 60;

Console.Write($"Czas: {m} minuty i ");
Console.Write($"{s} sekundy");

//Zadanie 10
int monety;
int bohaterowie;
int przydzial;
int pozostale;

Console.Write("Monety: ");
monety = int.Parse(Console.ReadLine());
Console.Write("Bohaterowie: ");
bohaterowie = int.Parse(Console.ReadLine());

przydzial = monety / bohaterowie;
pozostale = monety % bohaterowie;

Console.Write($"Każdy dostanie po {przydzial} monet. ");
Console.WriteLine($"{pozostale} zostanie");

//Zadanie 11
int dmg;
int p;
int la;
int ha;
int combo;

Console.Write("Dmg: ");
dmg = int.Parse(Console.ReadLine());

Console.Write("Premia do ataku: ");
p = int.Parse(Console.ReadLine());

la = dmg + p;
ha = la * 2;
combo = 3*la + ha;

Console.WriteLine($"Zwykły atak zadaje {la} obrażeń");
Console.WriteLine($"Specjalny atak zadaje {ha} obrażeń");
Console.WriteLine($"Combo zadaje zadaje {combo} obrażeń");*/

