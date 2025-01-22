/*
int guess;
int min = 1;
int max = 100;
Random rnd = new Random();
int number = rnd.Next(min, max + 1);
int guesses = 0;

do
{
    Console.WriteLine("Gebe deine Zahl zwischen {0} und {1} ein: ", min, max);
    
    // Input validation
    bool isValidInput = int.TryParse(Console.ReadLine(), out guess);

    if (!isValidInput)
    {
        Console.WriteLine("Ungültige Eingabe! Bitte gib eine gültige Zahl ein.");
        continue;  // Skip this loop iteration and ask again
    }

    guesses++;

    if (guess == number)
    {
        Console.WriteLine("RICHTIG! Deine Zahl war " + number);
        Console.WriteLine("Du hast {0} Versuche gebraucht!", guesses);
    }
    else if (guess > number)
    {
        Console.WriteLine("Die Zahl ist kleiner als " + guess);
        max = guess - 1;  // Update max range
    }
    else if (guess < number)
    {
        Console.WriteLine("Die Zahl ist größer als " + guess);
        min = guess + 1;  // Update min range
    }

    Console.WriteLine();

} while (guess != number);
*/

//for (int i = 0; i <= 10; i++) {
//    Console.WriteLine(i);
//}

//int[] numbers = new int[] { 50, 200, 75 };

//int result  = 0;    

//(int n in numbers) {result += n;} wenn man die arrays zusammenrechnen will

//foreach (int n in numbers) 
//{
//    Console.WriteLine(n);
//}

//for (int i = 2; i <=20; i += 2)
//{
//    Console.WriteLine(i);
//}

//for (int i = 100; i >=0; i-=2)
//{
//    Console.WriteLine(i);
//}

//int i = 0;

//while(i < 10)
//{
//    Console.WriteLine(i);
//    i++;    
//}

//int[] numbers = new int[3] { 1, 2, 3 };
//int i  = 0; 

//while(i < numbers.Length)
//{
//    Console.WriteLine(numbers[i]);
//    i++;
//}


//int userInput;
//int numberCounter = 0;
//int[] numberArray = new int[5];  // Array to store 5 numbers
//int sum = 0;  // Variable to store the sum

//Console.WriteLine("Willkommen bei deinem Nummerrechner. :)");
//Console.WriteLine();

//while (numberCounter < 5)  // Ensure we only get 5 numbers
//{
//    Console.Write("Bitte gebe deine nächste Nummer ein: ");

//    // Validate the input
//    bool isValidInput = int.TryParse(Console.ReadLine(), out userInput);

//    if (!isValidInput)
//    {
//        Console.WriteLine("Ungültige Eingabe! Bitte gib eine gültige Zahl ein.");
//        continue;  // Ask for the number again
//    }

//    // Store the valid number in the array
//    numberArray[numberCounter] = userInput;
//    numberCounter++;
//}

//// Output the numbers entered
//Console.WriteLine("Du hast folgende Nummern eingegeben:");
//foreach (int number in numberArray)
//{
//    Console.WriteLine(number);
//    sum += number;  // Add each number to the sum
//}

//// Display the total sum
//Console.WriteLine();
//Console.WriteLine("Die Summe der eingegebenen Zahlen ist: " + sum);


int[] numbers = new int[5];

int index  = 0; 

int result = 0; 

while (index < numbers.Length)
{
    Console.Write("Bitte gib die " + (index + 1 ) + " Zahl ein: ");

     int input = int.Parse(Console.ReadLine());

    numbers[index] = input;

    result += input;

    index++;    
}

Console.WriteLine("Dein Ergebnis: "  + result);