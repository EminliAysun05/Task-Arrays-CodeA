namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Eyni reqemden yan-yana duplicate varsa, bunu bize bildirsin
            /* int[] numbers = { 1, 2, 3, 4,  5 };
             bool isDublicate = false;
             for (int i = 0; i < numbers.Length-1; i++)
             {
                 if (numbers[i] == numbers[i + 1]) {
                     isDublicate = true;
                     break;
                 }

             }
             if (isDublicate)
             {
                 Console.WriteLine("dublikat var");
             }
             else
             {
                 Console.WriteLine("dublikat yoxdur");
             }*/
            //Birinci array daxilinde olan butun reqemler, 2 ci array daxilinde var ay yox?
            /* int[] numbers = { 1, 2, 3, 4, 5, 6, 30 };

             int[] numbers2 = { 1, 2, 3, 4, 8, 5, 6 };
             bool isFound = true;

             for (int i = 0; i < numbers.Length; i++)
             {
                 bool result = false;
                 for (int j = 0; j < numbers2.Length; j++)
                 {
                     if (numbers[i] == numbers2[j])
                     {
                         result = true;
                         break;
                     }
                 }

                 if (result == false)
                 {
                     isFound = false;
                     break;
                 }
             }


             Console.WriteLine(isFound);*/

            //
            //Arrayin tersine cevrilmesi
            /* int[] arrays = { 1, 2, 3, 4, 5, };
             int[] reversedArray = new int[arrays.Length];
             for (int i = 0; i < arrays.Length; i++)
             {
                 reversedArray[i] = arrays[arrays.Length - 1 - i];
             }
             for (int i = 0;i < reversedArray.Length; i++)
             {
                 Console.WriteLine(reversedArray[i]);
             }*/
        }
    }
}
