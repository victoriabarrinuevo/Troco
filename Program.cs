Console.WriteLine("--Calculando troco de compra--");

Console.WriteLine("Digite o valor de sua compra: ");
double compra = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("digite o valor pago: ");
double valorpg = Convert.ToDouble(Console.ReadLine());

double troco = (valorpg - compra);

Console.WriteLine($"Seu troco é igual à:{troco:N2}");