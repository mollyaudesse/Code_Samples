package lab8;

import java.util.Random;

public class CrapsGame {
	   
	GAME_STATUS gStatus = GAME_STATUS.LOST;
       int roll;
       int myPoint;
       Random rand = new Random();
       public CrapsGame()
       {
           roll = -1;
           myPoint = -1;
           System.out.println("Game has started.");
       }// end CrapsGame

       public void playGame() {
           roll = rollDice();

           switch (roll)
           {
               case 2:    
               case 3:
               case 12:
                   gStatus = GAME_STATUS.LOST;
                   break;
               case 7:
               case 11:
                   gStatus = GAME_STATUS.WON;
                   break;
               default: gStatus = GAME_STATUS.CONTINUE;
                   myPoint = roll;
                   System.out.printf("Players Point: %d \n", myPoint);
                   break;
           }// end switch


           while (gStatus == GAME_STATUS.CONTINUE)
           {
               roll = rollDice();
               if (roll == myPoint)
                   gStatus= GAME_STATUS.WON;
               else if(roll == 7)
                   gStatus= GAME_STATUS.LOST;
           }// end while

           if(gStatus == GAME_STATUS.WON)
               System.out.println("Player Wins\n\n"); 
           else
               System.out.println("Player Loses\n\n");
       }// end PlayGame


       public int rollDice(){
           int roll1 = 1+ rand.nextInt(6);
           int roll2 = 1+ rand.nextInt(6);
           int total = roll1 + roll2;
           System.out.printf("Player rolled: %d: %d, %d\n", total, roll1, roll2);
           return total;
           
       }// end RollDice
}
