//MarcoCarvalho.fibonacci();

Carro c1 = new Carro();
Carro c2 = new Carro();
c1.placa = "asd4561";
c2.placa = "ert4563";

Carro.valor = 10;

Console.WriteLine(c1.placa);
Console.WriteLine(Carro.valor);
Console.WriteLine(c2.placa);
Console.WriteLine(Carro.valor);

Pessoa p1 = new Pessoa();
p1.Nome = "Marco Carvalho";
p1.Altura = 1.8;
Console.WriteLine(p1.Nome);
Console.WriteLine(p1.Altura);

// foreach (int item in MarcoCarvalho.Sequencia) {
//     Console.WriteLine(item);
// }

Carro c3 = new Carro("wer4569");
Console.WriteLine(c3.placa);

Livro l1 = Livro.getLivro();
Console.WriteLine(Livro.Contador);