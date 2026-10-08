
using exercicios;

Pessoa pessoa1 = new();
Pessoa pessoa2 = new();

pessoa1.nome = " weslley ";
pessoa1.idade = 55 ;

pessoa2.nome = "eduardo";
pessoa2.idade = 60;


pessoa1.ExibirInformacoes();
pessoa2.ExibirInformacoes();




//### Exercício 2: Retângulo

//Crie a classe `Retangulo` com:

//-Atributos: `Largura` e `Altura` (números com casas decimais).
//- Método `CalcularArea()`, que **retorna * *a área (largura × altura).
//- Método `CalcularPerimetro()`, que **retorna * *o perímetro (2 × (largura + altura)).

//Os métodos não devem usar `Console.WriteLine`: quem mostra o resultado é o `Program.cs`.

//**Saída esperada** (largura 5, altura 3):

//```
//Área: 15
//Perímetro: 16
//```


//💡

//**Dica:**método com retorno usa o tipo no lugar de `void`: `public double CalcularArea() { return ...; }`

Retangulo retangulo1 = new Retangulo();





retangulo1.altura = 3;
retangulo1.largura = 5;
Console.WriteLine(retangulo1.CalcularArea());
Console.WriteLine(retangulo1.CalcularPerimetro());




retangulo1.CalcularArea();
retangulo1.CalcularPerimetro();


//Crie a classe `Lampada` com:

//-Atributo: `Ligada` (`bool`).
//- Métodos: `Ligar()`, `Desligar()`, `Alternar()` (se está ligada, desliga; se está desligada, liga) e `ExibirEstado()`.

//Crie uma lâmpada e chame, nesta ordem: `ExibirEstado()`, `Ligar()`, `ExibirEstado()`, `Alternar()`, `ExibirEstado()`.

//**Saída esperada: **

//```
//A lâmpada está desligada.
//A lâmpada está ligada.
//A lâmpada está desligada.
//```