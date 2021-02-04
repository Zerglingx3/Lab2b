using System;

class MainClass {
  public static void Main (string[] args) {
    // user Inputs and variable assignments

    Console.WriteLine ("Please enter an integer");
    int numberA = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine ("Please enter a second integer");
    int numberB = Convert.ToInt32(Console.ReadLine());

    // arithmetic

    int sumAB = numberA + numberB;

    int diffAB = numberA - numberB;

    int productAB = numberA * numberB;

    int quotientAB = numberA / numberB;
    int remainderAB = numberA % numberB;

    // console outputs

    Console.WriteLine ("Sum = "+ sumAB);

    Console.WriteLine ("Diff = "+ diffAB);

    Console.WriteLine ("Product = "+ productAB);

    Console.WriteLine ("Quotient = "+ quotientAB);
    Console.WriteLine ("Remainder = "+ remainderAB);



  }
}