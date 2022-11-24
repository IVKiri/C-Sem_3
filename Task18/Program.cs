// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

string [] quarters = {"x > 0; y > 0",
                      "x < 0; y > 0",
                      "x < 0; y < 0",
                      "x > 0; y < 0"
};
Console.Write("Введите номер четверти: ");
int quater = Convert.ToInt32(Console.ReadLine());

if (quater >= 1 && quater <= 4) {
    Console.WriteLine(quarters[quater-1]);
}