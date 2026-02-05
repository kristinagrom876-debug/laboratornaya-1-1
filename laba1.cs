using System;

class Program {
  static void Main() {
    const int numberLength = 2;
	const int PowerInitialValue = 1;
	const int SecondDigitIndex = 1;
	const int DigitsToRemoveCount = 1;

  while (true) {
      Console.WriteLine("Select Task:");
      Console.WriteLine("1 - Raise Number To Power");
      Console.WriteLine("2 - Second Digit Permutation");
      Console.Write("Your Choice: ");

      string userChoice = Console.ReadLine();

      if (userChoice == "1") {
	    Console.Write("a: ");
	    int baseNumber = int.Parse(Console.ReadLine());

		Console.Write("n: ");
		int exponentValue = int.Parse(Console.ReadLine());

		long calculationResult = PowerInitialValue;
		for (int loopCounter = 0; loopCounter < exponentValue; ++loopCounter) {
		  calculationResult *= baseNumber;
		}

		Console.WriteLine($"Calculation Result: {calculationResult}");
	  }
	  else if (userChoice == "2") {
	    Console.Write("x: ");
		string inputNumber = Console.ReadLine();

		if (inputNumber.Length <= numberLength) {
		  Console.WriteLine("Number Must Contain At Least 3 Digits!");
		  continue;
		}

		char secondDigit = inputNumber[SecondDigitIndex];
		string newNumber = inputNumber.Remove(SecondDigitIndex, DigitsToRemoveCount) + secondDigit;

		  Console.WriteLine($"n: {newNumber}");
	  } else {
          Console.WriteLine("Invalid Choice!");
		}
	}
  }
}