void InputArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
      array[i] = new Random().Next(0, 100);
}


int ReleaseArray(int[] array)
{
   int Max = array[0];
   int Min = array[0];
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] > Max)
         Max = array[i];
   
      if (array[i] < Min)
         Min = array[i];
   }
   return Max - Min;
}

Console.Clear();
int[] array = new int[6];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.Write(ReleaseArray(array));
