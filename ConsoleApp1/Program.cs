// See https://aka.ms/new-console-template for more information

//string path = Path.GetFullPath("d1.jpeg");
//Console.WriteLine("@" + path);
//Console.WriteLine(path);
string fileName = "d1.jpeg";
string path = Path.GetFullPath(fileName);
string newpath = path.Replace(@"\", @"\\");
Console.WriteLine(newpath);
Console.ReadKey();