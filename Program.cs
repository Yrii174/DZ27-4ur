
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
System.Console.WriteLine("Введите число");
string s = Console.ReadLine(); 
int l = s.Length;
System.Console.WriteLine($"количество цифр в числе равно : {l}");
int result = 0;
for(int i=0; i<l; i++) 
{
result = result + int.Parse(s[i].ToString());
}
System.Console.Write($"Сумма цифр в числе равна: {result}");
