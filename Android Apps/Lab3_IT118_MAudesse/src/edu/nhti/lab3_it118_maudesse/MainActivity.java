package edu.nhti.lab3_it118_maudesse;

import android.app.Activity;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.Menu;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends Activity {
	private SharedPreferences savedSetup;
	private TextView txt;
	private Button btn;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		
		savedSetup = getSharedPreferences("setup", MODE_PRIVATE);
        if(savedSetup.getString("savedText" , null) != null){
        	txt = (TextView)findViewById(R.id.lbo);
        	txt.setText(savedSetup.getString("savedText", null));
        }
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.main, menu);
		return true;
	}
	
	public void btnSaveHandler(View v){
		EditText txtEdit = (EditText)findViewById(R.id.txt);
		
		SharedPreferences.Editor preferencesEditor = savedSetup.edit();
		preferencesEditor.commit();
		preferencesEditor.putString("savedText", txtEdit.getText().toString());
		preferencesEditor.commit();
	}

}
