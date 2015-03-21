/*
 Molly Audesse
 Lab 5
 2-22-2015
 */
package lab5;

import java.util.Scanner;

public class CreditLimitCalculator {

	private int accountNumber;
	private int balance;
	public final int creditLimit = 4000;

	/*
	 This method does...takes the charges and adds them together to give you a total of items charged. 
	 */
	public int inputItemsCharged() {
		Scanner scanner = new Scanner(System.in);
		int charges;
		int itemsChargedTotal = 0;

		System.out.println("Enter the charges or -1 to quit:");
		charges = scanner.nextInt();

		while (charges != -1) {
			itemsChargedTotal = itemsChargedTotal + charges;
			System.out.println("Enter the charges or -1 to quit:");
			charges = scanner.nextInt();
		}

		return itemsChargedTotal;
	}
	
	
	public int creditApplied(){
		Scanner scanner = new Scanner(System.in);
		int credits;
		int creditsTotal = 0;
		
		System.out.println("Enter the credits or -1 to quit:");
		credits = scanner.nextInt();
		
		while (credits != -1) {
			creditsTotal = creditsTotal + credits;
			System.out.println("Enter the credits or -1 to quit:");
			credits = scanner.nextInt();
		}
		
		return creditsTotal;
		
		
		
		
	}
	


	public CreditLimitCalculator() {
		accountNumber = 0;
		balance = 0;

	}

	public int getAccountNumber() {
		return accountNumber;
	}

	public void setAccountNumber(int accountNumber) {
		this.accountNumber = accountNumber;
	}

	public int getBalance() {
		return balance;
	}

	public void setBalance(int balance) {
		this.balance = balance;
	}                                 


	public void printAccountInformation() {
		System.out.printf("The account number is: %d\n", getAccountNumber());
		System.out.printf("The account balance is: %d\n", getBalance());

	}

}
