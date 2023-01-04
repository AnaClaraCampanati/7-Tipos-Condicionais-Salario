// Faça um algoritmo que calcule e exiba o salário reajustado de 3 funcionários de acordo com a seguinte regra: Salário até 300, reajuste de 50%; Salários maiores que 300, reajuste de 30%.

Console.WriteLine("Digite o salário do primeiro funcionário:");
double salario1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o salário do segundo funcionário:");
double salario2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o salário do terceiro funcionário:");
double salario3 = Convert.ToDouble(Console.ReadLine());

double salarioReajustado = 0;

if (salario1 <= 300)
{
    salarioReajustado = (salario1 * 0.5 + salario1);
    Console.WriteLine("Sálario reajustado: " + salarioReajustado);
}
if (salario1 > 300)
{
    salarioReajustado = (salario1 * 0.3 + salario1);
    Console.WriteLine("Salário reajustado: " + salarioReajustado);
}
if (salario2 <= 300)
{
    salarioReajustado = (salario2 * 0.5 + salario2);
    Console.WriteLine("Sálario reajustado: " + salarioReajustado);
}
if (salario2 > 300)
{
    salarioReajustado = (salario2 * 0.3 + salario2);
    Console.WriteLine("Salário reajustado: " + salarioReajustado);
}
if (salario3 <= 300)
{
    salarioReajustado = (salario3 * 0.5 + salario3);
    Console.WriteLine("Sálario reajustado: " + salarioReajustado);
}
if (salario3 > 300)
{
    salarioReajustado = (salario3 * 0.3 + salario3);
    Console.WriteLine("Salário reajustado: " + salarioReajustado);
}
