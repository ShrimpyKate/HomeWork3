//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int number = 15978;
int N = 0;

while(number > 0) 
{

N = N * 10 + number % 10;
number = number / 10;

}
 Console.WriteLine(N);