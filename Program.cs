Console.Write("Введите первое натуральное число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
void SumNuber(int M)
{
    sum += M;
    M++;
    if(M > N)
    {
        Console.Write($"Сумма натуральных чисел: {sum}");
        return;
    }
    SumNuber(M);
}
SumNuber(M);