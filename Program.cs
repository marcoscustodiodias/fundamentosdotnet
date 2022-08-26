using fundamentosdotnet.Models;


int numero = 5;
int contador = 0;

while (contador <= 10)
{
   Console.WriteLine($"{contador + 1}º Execução: {numero} X {contador} = {numero * contador}");
   contador++;
}












// int numero = 5;


// for(int contador = 0; contador <= 10; contador++)
// {
//    Console.WriteLine($"{numero} X {contador} = {numero * contador}");
// }





//Calculadora calc = new Calculadora();

// calc.Somar(10,30);
// calc.Subtrair(10,50);
// calc.Multiplicar(15,45);
// calc.Dividir(2,2);
// calc.Potencia(3,3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
//   calc.RaizQuadrada(9); 

// int numero = 10;

// Console.WriteLine(numero);

// Console.WriteLine("Incrementando o 10");
//numero = numero + 1;
// numero++;

// Console.WriteLine(numero);






// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar um outro dia.");
// }





// bool possuiPresencaMinima = true;
// double media = 7.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }
















// using fundamentosdotnet.Models;



// bool possuiPresencaMinima = true;
// bool media = 7.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }








// bool eMaiorDeIdade = true;
// bool possuiAutorizacaoDoResponsavel = false;

// if (eMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada");
// }




// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();



// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;

//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }





// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();


// if (letra == "a"||
//     letra == "e"||
//     letra == "i"||
//     letra == "o"||
//     letra == "u")
    
//     {
//         Console.WriteLine("Vogal");
//     }
//     else
//     {
//         Console.WriteLine("Não é uma vogal");
//     }











// int quantidadeEmEstoque = 3;

// int quantidadeCompra = 0;

// bool possívelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possívelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda Inválida");
// }
// else if (possívelVenda)
// {
//     Console.WriteLine("Venda realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }










//double a = 4 / 2 + 2;

//Console.WriteLine(a);

//int a = 5;
//double b = a;


// int a = 5;
// long b = a;

// Console.WriteLine(b);


// int inteiro = 5;
// string a = inteiro.ToString();





// Console.WriteLine(a);






//Cast - Casting
//int a = Convert.ToInt32("5");


// int a = int.Parse("5");

// Console.WriteLine(a);





// int a = 10;
// int b = 20;

// int c = a + b;

// c = c + 5; // 30 + 5

// c += 5;

// C = C - 5
// c -= 5;

// Console.WriteLine(c);







//DateTime dataAtual = DateTime.Now;
//Console.WriteLine(dataAtual);




//string apresentar = "Olá, seja bem vindo";

//int quantidade = 1;

//double altura = 1.80;

//decimal preco = 1.80M;

//bool condicao = true;

//Console.WriteLine(apresentar);
//Console.WriteLine("Valor da variável quantidade: "+ quantidade);
//Console.WriteLine("Valor da variável quantidade: "+ altura);
//Console.WriteLine("Valor da variável quantidade: "+ preco);
//Console.WriteLine("Valor da variável quantidade: "+ condicao);





//Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "Dias";
//pessoa1.Idade = 45;
//pessoa1.Apresentar();

