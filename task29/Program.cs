// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33] 
 
 
var random = new Random(); 
 
int length = 8; 
int count = 0; 
int[] array = new int[8]; 
while(count < length) 
{ 
    int randomNumber = random.Next(1, 11); 
    array[count] = randomNumber; 
    count++; 
} 
Console.Write("[ "); 
 
for(int i = 0; i < 8; i++) 
{ 
    Console.Write(array[i]+ " "); 
} 
Console.Write("]"); 
Console.WriteLine();
