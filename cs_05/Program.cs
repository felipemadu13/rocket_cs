Console.WriteLine("Digite a placa do carro de acordo com o padrão antigo");
Console.WriteLine("Ex: ABC1234");
var placa = Console.ReadLine().Replace(" ", "");
var inicias = placa[..3];
var finais = placa[3..];
bool valid = true;


if (placa.Length != 7) {
    Console.WriteLine("Quantidade de caracteres errada");
    valid = false;
}

if (int.TryParse(inicias, out var valor)) {
    Console.WriteLine("Os primeiros três digitos devem ser letras");
    valid = false;
}

if (!int.TryParse(finais, out var valor2)) {
    Console.WriteLine("Os quatro digitos finais devem ser números");
    valid = false;
}

if (valid == true) {
    Console.WriteLine("Verdadeiro");
} else {
    Console.WriteLine("Falso");
}