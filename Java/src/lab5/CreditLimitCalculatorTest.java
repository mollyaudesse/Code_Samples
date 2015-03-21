package lab5;

import java.util.Scanner;

public class CreditLimitCalculatorTest {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		CreditLimitCalculator check = new CreditLimitCalculator();
		Scanner input = new Scanner(System.in);
		int oldBalance;
		int accountNumber;
		
		//get the balance
		System.out.println("Enter your balance: ");
		oldBalance = input.nextInt();
		check.setBalance(oldBalance);
		
		//get the account number
		System.out.println("Enter your account number: ");
		accountNumber = input.nextInt();
		check.setAccountNumber(accountNumber);

		//total up the charges
		int charges = check.inputItemsCharged();		
		int credits = check.creditApplied();
		
		int netBalance = check.getBalance() + charges - credits;
		
		check.setBalance(netBalance);
		
		System.out.printf("For the account number: %d the balance after the charges and credits is: $%d\n", check.getAccountNumber(), check.getBalance());
		
		if(netBalance > 4000)
		{
			System.out.println("Your account limit is $4000. \nYour account has exceeded the limit!");	
		}
		
	
		
		/*
		System.out.println("Values of account number and account balance after creating object with the default constructor are: ");
		check.printAccountInformation();
		check.setAccountNumber(1122);
		check.setBalance(3000);
		System.out.println("Values of account number and account balance after calling 'set' methods for account number and account balance are: ");
		check.printAccountInformation();
		 */
	
	}

}
