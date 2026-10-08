using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace exercicios
{
    public class Retangulo
    {
        public double largura;
        public double altura;

        public double perimetro;

        public double area;

        public double  CalcularArea()
        {

       
            double v = largura * altura;
            return v;
        }

        public double  CalcularPerimetro() 
        {

            
         double i = (2 * (largura +  altura));
         return i;
        }
    }
}
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
