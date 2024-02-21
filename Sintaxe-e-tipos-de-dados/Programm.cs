

// SINTAXE E INDENTAÇÃO

   // Usando a classe pessoa e explorando a sintaxe 

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Fellipe";
pessoa1.Idade = 22;
pessoa1.Apresentar();




// TIPOS DE DADOS

   // Manipulando variáveis
   // Váriaveis (nome) sempre em camelCase
   // Números com casas decimais 

string apresentacao = "Olá, seja bem vindo";

int quantidade = 1;

double altura = 1.80;

decimal preco = 1.80M;

bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável quantidade " + quantidade);
Console.WriteLine("Valor da variável altura " + altura.ToString("0.00"));
Console.WriteLine("Valor da variável preco " + preco);
Console.WriteLine("Valor da variável condicao " + condicao);



// O TIPO DATETIME

   // Estudo do datetime e manipulaçoes de data e hora

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);
