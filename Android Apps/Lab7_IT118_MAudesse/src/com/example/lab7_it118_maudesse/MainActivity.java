package com.example.lab7_it118_maudesse;

import android.app.Activity;
import android.content.Intent;
import android.content.res.Resources;
import android.graphics.Bitmap;
import android.graphics.Matrix;
import android.os.Bundle;
import android.util.TypedValue;
import android.view.Menu;
import android.view.View;
import android.widget.ImageView;

public class MainActivity extends Activity {
	
	private static final int CAMERA_PIC_REQUEST = 1337;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.main, menu);
		return true;
	}
	
	public void cameraHandler(View v)
	{
		Intent cameraIntent = new Intent(android.provider.MediaStore.ACTION_IMAGE_CAPTURE);
		cameraIntent.setFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP);
		startActivityForResult(cameraIntent,CAMERA_PIC_REQUEST);
		
	}
	
	public void rightHandler (View v)
	{
		ImageView img = (ImageView)findViewById(R.id.imgCamera);
		img.buildDrawingCache();
		Bitmap bm = img.getDrawingCache();
		bm = rotateBitmap(bm, 90);
		img.setImageBitmap(bm);
		img.invalidate();
		
	}

	public void leftHandler (View v)
	{
		ImageView img = (ImageView)findViewById(R.id.imgCamera);
		img.buildDrawingCache();
		Bitmap bm = img.getDrawingCache();
		bm = rotateBitmap(bm, -90);
		img.setImageBitmap(bm);
		img.invalidate();
	}
	
	@Override
	protected void onActivityResult(int requestCode, int resultCode, Intent data) {
		// TODO Auto-generated method stub
		if(requestCode==CAMERA_PIC_REQUEST && resultCode==RESULT_OK && data!=null)
		{
			Bitmap bm = (Bitmap)data.getExtras().get("data");
			float galleryBitmapWidth = bm.getWidth();
			Resources r = getResources();
			int proposedWidth = 
					(int)TypedValue.applyDimension(TypedValue.COMPLEX_UNIT_DIP, 150, r.getDisplayMetrics());
			float scale = proposedWidth/galleryBitmapWidth;
			bm = getResizedBitmap(bm,(int)(bm.getHeight()*scale), proposedWidth);
			/*if(bm.getWidth() > bm.getHeight())
			{
				bm = rotateBitmap(bm, 90);
			}*/
			ImageView img = (ImageView)findViewById(R.id.imgCamera);
			img.setImageBitmap(bm);
			img.invalidate();
		}
		super.onActivityResult(requestCode, resultCode, data);
	}
	
	public static Bitmap rotateBitmap(Bitmap source, float angle)
	{
		Matrix matrix= new Matrix();
		matrix.postRotate(angle);
		return Bitmap.createBitmap(source, 0, 0, source.getWidth(), source.getHeight(),matrix,true);
	}
	
	public Bitmap getResizedBitmap(Bitmap bm, int newHeight,int newWidth){ 
    	int width = bm.getWidth();
    	int height = bm.getHeight();
    	float scaleWidth = ((float) newWidth)/width; 
    	float scaleHeight = ((float) newHeight)/height;
    	// create a matrix for the manipulation
    	Matrix matrix = new Matrix();
    	// resize the bitmap
    	matrix.postScale(scaleWidth, scaleHeight);
    	// create new bitmap
    	Bitmap resizedBitmap = Bitmap.createBitmap(bm, 0, 0, width, height, matrix, false);
    	return resizedBitmap; 
    	
    }

}


