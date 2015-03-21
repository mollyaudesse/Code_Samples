package edu.nhti.lab5_it118_maudesse;

import android.app.Activity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;

public class MainActivity extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		menu.add(Menu.NONE, 1, Menu.NONE, "Home");
		menu.add(Menu.NONE, 2, Menu.NONE, "Second");
		menu.add(Menu.NONE, 3, Menu.NONE, "Third");
		return true;
	}
	
	@Override
	public boolean onOptionsItemSelected(MenuItem item) {
		// TODO Auto-generated method stub
		return CMethods.menus(item, this);
	}

}
