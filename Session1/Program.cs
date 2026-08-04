
//string name = "Deanne";
//Console.WriteLine(true || "green" == "orange");

//X  Y     X&Y X|Y X^Y
//0  0      0   0   0
//1  0      0   1   1
//0  1      0   1   1
//1  1      1   1   0

/*
 * int index = 0;
index = index + 1;
index += 1;
Console.WriteLine(index);
Console.WriteLine(index++);
Console.WriteLine(index);
Console.WriteLine(++index);
Console.WriteLine(index);
Console.WriteLine(--index);
Console.WriteLine(index);
Console.WriteLine(index--);
Console.WriteLine(index);

int chrissAge = 84;
int brendansAge = 32;
int ageDiff = Math.Abs(brendansAge - chrissAge);

if (chrissAge > brendansAge) {
    Console.WriteLine($"Chris was {ageDiff} years old when Brendan was born.");
} else {
    Console.WriteLine($"Brendan is more {ageDiff} than Chris.");
}

Console.Write("What's A's name? ");
string name1 = Console.ReadLine();
Console.Write("What's B's name? ");
string name2 = Console.ReadLine();

int aNameLength = name1.Length;
int bNameLength = name2.Length;

if (aNameLength > bNameLength) {
    Console.WriteLine($"{name1} has a longer name than {name2}.");
} else if (aNameLength < bNameLength) {
    Console.WriteLine($"{name2} has a longer name than {name1}.");
} else {
    Console.WriteLine($"{name1} and {name2} have names of the same length.");
}
*/

string[] fruits = { "apple", "dragonfruit", "mangosteen" };
foreach (string fruit in fruits) {
    Console.WriteLine(fruit);
}

Console.WriteLine();
int i = 0;
for (//this space
    ;
    i<0;
    ++i) {
        Console.WriteLine(i);
}
Console.WriteLine($"The last number is {i}");