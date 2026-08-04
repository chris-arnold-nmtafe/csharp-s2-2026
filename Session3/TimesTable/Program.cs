int baseNumber = -1;
int minNumber = 1;
int maxNumber = 12;
bool IsInRange(int number, int min, int max) {
    return number >= min && number <= max;
}

while (IsInRange(baseNumber,minNumber,maxNumber)) {
    baseNumber = ReadNumber("Times table for which number would you like? ");
    if (IsInRange(baseNumber, minNumber, maxNumber)) {
        Console.WriteLine("No bueno! Try again");
    }
}

for (int i = 1; i <= 12 ; ++i) {
    Console.WriteLine($"{i} x {baseNumber} = {(i * baseNumber)}");
}

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