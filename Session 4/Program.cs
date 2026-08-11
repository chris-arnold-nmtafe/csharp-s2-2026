// See https://aka.ms/new-console-template for more information

//string[] defaults = new string[5];
//string[] greetings = { "hello", "ciao", "Hallo", "Bonjour", "Hej", "Hola", "Nihao", "Aloha" };
//Console.WriteLine("greetings".Length);
//Console.WriteLine(greetings.Length);
//Console.WriteLine(greetings[7]);
//Console.WriteLine(greetings[greetings.Length - 1]);

//int[] ints = { 1, 2, 3 };
//int[] ints2 = ints.Append(4).ToArray<int>();
//Console.WriteLine(ints.Length);
//Console.WriteLine(ints2.Length);

//Console.WriteLine(greetings[0]);
//greetings[0] = "Howdy";
//Console.WriteLine(greetings[0]);

string[] nehellos = new string[3];
//Array.Copy(greetings, 2, nehellos, 0, 3);
//Console.WriteLine(string.Join(", ",nehellos));


List<string> helloList = new List<string>()
    { "hello", "ciao", "Hallo", "Bonjour", "Hej", "Hola", "Nihao", "Aloha" };
//helloList.Add("Privet");
//printAllTheThingsOnMyListAndJustDoThat(helloList.ToList());
//Console.WriteLine($"{helloList[0]}, Rutherford.");


Dictionary<string, string> stringThing = new Dictionary<string, string>() {
    { "one","Derek" },
    { "three","Simone" }
};
//string numberThree = stringThing["three"];
//Console.WriteLine(numberThree);
////Console.WriteLine(stringThing["3"]);
//string threeValue;
//bool fetchedOk = stringThing.TryGetValue("3", out threeValue);






//void printAllTheThingsOnMyListAndJustDoThat(List<string> things) {
//    Console.WriteLine(string.Join(", ", things));
//    things[0] = "Konichiwa";
//}


//int[] numbers = { 0,9,4,6,5 };
//int leastValue(int[] numbers, int unless=int.MaxValue) {
//    int least = int.MaxValue;
//    for (int i=0;i<numbers.Length;++i) {
//        int num = numbers[i];
//        if (unless != num) {
//            if (least > num) {
//                least = num;
//            }
//        }
//    }
//    return least;
//}
//int lowest = leastValue(numbers);
//int secondLowest = leastValue(numbers, lowest);
//Console.WriteLine(secondLowest);

//Array.Sort(numbers);
//Console.WriteLine(numbers[1]);


string[] TestArray = { "Hello", "World", "This", "Is", "A", "Test" };

int ArrayLength = TestArray.Length;
for (int i = 0; i < ArrayLength; i++) {
    Console.WriteLine(TestArray[i]);
}


string[] students = { "Harry", "Erica", "Srinivas" };
int[] grades = { 10,100,90 };

Array.Sort(students);
Array.Sort(grades);
Console.WriteLine(students[0]);

(string, int)[] gradeStructures = new (string, int)[3] {
    ("Harry",10),("Erica",100),("Srinivas",90)
};

int compareScores((string,int) a, (string, int) b) {
    return a.Item2.CompareTo(b.Item2);
}

Array.Sort(gradeStructures,compareScores);
//Console.WriteLine($"{gradeStructures[0]} {gradeStructures[1]}");
PrintStudentGrades();
void PrintStudentGrades() {
    for (int i = 0; i < gradeStructures.Length; i++) {
        Console.WriteLine($"{gradeStructures[i].Item1}'s grade is: {gradeStructures[i].Item2}");
    }
} 