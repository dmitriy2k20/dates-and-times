using System;

namespace Additional_classes_and_structures
{
    class Program
    {
        /*  static void SortAscending(int[] intArray)
          {
              int indx; 
              for (int i = 0; i < intArray.Length; i++) 
              {
                  indx = i; 
                  for (int j = i; j < intArray.Length; j++) 
                  {
                      if (intArray[j] < intArray[indx])
                      {
                          indx = j;
                      }
                  }
                  if (intArray[indx] == intArray[i])
                      continue;

                  int temp = intArray[i]; 
                  intArray[i] = intArray[indx];
                  intArray[indx] = temp;
              }
          }
          static void SortDescending(int[] intArray)
          {
              int indx;
              for (int i = 0; i < intArray.Length; i++)
              {
                  indx = i;
                  for (int j = i; j < intArray.Length; j++)
                  {
                      if (intArray[j] > intArray[indx])
                      {
                          indx = j;
                      }
                  }
                  if (intArray[indx] == intArray[i])
                      continue;

                  int temp = intArray[i];
                  intArray[i] = intArray[indx];
                  intArray[indx] = temp;
              }
          }
          static int[] ConcatArrays(int[] a, int[] b)
          {
              int[] c = new int[a.Length + b.Length];
              for (int i = 0; i < a.Length; i++) 
                  c[i] = a[i];
              for (int i = a.Length; i < a.Length + b.Length; i++) 
                  c[i] = b[i - a.Length]; 
              return c;
          }
          static void Main(string[] args)
          {
              int[] a = new int[5] { 2, 4, 5, 1, 4 };
              int[] b = new int[5] { 9, 1, 4, -1, 2 };
              SortAscending(a); 
              SortDescending(b); 
              int[] c = ConcatArrays(a, b);
              foreach (int i in c)
                  Console.Write($"{i} ");*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: "); 
            int n = Convert.ToInt32(Console.ReadLine()); 
          
            int result;
            if (n > 123)
                result = (n - 123) * 3; 
            else
                result = 123 - n; 
            Console.WriteLine(result);
        }
    }
}


