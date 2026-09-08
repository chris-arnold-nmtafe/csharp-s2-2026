// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Random rando = new Random();
Console.WriteLine(rando.Next(1, 45));

int[] things = { 2, 1, 8, 9, 5 };

int target = 9;
int index = linearSearch(target,things);

int linearSearch(int target, int[] things) {
    for (int i=0;i<things.Length;i++) {
        if (things[i] == target) {
            return i;
        }
    }
    return -1;
}

Console.WriteLine("-------Recursive Search----------");
Console.WriteLine(recursiveLinearSearch(9, things));
Console.WriteLine(recursiveLinearSearch(7, things));
Console.WriteLine("---------------------------------");
int recursiveLinearSearch(int target, int[] things, int index=0) {
    if (index >= things.Length) {
        return -1;
    } else if (things[index] == target) {
        return index;
    } else {
        return recursiveLinearSearch(target, things, index + 1);
    }
}

int binarySearch(int target, int[] things) {
    int low = 0;
    int upper = things.Length - 1;
    while (low <= upper) {
        int mid = (low + upper)/2;
        int midItem = things[mid];
        if (midItem == target) {
            return mid;
        } else if (midItem < target) {
            low = mid+1;
        } else if (midItem > target) {
            upper = mid-1;
        }
    }
    return -1;
}
things = new int[] { 1, 2, 5, 8, 9 };
Console.WriteLine(binarySearch(1, things));
Console.WriteLine(binarySearch(2, things));
Console.WriteLine(binarySearch(5, things));
Console.WriteLine(binarySearch(8, things));
Console.WriteLine(binarySearch(9, things));
Console.WriteLine(binarySearch(0, things));
Console.WriteLine(binarySearch(3, things));
Console.WriteLine(binarySearch(7, things));
Console.WriteLine(binarySearch(20, things));
Console.WriteLine($"{target} " + (index < 0 ? "does not exist" : $"is at {index}"));
//Console.WriteLine($"{target} " + (index<0 ? "does not exist" : $"is at {index}"));


Console.WriteLine("-------Bubble Sort----------");
int[] toSort = { 54,26,93,17,77,31,44,55,20};
int steps = bubbleSort(toSort);
Console.WriteLine(string.Join(", ", toSort));
Console.WriteLine($"Sort took {steps} steps.");
int bubbleSort(int[] things) {
    int comparisons = 0;
    for (int i = 0; i < things.Length; i++) {
        bool swapped = false;
        for (int j = 1; j < (things.Length-1); j++) {
            ++comparisons;
            if (things[j-1] > things[j]) {
                int temp = things[j-1];
                things[j-1] = things[j];
                things[j] = temp;
                swapped = true;
            }
        }
        if (!swapped) {
            return comparisons;
        }
    }
    return comparisons;
}



