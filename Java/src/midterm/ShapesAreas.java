package midterm;

public class ShapesAreas {

	double radius;
	int side;
	int width;
	
	
	public double getRadius() {
		return radius;
	}
	public void setRadius(double radius) {
		this.radius = radius;
	}
	public int getSide() {
		return side;
	}
	public void setSide(int side) {
		this.side = side;
	}
	public int getWidth() {
		return width;
	}
	public void setWidth(int width) {
		this.width = width;
	}
	
	public double circleArea(){
		return radius;
		
		double cArea = Math.pow(radius,2)*Math.PI;
	
		System.out.printf("The area of a circle with radius %d, is %d");
	}
	
	
	public int squareArea(){
		
		int sqArea;
		
		sqArea = this.getSide()*this.getSide();
		
		System.out.printf("The area of a sqaure with side %d, is %d");
		return sqArea;
	}
	
	public int rectangleArea(){
		
		int recArea = this.getSide()*this.getWidth();
		return recArea;
		
		System.out.printf("The area of a rectangle with side %d, and width %d, is %d");
	}
}
