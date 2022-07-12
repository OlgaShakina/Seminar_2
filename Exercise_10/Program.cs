// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");
int n=Convert.ToInt32(Console.ReadLine());
if (n%100==0){
    Console.WriteLine("Число меньше 100");
}
else{Console.WriteLine(Convert.ToString(n)[2]);
}
