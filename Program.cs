/*
// 34 задача
int [] RandomArray(int size)
{
    int [] array = new int [size];
    
    for (int i = 0; i < array.Length ; i++)
    {
        array [i] = new Random().Next(100,1000);

    }    
    return array;
}

void ShowArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");

    Console.WriteLine();    
}

int PlusAmountArray (int[] array)
{
    int amount = 0;

    for( int i = 0; i < array.Length; i++)
        if(array [i] % 2 == 0) amount++ ;

    return amount;    

}
Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] MyArray = RandomArray(size);
ShowArray(MyArray);
Console.WriteLine("количество четных чисел" + " " + PlusAmountArray(MyArray));
*/
/*
// 36 задача
int [] RandomArray(int size)
{
    int [] array = new int [size];
    
    for (int i = 0; i < array.Length ; i++)
    {
        array [i] = new Random().Next(-10, 11);

    }    
    return array;
}
void ShowArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");

    Console.WriteLine();    
}
int SumOfOdds(int [] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 != 0) sum += array[i]; 
         
        }
    return sum;    
}


Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] MyArray = RandomArray(size);
ShowArray(MyArray);
Console.WriteLine("сумма нечетных элементов" + " " + SumOfOdds(MyArray));
*/

// 38 задача
double [] RandomArray(int size, int min, int max)
{
    double [] array = new double [size];
    
    for (int i = 0; i < array.Length ; i++)
    {
       array[i] = new Random().Next(min, max +1) + new Random().NextDouble();

    }    
    return array;
}
void ShowArray(double [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");

    Console.WriteLine();    
}

double Difference(double [] array)
{
    double max = array[0];
    double min = array[0];

     
        for (int i = 0; i < array.Length; i++)
           { 
            if (max < array[i]) max = array[i];

            if (min > array[i]) min = array[i];
           } 

    Console.WriteLine("Максимальное значение массива: " + max);
    Console.WriteLine("Минимальное значение массива: " + min);

    double dif = max - min;
    dif = Math.Round(dif, 2);
    return dif;    
        
}
Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double [] MyArray = RandomArray(size, 1, 50);
ShowArray(MyArray);
Console.WriteLine("Разница в " + " " + Difference(MyArray));


