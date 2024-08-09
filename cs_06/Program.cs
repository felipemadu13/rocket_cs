
using System.Globalization;

DateTime data = DateTime.Now;

string dataCompleta = data.ToString("dddd, dd/MM/yyyy HH:mm:ss", new CultureInfo("pt-BR"));
string apenasData = data.ToString("dd/MM/yyyy", new CultureInfo("pt-BR"));
string apenasHoras = data.ToString("hh:mm tt", new CultureInfo("pt-BR"));
string mesExtenso = data.ToString("dd MMMM yyyy", new CultureInfo("pt-BR"));

Console.WriteLine(dataCompleta);
Console.WriteLine(apenasData);
Console.WriteLine(apenasHoras);
Console.WriteLine(mesExtenso);

