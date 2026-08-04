// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");
Console.Write("How many bananas in a pile? ");
string input = Console.ReadLine();

double bananaCount = double.Parse(input);
//DateTime bananaCount = DateTime.Parse(input);

Console.WriteLine($"There are {input} inputs in a line. " + 75.0.ToString("0.00"));

void MyFunction() {
    Console.WriteLine("test");
}

//Console.WriteLine(Add(4,5));Console.WriteLine(Add(5,4));int Add(int a,int b){if(a > b){return a + b;}return 0;}

Console.WriteLine(Add(4, 5));
Console.WriteLine(Add(5, 4));
int Add(int a, int b) {
    if (a > b) {
        return a + b;
    }
    return 0;
}



