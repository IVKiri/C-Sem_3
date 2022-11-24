// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int counter = 1;
double powN = 1;

while (counter < N+1) {
    powN = Math.Pow(counter, 2);
    Console.WriteLine(powN);
    counter++;
}
