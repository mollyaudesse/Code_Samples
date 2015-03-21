/*
 Molly Audesse
 2-8-15
 Introduction to OOP
 */
package lab3;

public class CreditLimitCalculator {

	
	private int accountNumber;
	private int balance; 
	
	public CreditLimitCalculator(){
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
	/**
	 * @param args
	 */
	
	public void printAccountInformation(){
		System.out.printf("The account number is: %d\n", getAccountNumber());
		System.out.printf("The account balance is: %d\n", getBalance());
		
	}				
}
