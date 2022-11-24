/* Напишите программу, 
которая принимает на вход два 
числа и проверяет, является ли одно число 
квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет*/

Console.WriteLine("write number 1:");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("write number 2:");
int number_2 = int.Parse(Console.ReadLine());
if (number*number == number_2 || number_2*number_2 == number){
    Console.Write("Yes");
}
else{
    Console.Write("No");
}