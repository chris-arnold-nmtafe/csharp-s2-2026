using System;

namespace Week2_SelectionAndIteration.Exercises.Play {
    internal class Playground {
        static void Main(string[] args) {
            while (true) {
                // looping menu
                Console.WriteLine("Welcome to your C# playground!");
                Console.WriteLine("Choose an exercise to run:");
                Console.WriteLine("1 - Exercise 1 - While Loop varying iteration points");
                Console.WriteLine("2 - Exercise 2 - Comparisons");
                Console.WriteLine("3 - Exercise 3 - Month/Season Logic");
                Console.WriteLine("Exercise 4 - Month/Season Logic (int.Parse version)");
                Console.WriteLine("X - Exit");
                Console.Write("Enter choice: ");

                string choice = Console.ReadLine();

                switch (choice.ToUpper()) {
                    case "1":
                        Exercise1();
                        break;

                    case "2":
                        Exercise2();
                        break;

                    case "3":
                        Exercise3();
                        break;
                    case "4":
                        Exercise4();
                        break;

                    case "X":
                        return;   // exits the program

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                Console.WriteLine(); // spacing before showing menu again
            }
        }
        static void Exercise1() {
            Console.WriteLine("Exercise 1 - While Loop varying iteration points");
            Console.WriteLine("Iterating from 0 pre comparison to 5");
            int counter = 0;
            while (counter++ < 5) {
                Console.WriteLine($"Counter is at {counter}");
                // counter++;
            }
            Console.WriteLine("Iterating from 0 post comparison to 5");
            counter = 0;
            while (counter < 5) {
                Console.WriteLine($"Counter is at {counter}");
                counter++;
            }

        }

        static void Exercise2() {
            Console.WriteLine("Exercise 2 - Comparisons");

            string myName = "Anya";
            int myAge = 45;

            string partnerName = "Mat";
            int partnerAge = 51;

            if (myAge > partnerAge) {
                Console.WriteLine($"{myName} is older than {partnerName}");
            } else if (myAge < partnerAge) {
                Console.WriteLine($"{partnerName} is older than {myName}");
            } else {
                Console.WriteLine("We are the same age");
            }

            int ageDiff = Math.Abs(myAge - partnerAge);
            Console.WriteLine($"The age difference is {ageDiff} years");

            int myNameLength = myName.Length;
            int partnerNameLength = partnerName.Length;

            if (myNameLength > partnerNameLength) {
                Console.WriteLine($"{myName} has a longer name than {partnerName}.");
            } else if (myNameLength < partnerNameLength) {
                Console.WriteLine($"{partnerName} has a longer name than {myName}.");
            } else {
                Console.WriteLine("Our names are the same length.");
            }
        }

        static void Exercise3() {
            Console.WriteLine("Exercise 3 - Month/Season Logic");
            while (true) {
                Console.WriteLine("What month were you born in:");
                Console.WriteLine("Type the number or name of your birth month");

                string month = Console.ReadLine();

                switch (month.ToLower()) {
                    case "12":
                    case "1":
                    case "2":
                        Summer();
                        break;

                    case "3":
                    case "4":
                    case "5":
                        Autumn();
                        break;

                    case "6":
                    case "7":
                    case "8":
                        Winter();
                        break;

                    case "9":
                    case "10":
                    case "11":
                        Spring();
                        break;

                    case "december":
                    case "january":
                    case "february":
                        Summer();
                        break;

                    case "march":
                    case "april":
                    case "may":
                        Autumn();
                        break;

                    case "june":
                    case "july":
                    case "august":
                        Winter();
                        break;

                    case "september":
                    case "october":
                    case "november":
                        Spring();
                        break;

                    case "x":
                        return;
                }
            }
        }


        static void Summer() {
            Console.WriteLine("You were born in Summer");
        }

        static void Autumn() {
            Console.WriteLine("You were born in Autumn");
        }

        static void Winter() {
            Console.WriteLine("You were born in Winter");
        }

        static void Spring() {
            Console.WriteLine("You were born in Spring");
        }

        static void Exercise4() {
            Console.WriteLine("Exercise 4 - Month/Season Logic (int.Parse version)");

            while (true) {
                Console.WriteLine("What month were you born in?");
                Console.WriteLine("Type the number (1–12) or the name of your birth month.");
                Console.WriteLine("Type X to return to the main menu.");

                string input = Console.ReadLine();

                if (input.ToLower() == "x")
                    return;

                if (int.TryParse(input, out int monthNumber)) // numeric logic
                {
                    switch (monthNumber) {
                        case 12:
                        case 1:
                        case 2:
                            Summer();
                            break;

                        case 3:
                        case 4:
                        case 5:
                            Autumn();
                            break;

                        case 6:
                        case 7:
                        case 8:
                            Winter();
                            break;

                        case 9:
                        case 10:
                        case 11:
                            Spring();
                            break;

                        default:
                            Console.WriteLine("Invalid month number. Please enter 1–12.");
                            break;
                    }
                } else {
                    switch (input.ToLower())  // string logic
                    {
                        case "december":
                        case "january":
                        case "february":
                            Summer();
                            break;

                        case "march":
                        case "april":
                        case "may":
                            Autumn();
                            break;

                        case "june":
                        case "july":
                        case "august":
                            Winter();
                            break;

                        case "september":
                        case "october":
                        case "november":
                            Spring();
                            break;

                        default:
                            Console.WriteLine("Invalid month name.");
                            break;
                    }
                }
            }
        }




    }
}
```
 