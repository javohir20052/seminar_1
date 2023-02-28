// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

/*int number = new Random().Next(10, 100); // от 10 до 99 включительно
// new Random().Next(100); // от 0 до 99

int firstValue = number / 10; // 78 / 10 = 7 (/ - деление)
int secondValue = number % 10; // 78 % 10 = 8 (% - остаток)

int max = firstValue; // Пусть максимум - первое число

if (secondValue > max) // Если второе число больше максимума, то максимум уже не максимален
// {
//     max = secondValue; 
//     // максимум = второе число (max = 7,secondValue = 8: 8 > 7, max = secondValue(8))
// }
*/
// Console.WriteLine("Максимальная цифра в числе " + number + " = " + max);
// int number = new Random().Next(10, 100); // от 10 до 99 включительно
// // new Random().Next(100); // от 0 до 99

// int firstValue = number / 10; // 78 / 10 = 7 (/ - деление)
// int secondValue = number % 10; // 78 % 10 = 8 (% - остаток)

// int max = firstValue; // Пусть максимум - первое число

// if (secondValue > max) // Если второе число больше максимума, то максимум уже не максимален
// {
//     max = secondValue; 
//     // максимум = второе число (max = 7,secondValue = 8: 8 > 7, max = secondValue(8))
// }
// // Способ №1. Конкатенация - процесс сложения строчек
// Console.WriteLine("Максимальная цифра в числе " + number + " = " + max);
// // Способ №2. Интерполяция
// // Console.WriteLine($"Текст {переменная/выражение} текст");
// Console.WriteLine($"Максимальная цифра в числе: {number} = {max}");

// 11. Напишите программу, которая выводит
// случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

/*int randomValue = new Random().Next(100, 1000); // [100, 999]

int result = ((randomValue / 100) * 10) +  (randomValue % 10) * 1;

Console.WriteLine("Способ №1. Конкатенация. " + randomValue + " -> " + result);

Console.WriteLine($"Способ №2. Интерполяция. {randomValue} -> {result}");
*/
// 12. Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1,
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber % secondNumber == 0)
// {
//     Console.WriteLine($"Число {firstNumber} делится на {secondNumber} без остатка");
// }
// elserm
// {
//     Console.WriteLine($"Число {firstNumber} делится на {secondNumber} С ОСТАТКОМ");
//     Console.WriteLine($"Остаток: {firstNumber % secondNumber}");
// }

// 14. Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Write("Введите  число : ");
int number = Convert.ToInt32(Console.ReadLine());
// "&&" - оператор "И" - Shift + 7 на англ. раскладке
// "||"  - оператор "ИЛИ" 
if (number % 7 == 0 && number % 23 == 0  )
{
    Console.WriteLine($"Число {number} кратно 7 и 23");
}

else
{
    Console.WriteLine($"Число {number} НЕ кратно 7 и 23");
    Console.WriteLine($"Число {number} при делении на 7 дает остаток {number % 7}");
    Console.WriteLine($"Число {number} при делении на 23 дает остаток {number % 23}");
}

# привет гитхабytyhjnregfhgu