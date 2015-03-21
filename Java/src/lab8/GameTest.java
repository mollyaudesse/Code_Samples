package lab8;

public class GameTest {
	public static void main(String[] args){
		
    CrapsGame game1 = new CrapsGame();
    
    for (int counter = 1; counter <= 10; counter++)
    {
        game1.playGame(); 
    }


	}
}
