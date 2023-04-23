// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
// 452 -> 11 
// 82 -> 10 
// 9012 -> 12 
 
int num = GetNumberFromUser("Введите число: ", "Ошибка ввода!"); 
int result = GetSumNumbers(num); 
Console.WriteLine($"{num} -> {result}"); 
 
int GetSumNumbers(int num) 
{ 
    int advance = 0; 
    int result = 0; 
    while(num > 0) 
    { 
        advance = num - num % 10; 
        result = result + (num - advance); 
        num = num / 10; 
    }   
    return result; 
}
