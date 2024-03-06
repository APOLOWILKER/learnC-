/*
  * O operador condicional é uma forma compacta de escrever uma instrução if-else.
  * Ele é útil quando você deseja atribuir um valor a uma variável com base em uma condição.
  * 
  * O operador condicional é representado por um ponto de interrogação (?) e dois pontos (:).
  * 
  * A sintaxe do operador condicional é a seguinte:
  * 
  *      condition ? first_expression : second_expression;
  * 
  * Se a condição for verdadeira, a primeira expressão será avaliada e retornada; caso contrário, a segunda expressão será avaliada e retornada.
  * 
  * O operador condicional é frequentemente usado para atribuir um valor a uma variável com base em uma condição.
  * 
  *      int discount = saleAmount > 1000 ? 100 : 50;
  * 
  * O código acima atribui 100 à variável discount se saleAmount for maior que 1000; caso contrário, atribui 50.
  * 
  * O operador condicional também pode ser usado em uma expressão de saída para imprimir o valor de uma variável com base em uma condição.
  * 
  *      Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
  * 
  * O código acima imprime "Discount: 100" se saleAmount for maior que 1000; caso contrário, imprime "Discount: 50".
*/

int randonNumber = new Random().Next(0,2);
Console.WriteLine($"Número: {randonNumber}");
Console.WriteLine($"Moeda: {(randonNumber == 0 ? "Cara" : "Coroa")}");