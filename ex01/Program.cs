//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//
int GetNumberByUser(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

int ReverseNum(int number)
{
  int N = 0;
  while (number > 0)
  {
    N = N * 10 + number % 10;
    number = number / 10;
  }
  return N;
}

int number = GetNumberByUser("Введите число: ");
int reversedNumber= ReverseNum(number);
if (number == reversedNumber)
{
  Console.WriteLine("число является палиндром");
}
else
{
  Console.WriteLine("Число не является палиндромом");
}
