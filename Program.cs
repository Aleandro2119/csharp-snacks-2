// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




//SNACK 1
//Scrivere un codice csharp che crea un accumulatore e poi lo utilizza
//Esempio: var accumulatore1 = CreaAccumulatore();
//accumulatore1(10) => 10
//accumulatore1(40) => 50
//accumulatore1(90) => 140

var Maker = () =>
{
    long totale = 0;
    return (int n) =>
    {
        totale += n;
        return totale;
    };
};

var acc1 = Maker();
var acc2 = Maker();

Console.WriteLine(acc1(10));
Console.WriteLine(acc1(10));
Console.WriteLine(acc1(10));
Console.WriteLine(acc1(10));
Console.WriteLine(acc1(10));
Console.WriteLine(acc1(10));

//SNACK 2
//Data una lista di interi, metterli tutti al quadrato

List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
List<int> lsquare = MettiAlQuadrato(list);
foreach (int n in lsquare)
    Console.WriteLine(n);

List<int> MettiAlQuadrato(List<int> list)
{
    List<int> lout = new List<int>();
    foreach (int n in list)
        lout.Add(n * n);
    return lout;
}

//SNACK 3
//Data una lista di interi, metterli tutti al cubo

List<int> li = new List<int>() { 1, 2, 3, 4, 5, 6 };
List<int> lcube = MettiAlCubo(li);
foreach (int n in lcube)
    Console.WriteLine(n);

List<int> MettiAlCubo(List<int> li)
{
    List<int> lout = new List<int>();
    foreach (int n in li)
        lout.Add(n * n * n);
    return lout;
}

// Funzione generale per trasformare tutti gli elementi di una stringa
// da un numero intero a numero intero

List<int> EseguiIlCalcolo(List<int> li, Func<int, int> fun)
{
    List<int> lout = new List<int>();
    foreach (int n in li)
        lout.Add(fun(n));
    return lout;
}
int MettiAllaQuinta(int i)
{
    return i * i * i * i * i;
}
List<int> lquinta = EseguiIlCalcolo(li, MettiAllaQuinta);
foreach (int n in lquinta)
    Console.WriteLine(n);
List<int> lcalcolo = EseguiIlCalcolo(li, (n) => n * (n + 1) / 2);
foreach (int n in lcalcolo)
    Console.WriteLine(n);


//ordinare una lista di interi
li = new List<int>() { 8, 4, 67, 12, 43, 91, 0, 1, 2, 3, 5, 5 };
li.Sort();
li.Reverse();  //se la volessi al contrario
foreach (int n in li)
    Console.WriteLine(n);
Console.WriteLine("\n\n\n\n");
li = new List<int>() { 8, 4, 67, 12, 43, 91, 0, 1, 2, 3, 5, 5 };
li.Sort((int v1, int v2) =>
{
    if (v1 < v2)
        return -1;
    if (v1 == v2)
        return 0;
    else
        return 1;
});
foreach (int n in li)
    Console.WriteLine(n);
//crescente
Console.WriteLine("\n\n\n\n");
li = new List<int>() { 8, 4, 67, 12, 43, 91, 0, 1, 2, 3, 5, 5 };
li.Sort((int v1, int v2) =>
{
    if (v1 < v2)
        return 1;
    if (v1 == v2)
        return 0;
    else
        return -1;
});
foreach (int n in li)
    Console.WriteLine(n);

// SNACK 4
//Data la lista di stringhe {"uno", "due", "tre", "quattro", "cinque", "Sei"}
//ordinarla e stamparla in verso decrescente

List<string> lstr = new List<string>() { "uno", "due", "tre", "quattro", "cinque", "Sei" };
SortedSet<string> ords = new SortedSet<string>();
foreach (string v in lstr)
    ords.Add(v);
foreach (string v in ords)
    Console.WriteLine(v);

// 2
Console.WriteLine("\n\n\n\n");
lstr = new List<string>() { "uno", "due", "tre", "quattro", "cinque", "Sei" };
lstr.Sort();
lstr.Reverse();
foreach (String s in lstr)
    Console.WriteLine(s);

// 3
Console.WriteLine("\n\n\n\n");
lstr = new List<string>() { "uno", "due", "tre", "quattro", "cinque", "Sei" };
lstr.Sort((string s1, string s2) => -s1.CompareTo(s2));
foreach (String s in lstr)
    Console.WriteLine(s);

//SNACK 5    
//Data una lista di coppie <DateTime, int>, stamparle ordinate, dalla meno recente
//alla data più recente, una coppia in csharp si dichiara come Tuple<string, int>
// quindi una lista di coppie sarà

List<Tuple<string, int>> lcoppie = new List<Tuple<string, int>>()
{

    new Tuple<string, int>("uno", 1), 
    new Tuple<string, int>("due", 21), 
    new Tuple<string, int>("quattro", 41), 
    new Tuple<string, int>("sette", 71), 
    new Tuple<string, int>("diciannove", 191)};



lcoppie.Sort((s2, s1) => s2.Item1.CompareTo(s1.Item1));
foreach (Tuple<string, int> s in lcoppie)
    Console.WriteLine($"{ s.Item1} con  { s.Item2}");


//double microseconds = DateTime.Now.Ticks / (TimeSpan.TicksPerMillisecond / 1000.0);
//Console.WriteLine("microseconds: {0}", microseconds);

Console.WriteLine("\n\n\n\n\nLCOPPIE");
lcoppie.Sort();
lcoppie.ForEach(x => Console.WriteLine(x));

Console.WriteLine(String.Join("\t", lcoppie));


//Ok, allora ordiniamo per il secondo campo della tutpla (il numero intero)
lcoppie.Sort((t1, t2) => t1.Item2.CompareTo(t2.Item2));
Console.WriteLine(String.Join("\t", lcoppie));

lcoppie.Sort();
lcoppie.Sort((t1, t2) => t1.Item2 - t2.Item2);
Console.WriteLine(String.Join("\t", lcoppie));

List<Tuple<int, int, int>> lterne = new List<Tuple<int, int, int>>()
{
    new Tuple<int, int, int>(1, 2, 3),
    new Tuple<int, int, int>(5, 5, 2),
    new Tuple<int, int, int>(2, 4, 11),
    new Tuple<int, int, int>(12, 15, 21),
    new Tuple<int, int, int>(55, 45, 32),
    new Tuple<int, int, int>(1, 2, 4),
    new Tuple<int, int, int>(1, 3, 0),
    new Tuple<int, int, int>(5, 5, 1)
};

lterne.Sort();
Console.WriteLine(String.Join("\t", lterne));

//Se volete verificare la velocità di una parte del codice
double microseconds = DateTime.Now.Ticks / (TimeSpan.TicksPerMillisecond / 1000.0);
Console.WriteLine("microseconds: {0}", microseconds);



