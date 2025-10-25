double peso;
double altura;
double imc;

string diagnostico;

Console.WriteLine("-- Calculadora de IMC --\n");

Console.Write("Digite seu peso em kg...:");
peso = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite sua altura em m..:");
altura = Convert.ToDouble(Console.ReadLine());

imc = peso / Math.Pow(altura, 2);

Console.WriteLine($"\nSeu IMC é {imc:F2}\n");

if (imc < 17)
{
    diagnostico = "Muito abaixo do peso";
}
else if (imc < 18.49)
{
    diagnostico = "Abaixo do peso";
}
else if (imc < 24.99)
{
    diagnostico = "Peso normal";
}
else if (imc < 29.9)
{
    diagnostico = "Sobrepeso";
}
else if (imc < 34.99)
{
    diagnostico = "Obesidade I";
}
else if (imc < 39.99)
{
    diagnostico = "Obesidade II (severa)";
}
else if (imc >= 40)
{
    diagnostico = "Obesidade III (mórbida)";
}
else
{
    diagnostico = "Valor de IMC inválido";
}
Console.WriteLine($"Diagnóstico: {diagnostico}");



