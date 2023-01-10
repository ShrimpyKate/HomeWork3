//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int N = 0;
int temp = number;

while (number > 0)
{

  N = N * 10 + number % 10;
  number = number / 10;
}
if (temp == N)
{
  Console.WriteLine("число является палиндром");
}
else
{
  Console.WriteLine("Число не является палиндромом");
}


