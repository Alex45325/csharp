/*
напишите программу, котораяна вход принимает число и выдаёт
его квадрат (число умноженное на само себя).

*/

System.Console.WriteLine("Введите число"); //cw -Быстрый вызов Console Writeline
int userNumber = Convert.ToInt32(Console.ReadLine());

int result = userNumber * userNumber;

System.Console.WriteLine(result);
System.Console.WriteLine(userNumber * userNumber);