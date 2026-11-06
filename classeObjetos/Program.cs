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
// Calculadora calc = new Calculadora();
// double a = 10;
// double b = 0;

// Console.WriteLine($"Soma: {calc.Somar(a, b)}");
// Console.WriteLine($"Subtração: {calc.Subtrair(a, b)}");
// Console.WriteLine($"Multiplicação: {calc.Multiplicar(a, b)}");

// Console.WriteLine($"Divisão: {Calculadora.Dividir(a, b)}");

// Console.WriteLine();

//! Exercício 3
// Veiculo carro = new Veiculo();

// carro.Velocidade = 50;
// Console.WriteLine($"Velocidade: {carro.Velocidade} km/h");

// carro.Velocidade = 250;
// Console.WriteLine($"Velocidade: {carro.Velocidade} km/h");

// carro.Velocidade = -20;
// Console.WriteLine($"Velocidade: {carro.Velocidade} km/h");

// Console.WriteLine();

//! Exercício 4
Funcionario func = new Funcionario("João", "Desenvolvedor", 2500m);
func.ConsultarSalario();
func.AumentarSalario(10);
func.ConsultarSalario();

Console.WriteLine();

//? o "set" de salario é privado, então não podemos alterar diretamente o salário fora da classe Funcionario

//! Exercício 5
Livro l1 = new Livro();
Livro l2 = new Livro("Dom Quixote");
Livro l3 = new Livro("O Alquimista", "Paulo Coelho");
Livro l4 = new Livro("1984", "George Orwell", 328);

l1.ExibirDados();
l2.ExibirDados();
l3.ExibirDados();
l4.ExibirDados();


