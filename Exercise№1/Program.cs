int size = GetNumber("Enter the size of your array ");
int[] array = new int [size];
FillArray(array);
PrintArray(array);
CountNumbers(array);

void CountNumbers(int[] array1)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($" -> {count}");
}


void FillArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        array[i] = GetNumber("Enter a number for your array ");
    }
}


void PrintArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write(array1[i] + " ");
    }
}


int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}