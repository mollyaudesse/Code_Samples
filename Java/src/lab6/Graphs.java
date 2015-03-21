/*
Molly Audesse
Intro to OOP
3-1-2015
 */

package lab6;

import java.util.Scanner;

public class Graphs {


public void drawHistograms() {

	Scanner input = new Scanner(System.in);
	int number1 = 0;
	int number2 = 0;
	int number3 = 0;
	int number4 = 0;
	int number5 = 0;
	int inputNumber;
	int value = 0;
	int counter = 1;
	
	while(counter<=5)
	{
	
		System.out.print("Enter Number: ");
		// assigning the value of user input to variable input number.
		inputNumber = input.nextInt();
		if(inputNumber >= 1 && inputNumber <= 30)
		{
			switch(counter)
			{
			case 1:
				number1 = inputNumber;
				break;
				
			case 2:
				number2 = inputNumber;
				break;
				
			case 3:
				number3 = inputNumber;
				break;
				
			case 4:
				number4 = inputNumber;
				break;
				
			case 5:
				number5 = inputNumber;
				break;
				
			default:
				break;
				
		}// end switch
			
			counter++; // incrementing counter by 1
			
	}// end if
		
	
		else
			System.out.println("Invaild Input \nNumber should be between 1 and 30");

	}//end while
	// made a new counter called counter2 because you cannot have duplicate local variables
	for(int counter2 = 1; counter2<=5; counter2++)
	{
		switch(counter2){
		
		case 1:
			value = number1;
			break;
			
		case 2:
			value = number2;
			break;
			
		case 3:
			value = number3;
			break;
			
		case 4:
			value = number4;
			break;
			
		case 5:
			value = number5;
			break;
			
		default:
			break;
			
		}// end switch	
		
		for(int counter3 = 1; counter3 <= value; counter3++)
		{
			System.out.print("*");
		}
		
		System.out.println();
		
		
		}// end for loop

	}// end method drawHistogram()

}
