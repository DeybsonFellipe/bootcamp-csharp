using System.Runtime.InteropServices.Marshalling;
using EXEMPLOFUNDAMENTOS.Models;


// OPERADORES CONDICIONAIS 


// Introdução ao operador de atribuição
    // Determinada ação baseada em uma condição


// Operador condicional na prática
    // Uso do if e else  
    // if também funcionará com uma var booleana

int quantidadeEstoque = 10;
int quantidadeCompra = 4;
bool possívelVenda = quantidadeCompra > 0 && quantidadeEstoque >= quantidadeCompra;


Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
Console.WriteLine($"Quantidade de compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possívelVenda}");


if(quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida");
}

else if(possívelVenda)
{
    Console.WriteLine("Venda realizada");
}

else
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque");
}



// Debugando o operador condicional
  // Observando o código linha por linha ser executado



// If aninhado
  // É um terceiro caminho caso seja necessário (else if)
  // Funcionamento do if



// Aprendendo switch case
  // Vamos criar um script que vai indicar quando for uma vogal
    
Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

if (letra == "a")
{
    Console.WriteLine("Vogal");
}
else if (letra == "e")
{
    Console.WriteLine("Vogal");
}
else if (letra == "i")
{
    Console.WriteLine("Vogal");
}
else if (letra == "o")
{
    Console.WriteLine("Vogal");
}
else if (letra == "u")
{
    Console.WriteLine("Vogal");
}
else  
{
    Console.WriteLine("Nao e uma Vogal");
}



  // Utulizando if de maneira mais enxuta


Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();


if (letra == "a" ||
    letra == "e" ||
    letra == "i" ||
    letra == "o" ||
    letra == "u")
{
    Console.WriteLine("Vogal");
}
else 
{
    Console.WriteLine("Nao e vogal");
}



  // Utilizando Switch Case


Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();


switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;

    default:
        Console.WriteLine("Nao e uma vogal");
        break;

}
























