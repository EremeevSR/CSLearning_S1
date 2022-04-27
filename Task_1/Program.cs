/* Задача 1
Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее. Например: a = 5; b = 7 -> max = 7.
*/

//При решении задачи условимся на
//интерактивный ввод целочисленных значений.
Console.WriteLine("Введите два числа:");
int firstVar = Convert.ToInt32(Console.ReadLine());
int secondVar = Convert.ToInt32(Console.ReadLine());
if (firstVar > secondVar) {
    Console.Write("max = ");
    Console.WriteLine(firstVar);
}
else {
    Console.Write("max = ");
    Console.WriteLine(secondVar);
}