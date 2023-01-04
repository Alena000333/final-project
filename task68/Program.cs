// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Funct(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Funct(m - 1, 1);
  else return Funct(m - 1, Funct(m, n - 1));
}

Console.WriteLine("Введите m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n:");
int n = Convert.ToInt32(Console.ReadLine());

int functionAckerman = Funct(m, n);
Console.Write($"Функция Аккермана = {functionAckerman} ");