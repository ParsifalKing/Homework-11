List<string> names = new List<string>{ "Yusuf", "Msstafo", "Sabriddin"  };

names.RemoveAt(1);

foreach (var name in names)
{
   System.Console.WriteLine(name); 
}