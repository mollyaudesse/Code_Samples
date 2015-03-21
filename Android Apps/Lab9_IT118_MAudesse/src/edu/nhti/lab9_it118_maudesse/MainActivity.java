package edu.nhti.lab9_it118_maudesse;

import org.ksoap2.SoapEnvelope;
import org.ksoap2.serialization.SoapObject;
import org.ksoap2.serialization.SoapSerializationEnvelope;
import org.ksoap2.transport.HttpTransportSE;

import android.app.Activity;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Bundle;
import android.view.Menu;
import android.widget.ImageView;
import android.widget.TextView;



public class MainActivity extends Activity {
	private static final String SOAP_ACTION = "http://www.nhti.edu/concordWeather";
	private static final String METHOD_NAME = "concordWeather";
	private static final String NAMESPACE = "http://www.nhti.edu";
	private static final String URL = "http://nhtiquery.nhti.edu/android/AService.asmx";

	

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		getWeather();
	
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.main, menu);
		return true;
	}
	
	public void getWeather()
	{
		TextView txtWeather = (TextView)findViewById(R.id.txtWeather);
		ImageView imgWeather = (ImageView)findViewById(R.id.imgWeather);
		try{
			SoapObject request = new SoapObject(NAMESPACE,METHOD_NAME);
			
			
			SoapSerializationEnvelope envelope = new SoapSerializationEnvelope(SoapEnvelope.VER11);
			envelope.dotNet = true;
			envelope.setOutputSoapObject(request);
			
			
			HttpTransportSE androidHttpTransport = new HttpTransportSE(URL);
			androidHttpTransport.call(SOAP_ACTION, envelope);
			
			
			
			Object result = (Object)envelope.getResponse();
			String weather = result.toString();
			String delim = "[ ]+";
			String [] splitWeather = weather.split(delim);
			txtWeather.setText("It's " + splitWeather[0]+ "\u2109, "+splitWeather[1]);
			Bitmap bm = getImage (splitWeather[1]);
			imgWeather.setImageBitmap(bm);
			
			
			
		}
		catch(Exception ex){
			txtWeather.setText(ex.getMessage());
		}
	}
	
	public Bitmap getImage(String s)
	{
		Bitmap bm;
		if(s.equals("Clear")){
			bm = BitmapFactory.decodeResource(this.getResources(), R.drawable.sunny);
		}
		else{
			bm = null;
			
		}
		return bm;
	}

}
