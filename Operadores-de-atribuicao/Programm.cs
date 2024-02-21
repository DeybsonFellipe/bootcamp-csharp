
// OPERADORES DE ATRIBUIÇÃO



// Introdução ao operador de atribuição

int a = 10;
int b = 20;

int c = a + b;

c = c + 5;

Console.WriteLine(c);



// Convertendo tipos de variáveis
// (Variáveis) -> Cast
// Convertendo uma string para um inteiro

int a = Convert.ToInt32("5");

// Outra maneira de conversão é:

int a = int.Parse("5");

Console.WriteLine(a);




// Diferença entre Convert e Perse

// Parse dar erro ao ser nulo
// Convert retorna 0 ao ser nulo




// Conversão para string

int inteiro = 5;

string a = inteiro.ToString();

Console.WriteLine(a);




// Cast implícito 
//(Conversão natural) pois o doubole recebe um int e o long também. 

int a = 5;
double b = a;

int a = 5;
long b = a;

Console.WriteLine(a);



// Ordem dos opperadores
// Para decidir qual operação será feita primeiro usamos os ().

double a = 4 / (2 + 2);

Console.WriteLine(a);




// Conversões de maneira segura 
// Out indica a saída da conversão

string a = "15-";

int b = 0;

int.TryParse(a, out b);

Console.WriteLine(b);
