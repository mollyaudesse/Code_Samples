package edu.nhti.lab6_it118_maudesse;

import android.app.Activity;
import android.os.Bundle;
import android.view.Menu;
import android.widget.CheckBox;

public class SecondActivity extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_second);
		
		Bundle extras = getIntent().getExtras();
		String s = extras.getString("mytext");
		CheckBox one = (CheckBox)findViewById(R.id.cb1);
		CheckBox two = (CheckBox)findViewById(R.id.cb2);
		
		if(s.equals("1")){
			one.setChecked(true);
			two.setChecked(false);
		}
		else if(s.equals("2")){
			two.setChecked(true);
			one.setChecked(false);
		}
		else {
			two.setChecked(false);
			one.setChecked(false);
			
		}
	}
	


	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.second, menu);
		return true;
	}

}
