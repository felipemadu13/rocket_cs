
Console.WriteLine("Digite o primeiro número");
double n1 = Double.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número");
double n2 = Double.Parse(Console.ReadLine());


Console.WriteLine("A soma é: " + (n1 + n2));
Console.WriteLine("A subtração é: " + (n1 - n2));
Console.WriteLine("A multiplicação é: " + (n1 * n2));
if (n2 == 0) {
    Console.WriteLine("Divisão por zero não é permitida");
} else {
    Console.WriteLine("A Divisão é: " + (n1 / n2));
}

Console.WriteLine("A média é: " + ((n1 + n2)/2));