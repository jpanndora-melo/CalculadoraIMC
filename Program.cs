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
if (imc < 18.5)
{
    diagnostico = "Abaixo do peso";
}
else if (imc < 24.9)
{
    diagnostico = "Peso normal";
}
else if (imc < 29.9)
{
    diagnostico = "Sobrepeso";
}
else
{
    diagnostico = "Obesidade";
}

