void InputArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
      array[i] = new Random().Next(99, 1000);
}


int ReleaseArray(int[] array)
{
   int sum = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] % 2 == 0)
         sum = sum + 1;
   }
   return sum;
}

Console.Clear();
int[] array = new int[5];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.Write(ReleaseArray(array));