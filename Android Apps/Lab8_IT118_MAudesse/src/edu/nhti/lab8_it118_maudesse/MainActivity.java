package edu.nhti.lab8_it118_maudesse;


import android.app.Activity;
import android.content.Intent;
import android.content.res.Resources;
import android.database.Cursor;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Matrix;
import android.graphics.drawable.BitmapDrawable;
import android.net.Uri;
import android.os.Bundle;
import android.provider.MediaStore;
import android.view.Display;
import android.view.Menu;
import android.view.View;
import android.widget.ImageView;
import android.widget.SeekBar;
import android.widget.SeekBar.OnSeekBarChangeListener;



public class MainActivity extends Activity {
	private static final int WIDTH_SCALE_RATIO = 10;
	private static final int HEIGHT_SCALE_RATIO = 10;
	private int previousProcess = 0;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		
	
		final ImageView img = (ImageView) findViewById(R.id.img);
	    ((SeekBar) findViewById(R.id.sb))
	            .setOnSeekBarChangeListener(new OnSeekBarChangeListener() {
	                @Override
	                public void onStopTrackingTouch(SeekBar arg0) {
	                }

	                @Override
	                public void onStartTrackingTouch(SeekBar arg0) {
	                }

	                @Override
	                public void onProgressChanged(SeekBar seekBar,
	                        int progresValue, boolean fromUser) {
	                    int diff = progresValue - previousProcess;
	                    scaleImage(img, diff);
	                    previousProcess = progresValue;
	                }
	            });
	}

	public void scaleImage(ImageView img, int scale) {
	    Bitmap bitmap = ((BitmapDrawable) img.getDrawable()).getBitmap();
	    float width = bitmap.getWidth();
	    float height = bitmap.getHeight();
	    width += scale * WIDTH_SCALE_RATIO;
	    height += scale * HEIGHT_SCALE_RATIO;
	    bitmap = Bitmap.createScaledBitmap(bitmap, (int) width, (int) height,
	            true);
	    img.setImageBitmap(bitmap);
	}
	
	

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.main, menu);
		return true;
	}

	public void btnHandler(View v)
	{
		Intent intent = new Intent (Intent.ACTION_PICK, android.provider.MediaStore.Images.Media.EXTERNAL_CONTENT_URI);
		startActivityForResult(intent,111);
	}

	@Override
	protected void onActivityResult(int requestCode, int resultCode, Intent data) {
		// TODO Auto-generated method stub
		if(requestCode==111 && resultCode==RESULT_OK && data!=null)
		{
			Uri selectedImage = data.getData();
			String[] filePathColumn = {MediaStore.Images.Media.DATA};
			Cursor cursor = getContentResolver().query(selectedImage, filePathColumn, null, null, null);
			cursor.moveToFirst();
			int columnIndex = cursor.getColumnIndex(filePathColumn[0]);
			String picturePath = cursor.getString(columnIndex);
			cursor.close();
			Bitmap bm = BitmapFactory.decodeFile(picturePath);
			float bmWidth = bm.getWidth();
			Resources r = getResources();
			//int proposedWidth = (int)TypedValue.applyDimension(TypedValue.COMPLEX_UNIT_DIP, 150, r.getDisplayMetrics());
			Display display = getWindowManager().getDefaultDisplay();
			int proposedWidth = display.getWidth()/2;
			float scale = proposedWidth/bmWidth;
			bm = getResizedBitmap(bm,(int)(bm.getHeight()*scale), proposedWidth);
			ImageView img = (ImageView)findViewById(R.id.img);
			img.setImageBitmap(bm);
			
		}
		
		super.onActivityResult(requestCode, resultCode, data);
	}
	
	public Bitmap getResizedBitmap(Bitmap bm, int newHeight, int newWidth){
		int width = bm.getWidth();
		int height = bm.getHeight();
		float scaleWidth = ((float)newWidth) / width;
		float scaleHeight = ((float)newHeight) / height;
		//create a matrix for the manipulation
		Matrix matrix = new Matrix();
		//resize the bitmap
		matrix.postScale(scaleWidth, scaleHeight);
		//create new bitmap
		Bitmap resizedBitmap = Bitmap.createBitmap(bm, 0, 0, width, height,matrix,false);
		return resizedBitmap;
	}
	
	
	

}
