using ByteBank.Funcionarios;
using ByteBank.Utilitario;

Funcionario pedro = new Funcionario();
pedro.Nome = "Pedro malazartes";
pedro.Cpf = "123456789";
pedro.Salario = 2000;

Diretor roberta = new Diretor();
roberta.Nome = "Roberta Silva";
roberta.Cpf = "987654321";
roberta.Salario = 5000;

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);

Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);