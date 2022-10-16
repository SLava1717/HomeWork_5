void InputArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
      array[i] = new Random().Next(-10, 10);
}


int ReleaseArray(int[] array)
{
   int sum = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (i % 2 == 1)
         sum = sum + array[i];
   }
   return sum;
}

Console.Clear();
int[] array = new int[4];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.Write(ReleaseArray(array));
