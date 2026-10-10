
using Pilares_POO;
using PIlares_POO;

Carro carro1 = new Carro("Hyundai", "HB20" );
Console.WriteLine(carro1.Marca);
Console.WriteLine(carro1.Modelo);

//Metodo-Construtor - Obriga o objeto a ser criado de uma forma
//Pilares POO
//Evitar estados invalidos
//Encapsulamento - protege classes. atributos e métodos
//public, inter e private são encapsulamentos
//public - Acessado de qualquer lugar
//private Acessar de dentro da classe
//inter - Acessar do projeto
ContaBancaria conta1 = new ContaBancaria();
//conta1.Saldo = -500; (exemplo de algo que daria errado)

//Exercicios Fundamentais de Metodo Contrstrutor
//1. Livro

Livro livro1 = new Livro("Senhor dos Anéis", "Tolken", 400);
Livro livro2 = new Livro("Diario de um Banana", "Greg Raffley", 211);

livro1.Exibir();
livro2.Exibir();

//2. Viagem
Viagem viagemFoda = new Viagem("Fortaleza", 10, 69.99);

viagemFoda.Exibir();

//3. contato (dois metodos contrutor)
Contato c1 = new Contato("Samuel", "(11) 98705-1553", "samuel.ffiuza@gmail.com");
Contato c2 = new Contato("Bruno", "(21) 98888-1111");

c1.Exibir();
c2.Exibir();