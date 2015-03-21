/*
 Molly Audesse
 2-8-15
 Introduction to OOP
 */

package lab3;

public class CreditLimitCalculatorTest {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		CreditLimitCalculator check = new CreditLimitCalculator(); 
		System.out.println("Values of account number and account balance after creating object with the default constructor are: ");
		check.printAccountInformation();
		check.setAccountNumber(1122);
		check.setBalance(3000);
		System.out.println("Values of account number and account balance after calling 'set' methods for account number and account balance are: ");
		check.printAccountInformation();
		

	
	}

}
