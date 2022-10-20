




internal class Program
{
    enum Keys
    {
        BubbleSorting,
        SelectionSorting,
        InsertionSorting
    }

    private static void Main(string[] args)
    {
        ////BubbleSorting();
        ////SelectionSorting();
        ////InsertionSorting();

        
        Console.WriteLine("Choose the method of sorting: ");
        Console.WriteLine("Press B for bubble sorting");
        Console.WriteLine("Press S for selection sorting");
        Console.WriteLine("Press I for insertion sorting");
        ConsoleKey key = Console.ReadKey().Key;
        Console.WriteLine("You're entered " + key);
        switch (key)

        {
            case ConsoleKey.B:
                Console.WriteLine("Start bubble sorting");
                var bubbleSorting = Keys.BubbleSorting;
                BubbleSorting();
                break;
                Console.ReadKey();

            case ConsoleKey.S:
                Console.WriteLine("Start selection sorting");
                var selectionSorting = Keys.SelectionSorting;
                SelectionSorting();
                break;
                Console.ReadKey();

            case ConsoleKey.I:
                Console.WriteLine("Start insertion sorting");
                var insertionSorting = Keys.InsertionSorting;
                InsertionSorting();
                break;
                Console.ReadKey();

        }


        int arrayValue = 0;

       static int[] InputArray()
        {
            Console.Write($"Enter number of values in array: \t");

            int elements = int.Parse(Console.ReadLine());
            int[] myArray = new int[elements];


            for (int i = 0; i < elements; i++)
            {
                Console.Write($"Enter element of array number {i + 1}: \t");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n You're entered next array  : ");
            Console.WriteLine($"////////////////////////////////////////");
            Console.WriteLine();

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.WriteLine();
            Console.WriteLine($"////////////////////////////////////////");
            
            return myArray;
        }


       int[] BubbleSorting()
        {
            int[] myArray = InputArray();

            Console.WriteLine("\n Sorting array with bubble method  : ");
            Console.WriteLine($"////////////////////////////////////////");
            Console.WriteLine();


            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray.Length - 1; j++)
                {
                    if (myArray[j] > myArray[i] + 1)
                    {
                        arrayValue = myArray[j];
                        myArray[j] = myArray[j + 1];
                        myArray[j + 1] = arrayValue;
                    }
                }

            }

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.WriteLine();
            Console.WriteLine($"/////////////////////////////////////////");
            return myArray;
        }


        static int[] SelectionSorting()
        {

            int[] myArray = InputArray();

            Console.WriteLine("\n Sorting array with selection method  : ");
            Console.WriteLine($"////////////////////////////////////////");
            Console.WriteLine();

            int temp, min;
            for (int i = 0; i < myArray.Length; i++)

            {
                min = i;
                for (int j = i + 1; j < myArray.Length; j++)
                {

                    if (myArray[j] < myArray[min])
                    {
                        min = j;
                    }

                }

                temp = myArray[min];
                myArray[min] = myArray[i];
                myArray[i] = temp;
            }




            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.WriteLine();
            Console.WriteLine($"////////////////////////////////////////");
            return myArray;
        }


        static int[] InsertionSorting()
        {

            int[] myArray = InputArray();

            Console.WriteLine("\n Sorting array with insertion method  : ");
            Console.WriteLine($"////////////////////////////////////////");
            Console.WriteLine();

            int j, min;
            for (int i = 1; i < myArray.Length; i++)

            {
                min = myArray[i];

                j = i - 1;

                while (j >= 0 && myArray[j] > min)
                {
                    myArray[j + 1] = myArray[j];
                    j = j - 1;
                }

                myArray[j + 1] = min;

            }

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.WriteLine();
            Console.WriteLine($"////////////////////////////////////////");
            return myArray;
        }

    }
    
}