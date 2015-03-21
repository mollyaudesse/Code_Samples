package edu.nhti.lab5_it118_maudesse;

import android.app.Activity;
import android.content.Intent;
import android.view.MenuItem;

public class CMethods {
	
	public static boolean menus(MenuItem item, Activity myActivity)
	{
		switch (item.getItemId())
		{
		case 1:
			Intent main=new Intent(myActivity, MainActivity.class);
			myActivity.startActivity(main);
			myActivity.finish();
			return true;
			
		case 2:
			Intent sec=new Intent(myActivity, SecondActivity.class);
			myActivity.startActivity(sec);
			myActivity.finish();
			return true;
			
		case 3:
			Intent third=new Intent(myActivity, ThirdActivity.class);
			myActivity.startActivity(third);
			myActivity.finish();
			return true;
		}
			return false; 
	}
}
