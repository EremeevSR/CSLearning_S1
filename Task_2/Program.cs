/*Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел.
Например: 2, 3, 7 -> 7 */

//Условимся на интерактивный ввод трех целочисленных значений.
int [] numbers = new int[3];
int max = 0;
Console.WriteLine("Введите три числа:");
for (int i = 0; i < 3; i++){
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    if (max < numbers[i]) max = numbers[i];
}
Console.WriteLine("Max = " + Convert.ToString(max));