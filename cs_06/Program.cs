
using System.Globalization;

DateTime data = DateTime.Now;

Console.WriteLine("Escolha um formato de data:");
Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
Console.WriteLine("2 - Apenas a data no formato \"dd/MM/yyyy\"");
Console.WriteLine("3 - Apenas a hora no formato de 24 horas");
Console.WriteLine("4 - Data com o mês por extenso");

var formatoEscolhido = Console.ReadLine();

 if (formatoEscolhido == "1")
        {
            string dataCompleta = data.ToString("dddd, dd/MM/yyyy HH:mm:ss", new CultureInfo("pt-BR"));
            Console.WriteLine(dataCompleta);
        }
        else if (formatoEscolhido == "2")
        {
            string apenasData = data.ToString("dd/MM/yyyy", new CultureInfo("pt-BR"));
            Console.WriteLine(apenasData);
           
        }
        else if (formatoEscolhido == "3")
        {
            string apenasHoras = data.ToString("hh:mm", new CultureInfo("pt-BR"));
            Console.WriteLine(apenasHoras);
            
        }
        else if (formatoEscolhido == "4")
        {
            string mesExtenso = data.ToString("dd MMMM yyyy", new CultureInfo("pt-BR"));
            Console.WriteLine(mesExtenso);
        }
        else
        {
            Console.WriteLine("Opção inválida");
        }












