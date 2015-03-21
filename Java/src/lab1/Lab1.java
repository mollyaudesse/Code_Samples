package lab1;

/* 
Molly Audesse
1-2-15
Lab1 Simple Data Type IO

 */

import java.util.Scanner;

public class Lab1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Scanner input = new Scanner (System.in);
		
		byte byt = 'P';
		short sh = 16;
		int i = 10;
		long l = 64;
		float f = 88133.125000f;
		double b = 3377.123456789012400;
		char ch = 'X'; 
		String s = "myString";
		Boolean bool1 = true; 
		Object myObject;
			myObject="myObject";
		
		System.out.format("**** Part1: ****\n");
		System.out.printf("byte = %c\n", byt);		
		System.out.printf("short = %d\n", sh);
		System.out.printf("int = %d\n", i);
		System.out.printf("long = %d\n", l);
		System.out.printf("float = %f\n", f);
		System.out.printf("double = %g\n", b);
		System.out.printf("char = %c\n", ch);
		System.out.printf("String = %s\n", s);
		System.out.printf("Boolean = %B\n", bool1);
		System.out.printf("Object = %s", myObject);
		
		
		System.out.format("\n\n**** Part2: ****\n");
		Scanner Input = new Scanner(System.in);
		
		System.out.print("Enter a byte: ");
		byt = Input.nextByte();
		System.out.printf("Byte = %c\n", byt);
		System.out.print("Enter an Int: ");
		i = Input.nextInt();
		System.out.printf("Int = %d\n", i);
		System.out.print("Enter an Int16: ");
		sh = Input.nextShort();
		System.out.printf("Int16 = %d\n", sh);
		System.out.print("Enter a Long Int: ");
		l = Input.nextLong();
		System.out.printf("Long = %d\n", l);
		System.out.print("Enter a Float: ");
		f = Input.nextFloat();
		System.out.printf("float = %f\n", f);
		System.out.print("Enter a Double: ");
		b = Input.nextDouble();
		System.out.printf("double = %g\n", b);
		System.out.print("Enter a String: ");
		char chr = Input.next().charAt(0);
		System.out.printf("First char = %C\n", chr );
		System.out.print("Enter a String: ");
		s = Input.next();
		System.out.printf("String = %s\n", s);
		System.out.printf("Enter a Boolean (true/false): ");
		bool1 = Input.nextBoolean();
		System.out.printf("Boolean = %B\n", bool1);
		System.out.print("Enter a String: ");
		s = Input.next();
		myObject=s;
		System.out.printf("Object = %s\n", myObject);
		
		
		
		
	


	}

}
