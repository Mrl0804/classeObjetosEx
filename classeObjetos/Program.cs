using classeObjetos;

//! Exercício 1
// Pessoa p1 = new Pessoa();

// p1.Nome = "Murilo";
// p1.Idade = 17;
// p1.Cidade = "São Paulo";

// p1.Apresentar();

// Pessoa p2 = new Pessoa();

// p2.Nome = "Venicius";
// p2.Idade = 18;
// p2.Cidade = "Mauá";

// p2.Apresentar();


//! Exercício 2
Calculadora calc = new Calculadora();
double a = 10;
double b = 0;

Console.WriteLine($"Soma: {calc.Somar(a, b)}");
Console.WriteLine($"Subtração: {calc.Subtrair(a, b)}");
Console.WriteLine($"Multiplicação: {calc.Multiplicar(a, b)}");

Console.WriteLine($"Divisão: {Calculadora.Dividir(a, b)}");

Console.WriteLine();


