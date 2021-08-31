// Lab No.1 Project No.2
//File Name : main.cs
//@author : Joshua Um
//Date : August 30 2021

//Problem Statement: calculate maximum amount of candy bars and gumballs with a set amount of coupons.

//Overall Plan:
// 1. Assign a variable with amount of coupons won.
// 2. Calculate number of candy bars  (coupons / 10).
// 3. Calculate coupons remaining after candy bars (coupons % 10).
// 4. Calculate number of gumballs (coupons_after_candyBars / 3).
// 5. Calculate coupons remaining after candy bars (coupons_after_candyBars % 3).
// 6. Print results.


using System;

class Program {
  public static void Main (string[] args) {
    int coupons = 108;
    int num_coupons_after_candyBars , num_coupons_after_gumBalls, num_candyBars , num_gumballs;

    //Calculate number of candy bars.
    num_candyBars = coupons / 10;

    //Calcualate remaining coupons after candy bars.
    num_coupons_after_candyBars = coupons % 10;

    //Calculate number of gumballs with remaining coupons.
    num_gumballs = num_coupons_after_candyBars / 3;

    //Calculate remaining coupons after gumballs.
    num_coupons_after_gumBalls = num_coupons_after_candyBars % 3 ;

    //Display results.
    Console.WriteLine("# Coupons won : " + coupons + "\n" +
                      "# Candy bars : " + num_candyBars + "\n" +
                      "# Gum balls: " + num_gumballs + "\n" +
                      "# Coupons remaining : " + num_coupons_after_gumBalls);    
  
    Console.ReadLine();

  }
}