/* Molly Audesse
 Lab 4
 2-22-2015
 */


package lab4;


public class Employee {

	private String firstName;
	private String lastName;
	private double salaryMonthly;
	
	
	public String getFirstName() {
		return firstName;
	}

	public void setFirstName(String firstName) {
		this.firstName = firstName;
	}

	public String getLastName() {
		return lastName;
	}

	public void setLastName(String lastName) {
		this.lastName = lastName;
	}

	public double getSalaryMonthly() {
		return salaryMonthly;
	}
	
	public double getYearlySalary() {
		return salaryMonthly * 12;
	}

	public void setSalaryMonthly(double salaryMonthly) {

		if (salaryMonthly >= 0) {
			this.salaryMonthly = salaryMonthly;
		
		}

	}

	
	public double bonusSalary(){
		return getYearlySalary() * 1.1;
	}
	
	public Employee(String firstName, String lastName, double salaryMonthly ){
		this.firstName = firstName;
		this.lastName = lastName;
		this.salaryMonthly = salaryMonthly;
		
	}

}
