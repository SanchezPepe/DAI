package com.practica.practicaandroid;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.TextView;

public class Menu extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menu);

        Bundle b = new Bundle();
        b = this.getIntent().getExtras();
        String s = b.getString("Animal");

        TextView t = (TextView)findViewById(R.id.tvANimal);
        t.setText(s);


    }
}
