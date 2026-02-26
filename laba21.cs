Console.Write("Введіть кількість рядків: ");
if (!int.TryParse(Console.ReadLine(), out int r) || r <= 0)
{
     Console.WriteLine("Помилка вводу.");
     return;
}
int числа = r * 10;
List<int> список = new List<int>(числа);
for (int i = 1; i <= числа; i++) список.Add(i);
for (int i = 0; i < числа; i += 10)
{
    bool чиЗворотнє = (i / 10) % 2 != 0;
    for (int j = 0; j < 10; j++)
    {
         int index = чиЗворотнє ? i + 9 - j : i + j;
         Console.Write(список[index] + "\t");
    }
    Console.WriteLine();
}
