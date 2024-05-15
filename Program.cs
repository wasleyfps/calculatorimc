Console.Clear();
Console.WriteLine("Bem vindo a Calculadora IMC");


Console.WriteLine("Qual é a seu peso?");
var Weight = int.Parse(Console.ReadLine());

Console.WriteLine(Weight);

Console.WriteLine("Qual a sua altura?");
var Height = double.Parse(Console.ReadLine());

var Result = Weight / (Height * Height);

Console.WriteLine(Result);

if (Result < 18.5)
{
    Console.WriteLine("Magreza");
}
else if (Result <= 24.9)
{
    Console.WriteLine("Normal");
}
else if (Result <= 29.9)
{
    Console.WriteLine("Sobrepeso");
}
else if (Result <= 39.9)
{
    Console.WriteLine("Obesidade");
}
else
{
    Console.WriteLine("Obesidade Grave");
}
