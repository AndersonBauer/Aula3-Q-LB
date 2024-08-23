Console.WriteLine("Digite o primeiro numero: ");

double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo numero: ");

double num2 = Convert.ToDouble(Console.ReadLine());

double sub = num1 - num2;
double adc = num1 + num2;
double div = num1 / num2;
double mult = num1 * num2;

Console.WriteLine($"A subtração de {num1} - {num2} = {sub:F2}");

Console.WriteLine("A adição de {0} + {1} = {2}", num1, num2, adc);

Console.WriteLine($"A divisão de {num1} / {num2} = {div:F2}");

Console.WriteLine($"A multiplicação de "+ num1 + " X " + num2 + " = " + mult);
