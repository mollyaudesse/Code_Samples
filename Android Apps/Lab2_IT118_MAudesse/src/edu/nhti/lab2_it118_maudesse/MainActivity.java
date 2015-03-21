package edu.nhti.lab2_it118_maudesse;

import android.app.Activity;
import android.content.res.Resources;
import android.os.Bundle;
import android.util.TypedValue;
import android.view.Menu;
import android.view.View;
import android.view.ViewGroup.LayoutParams;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		LinearLayout llMain;
        Button btnMultiple;
        
        
        llMain = (LinearLayout)findViewById(R.id.LLMain);
        
        Resources r = getResources();
		int pixels 
		= (int)TypedValue.applyDimension(TypedValue.COMPLEX_UNIT_DIP, 150, r.getDisplayMetrics());
	
		LinearLayout.LayoutParams p = new LinearLayout.LayoutParams(pixels, LayoutParams.WRAP_CONTENT);
		
		for(int i = 0; i<10; i++){
			LinearLayout llmultiple = new LinearLayout(this);
			llmultiple.setOrientation(LinearLayout.HORIZONTAL);
			llmultiple.setId(i + 1);
			llMain.addView(llmultiple);
			
			TextView txt = new TextView(this);
			txt.setId(i + 1);
			//txt.setText("something " +(i + 1));
			llmultiple.addView(txt);
			
			btnMultiple = new Button(this);
			btnMultiple.setLayoutParams(p);
			btnMultiple.setId(i+1);
			btnMultiple.setText("Button " + (i+1));
			llmultiple.addView(btnMultiple);
			
			final int resId = i+1;
			btnMultiple.setOnClickListener(new Button.OnClickListener(){
				public void onClick(View v){
					//Toast.makeText(getApplicationContext(), "button " + v.getId(), Toast.LENGTH_SHORT);
					LinearLayout p = (LinearLayout) v.getParent();
					TextView t = (TextView) p.getChildAt(0);
					t.setText("button" + v.getId());
				//	
				}
			});
		    }
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.main, menu);
		return true;
	}

}
