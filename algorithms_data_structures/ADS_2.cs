//"Пространственная" сложность.

public int Sum(int n)
{
    if (n <= 0)
    {
        return 0;
    }
    else
    {
        return n + Sum(n - 1);
    }
}

// У данного алгоритма просраннственная сложность O(n)
// Из-за рекурсии будет n количество вызовов в стек.

//Другой пример.

public int pairSumSequence(int n)
{
    int sum = 0;
    for ( int i = 0; i < n; i++)
    {
        sum += pairSum(i, i + 1);
    }
    return sum;
}
public int pairSum(int a, int b)
{
    return a + b;
}

// pairSum будет вызвано O(n) раз, одннако затраты памяти 
// будут O(1).

//Вопрос сколько памяти занимает вызов метода?