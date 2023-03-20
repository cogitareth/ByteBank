using fastFood.Clientes;
using fastFood.Endereços;
using fastFood.Itens;
using fastFood.Pedidos;

Pedido pedido1 = new Pedido();

Item itens1 = new Item();

itens1.item1 = "Hamburguer";
itens1.item2 = "Batatas";
itens1.item3 = "Refrigerante";

Cliente cliente1 = new Cliente();

cliente1.nome = "Geralt";
cliente1.email = "geraltderivia@gmail.com";
cliente1.cpf = "333.333.555-55";

Endereco endereco1 = new Endereco();

endereco1.rua = "Estrado Noroeste";
endereco1.bairro = "Nobre";
endereco1.cidade = "Novigrad";
endereco1.cep = "454.899-3";
endereco1.numero = 20;

pedido1.cliente = cliente1;
pedido1.endereco = endereco1;
pedido1.itens = itens1; 
pedido1.valorDoPedido = 45.85;

Console.WriteLine($"Nome: {cliente1.nome}");
Console.WriteLine($"Email: {cliente1.email}");
Console.WriteLine($"CPF: {cliente1.cpf}");
Console.WriteLine($"Bairro: {endereco1.bairro}");
Console.WriteLine($"Cidade: {endereco1.cidade}");
Console.WriteLine($"CEP: {endereco1.cep}");
Console.WriteLine($"Número: {endereco1.numero}");
Console.WriteLine($"Item 1: {itens1.item1}");
Console.WriteLine($"Item 2: {itens1.item2}");
Console.WriteLine($"Item 3: {itens1.item3}");
Console.WriteLine($"Valor total: R${pedido1.valorDoPedido}");

