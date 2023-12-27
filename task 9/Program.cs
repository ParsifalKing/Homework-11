List<double> doubles = new List<double>{ 2.1 , 4.5 , 7.8};

doubles.AddRange(new[] { 10.15, 20.75 });

foreach (var doub in doubles)
{
    System.Console.WriteLine(doub);
}
System.Console.WriteLine("-------------");


doubles.Add(4.35);
foreach (var doub in doubles)
{
    System.Console.WriteLine(doub);
}

