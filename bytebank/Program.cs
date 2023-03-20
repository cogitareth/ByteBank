using bytebank.Contas;
using bytebank.Titular;

//ContaCorrente contaDoAndre = new ContaCorrente();

//contaDoAndre.titularConta = "André Silva";
//contaDoAndre.numeroAgencia = 15;
//contaDoAndre.conta = "1010-X";
//contaDoAndre.saldoConta = 100;

//Console.WriteLine($"Titular da conta: {contaDoAndre.titularConta}");
//Console.WriteLine("Saldo da conta: R$" + contaDoAndre.saldoConta);
//Console.WriteLine("Numero da agencia: " + contaDoAndre.numeroAgencia);
//Console.WriteLine("Código da conta" + contaDoAndre.conta);


//contaDoAndre.depositar(300);

//Console.WriteLine("Saldo da conta do André pós depósito: R$" + contaDoAndre.saldoConta);

//if (contaDoAndre.saque(50) == true)
//{
//    Console.WriteLine($"Saldo da conta do André pós saque: R${contaDoAndre.saldoConta}");
//}

//else
//{
//    Console.WriteLine("Você não tem dinheiro o suficiente para este saque!");
//}

//ContaCorrente contaDaMaria = new ContaCorrente();

//contaDaMaria.titularConta = "Maria Souza";
//contaDaMaria.numeroAgencia = 17;
//contaDaMaria.conta = "1010-5";
//contaDaMaria.saldoConta = 300;

//Console.WriteLine("Saldo da conta da Maria: R$" + contaDaMaria.saldoConta);
//Console.WriteLine("Numero da agencia da Maria: " + contaDaMaria.numeroAgencia);
//Console.WriteLine("Código da conta da Maria: " + contaDaMaria.conta);
//Console.WriteLine("Saldo da conta da Maria: " + contaDaMaria.saldoConta);

//contaDoAndre.transferir(50, contaDaMaria);

//Console.WriteLine($"Saldo do André pós transferência: R${contaDoAndre.saldoConta}");
//Console.WriteLine($"Saldo da Maria pós transferência: R${contaDaMaria.saldoConta}");

//ContaCorrente contaDoPedro = new ContaCorrente();
//contaDoPedro.titularConta = "Pedro Silva";
//Console.WriteLine(contaDoPedro.titularConta);
//Console.WriteLine(contaDoPedro.saldoConta);
//Console.WriteLine(contaDoPedro.numeroAgencia);
//Console.WriteLine(contaDoPedro.conta);

//Cliente cliente = new Cliente();

//cliente.nome = "André Silva";
//cliente.cpf = "123.456.789-10";
//cliente.profissao = "Analista de Sistemas";


//ContaCorrente conta1 = new ContaCorrente();

//conta1.titularConta = cliente;
//conta1.conta = "1010-X";
//conta1.numeroAgencia = 15;
//conta1.saldoConta = 100;

//Console.WriteLine($"Nome do Titular: {conta1.titularConta.nome}");
//Console.WriteLine($"CPF do titular: {conta1.titularConta.cpf}");
//Console.WriteLine($"Profissão do titular: {conta1.titularConta.profissao}");
//Console.WriteLine($"Número da conta: {conta1.conta}");
//Console.WriteLine($"Número da agência: {conta1.numeroAgencia}");
//Console.WriteLine($"Saldo: R${conta1.saldoConta}");

//ContaCorrente conta2 = new ContaCorrente();

//conta2.titularConta = new Cliente();

//conta2.titularConta.nome = "José Souza";
//conta2.titularConta.cpf = "273.244.654.90";
//conta2.titularConta.profissao = "Tester";
//conta2.conta = "1015-Y";
//conta2.numeroAgencia = 16;
//conta2.saldoConta = 200;

//Console.WriteLine($"Nome do Titular: {conta2.titularConta.nome}");
//Console.WriteLine($"CPF do titular: {conta2.titularConta.cpf}");
//Console.WriteLine($"Profissão do titular: {conta2.titularConta.profissao}");
//Console.WriteLine($"Número da conta: {conta2.conta}");
//Console.WriteLine($"Número da agência: {conta2.numeroAgencia}");
//Console.WriteLine($"Saldo: R${conta2.saldoConta}");

//ContaCorrente conta3 = new ContaCorrente();
//conta3.Numero_agencia = 18;
//conta3.setSaldo(-10);
//conta3.Conta = "1011-H";
//Console.WriteLine(conta3.getSaldo());
//Console.WriteLine(conta3.Numero_agencia);
//Console.WriteLine(conta3.Conta);

//ContaCorrente conta4 = new ContaCorrente(18, "1020-U");

//conta4.setSaldo(500);
//conta4.Titular = new Cliente();

//Console.WriteLine(conta4.getSaldo());
//Console.WriteLine(conta4.Numero_agencia);
//Console.WriteLine(conta4.Conta);

ContaCorrente conta5 = new ContaCorrente(283, "1234-X");
Console.WriteLine(ContaCorrente.totalDeContas);

ContaCorrente conta6 = new ContaCorrente(284, "9874-Z");
Console.WriteLine(ContaCorrente.totalDeContas);

ContaCorrente conta7 = new ContaCorrente(285, "1171-Z");
Console.WriteLine(ContaCorrente.totalDeContas);