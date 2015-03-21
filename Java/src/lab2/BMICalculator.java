package lab2;

import java.util.Scanner;
/*
 Molly Audesse
 2-2-15
 Lab 2 BMI Calculator
 */

public class BMICalculator{ 

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Scanner input = new Scanner (System.in);
		
		float weight;
		float height;
		
		System.out.print("Enter your weight in pounds: ");
		weight = input.nextFloat();
		System.out.println("Enter your height in inches: ");
		height = input.nextFloat();
		float f = height * height;
		float BMI = (weight * 703)/f;
		System.out.print("Your BMI is: "+ BMI);
		
		System.out.print("\n\nBMI VALUES\n Underweight:  less than 18.5 \n Normal:       between 18.5 and 24.9 \nOverweight:   between 25 and 29.9\n Obese:        30 or greater");
	}
	    
}

