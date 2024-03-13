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

// Girar moeda.
// int randonNumber = new Random().Next(0,2);
// Console.WriteLine($"Número: {randonNumber}");
// Console.WriteLine($"Moeda: {(randonNumber == 0 ? "Cara" : "Coroa")}");

string permission = "Admin|Manager";
int level = 55;
// Se o usuário tiver permissão de administrador e o nível for maior que 55, exiba "Welcome Super Admin user"; caso for um administrador com nivel menor ou igual a 55 exiba "Welcome Admin"; caso for um gerente com um nivel maior ou igual a 20 exiba "Contact an Admin for acess" se o usuário for um gerente com um nível menor que 20 exiba "You do not have sufficient privileges.", se o usuário não for um administrador nem um gerente exiba "You do not have sufficient privileges.".

// string message = permission.Contains("Admin") ? level > 55 ? "Welcome Super Admin user" : "Welcome Admin" : permission.Contains("Manager") && level >= 20 ? "Contact an Admin for acess" : permission.Contains("Manager") && level < 20 ? "You do not have sufficient privileges." : "You do not have sufficient privileges."; 
// esse código esta muito confuso, vamos simplificar.
string permission = "Admin|Manager";
int level = 53;
// utilizar o ternário de forma aninha é muito confuso, vamos utilizar o if-else.

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}

Console.WriteLine(message); // Welcome Admin