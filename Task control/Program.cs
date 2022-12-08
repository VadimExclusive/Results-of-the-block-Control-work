string[] CreateArray(int size)
{
    string[] array = new string[size];
    Console.WriteLine("Creating array: ");
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input {i + 1} element of array: ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    Console.WriteLine("Complete!");
    return array;
}

void ShowArray(string [] array)
{
    Console.WriteLine("The array you created:");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array [i] + ", ");
    Console.WriteLine();
}

void ChangeArray(string [] array)
{
    Console.WriteLine("Your array has been changed:");
    for(int i = 0; i < array.Length; i++)
        if(array[i].Length <= 3)
            Console.Write(array [i] + ", ");
    Console.WriteLine();
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateArray(size);
ShowArray(myArray);
ChangeArray(myArray);