// Задача 25: Напишите цикл, который принимает на вход два числа  
// (A и B и возводит число A в натуральную степень B. 
// 3, 5 -> 243 (3⁵) 
// 2, 4 -> 16 
 
int a = FirstGetNumberFromUser("Введите первое число: ", "Ошибка ввода!"); 
int b = SecondGetNumberFromUser("Введите второе число: ", "Ошибка ввода!"); 
int result = numbersDigits(a, b); 
Console.WriteLine($"{a}, {b} -> {result}"); 
 
int numbersDigits(int a, int b) 
{ 
   int res = a; 
while(b > 1)   
    { 
        res *= a;  
        b--; 
    } 
    return res; 
} 
 
 
int FirstGetNumberFromUser(string message, string errorMessage)  
{ 
    while(true) 
    { 
        Console.Write(message); 
 
        if(int.TryParse(Console.ReadLine(), out int userNumber)) 
            return userNumber; 
 
        Console.WriteLine(errorMessage); 
    } 
} 
 
int SecondGetNumberFromUser(string message, string errorMessage)  
{ 
    while(true) 
    { 
        Console.Write(message); 
 
        if(int.TryParse(Console.ReadLine(), out int userNumber)) 
            return userNumber; 
 
        Console.WriteLine(errorMessage); 
    } 
}
