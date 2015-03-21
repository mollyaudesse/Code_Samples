/* 
 Molly Audesse
 Lab 4 
 2-20-2015
 */
package lab4;

import java.text.NumberFormat;
import java.util.Locale;

public class EmployeeTest {

	
	public static void main(String[] args) {
		Employee emp = new  Employee("Bob", "Jones", (double)34500 / 12);
		Employee emp2 = new Employee("Susan", "Baker", (double)37809 /12);
		NumberFormat currencyFormat = NumberFormat.getCurrencyInstance(Locale.US);

		System.out.printf("Employee 1: %s %s; Yearly Salary: %s\n", emp.getFirstName(), emp.getLastName(), 
				currencyFormat.format(emp.getYearlySalary() ));
		System.out.printf("Employee 2: %s %s; Yearly Salary: %s\n", emp2.getFirstName(), emp2.getLastName(), 
				currencyFormat.format(emp2.getYearlySalary() ));
	
	System.out.println();
	System.out.println("Increasing employee salaries by 10%");
	
	
		System.out.printf("Employee 1: %s %s; Yearly Salary: %s\n", emp.getFirstName(), emp.getLastName(), 
				currencyFormat.format(emp.bonusSalary() ));
		System.out.printf("Employee 2: %s %s; Yearly Salary: %s", emp2.getFirstName(), emp2.getLastName(), 
				currencyFormat.format(emp2.bonusSalary() ));
	
	
	}		

}


