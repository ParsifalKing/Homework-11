List<string> names = new List<string>{ "Yusuf", "Msstafo", "Sabriddin"  };

var name = names.FindAll( elem => elem.Length == 5 );

foreach (var item in name)
{
    System.Console.WriteLine(item);
}
