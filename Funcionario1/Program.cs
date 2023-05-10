using Funcionario1;
using System.Globalization;
Funcionario func = new Funcionario(); /// declaração 

Console.WriteLine("Entre com o nome do funcionario");
func.Nome = Console.ReadLine();
Console.WriteLine("Salário Bruto: ");
func.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine("Digite o valor do imposto");
func.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine();
Console.WriteLine("Funcionario: "+func);
Console.WriteLine();
Console.WriteLine("Deseja aumentar o salário em qual porcentagem?");
double porcent = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
func.AumentarSalario(porcent);
Console.WriteLine();
Console.WriteLine("Dados Atualizados " + func);

//////  a porcentagem é adicionada do  salario bruto e retornando o valor liquido;