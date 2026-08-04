// See https://aka.ms/new-console-template for more information


int mangosteensInPile = ReadNumber("How many mangosteens in a pile?");
Console.WriteLine(mangosteensInPile + " mangosteens in a pile.");
int turmericInPile = ReadNumber("How many tumeric roots in a stack?");
Console.WriteLine(turmericInPile + " tumerics in a stack.");

int ReadNumber(string prompt) {
    Console.Write(prompt.Trim() + " ");
    string userInput = Console.ReadLine();
    int result;
    bool parsedOK = int.TryParse(userInput, out result);
    if (parsedOK) {
        return result;
    } else {
        return int.MinValue;
    }
}

//int ReadNumber(string prompt, out bool readingWentOK) {
//    string userInput = Console.ReadLine();
//    int result;
//    if (int.TryParse(userInput, out result)) {
//        return result;
//    } else {
//        readingWentOK = false;
//        return int.MinValue;
//    }
//}
