namespace AnyasPrinter {
    internal class Program {
        static void Main() {
            int[] numbers = { 0, 9, 4, 6, 5 };
            //PrintArrayValues(numbers);
                (string Name, int Grade)[] studentRecords = new (string, int)[]
             {
         ("Alice", 85),
         ("Bob", 92),
         ("Charlie", 78),
         ("Diana", 95),
         ("Ethan", 88),
         ("Fiona", 72),
         ("George", 90),
         ("Hannah", 83),
         ("Ian", 79),
         ("Julia", 91)
             };
                Console.WriteLine("Tuple Format");
                for (int i = 0; i < studentRecords.Length; i++) {
                    Console.WriteLine($"Student: {studentRecords[i].Name,-10} | Grade: {studentRecords[i].Grade}");
                }
                {
                    string[] studentNames = new string[10]
                    {
         "Alice", "Bob", "Charlie", "Diana", "Ethan",
         "Fiona", "George", "Hannah", "Ian", "Julia"
                    };
                    int[] studentGrades = new int[10]
                    {
         85, 92, 78, 95, 88,
         72, 90, 83, 79, 91
                    };
                    Console.WriteLine("Dual Array");
                    for (int i = 0; i < studentNames.Length; i++) {
                        Console.WriteLine($"Student: {studentNames[i],-10} | Grade: {studentGrades[i]}");
                    }
                    Console.WriteLine("---------------------------");
                    Console.ReadLine();
                }
            }

        static void PrintArrayValues(int[] arrayToPrint) {
            for (int i = 0; i < arrayToPrint.Length; i++) {
                Console.WriteLine(arrayToPrint[i]);
            }
        }
    }
}
