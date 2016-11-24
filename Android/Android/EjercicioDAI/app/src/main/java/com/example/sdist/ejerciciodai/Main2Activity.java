package com.example.sdist.ejerciciodai;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.TextView;

public class Main2Activity extends AppCompatActivity {

    private TextView txtSaludo;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main2);

        txtSaludo = (TextView)findViewById(R.id.textView4);

        Bundle bundle = this.getIntent().getExtras();
        txtSaludo.setText("Éxito: " + bundle.get("Nombre"));
    }
}
