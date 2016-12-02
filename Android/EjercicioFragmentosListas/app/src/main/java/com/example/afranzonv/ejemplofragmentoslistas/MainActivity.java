package com.example.afranzonv.ejemplofragmentoslistas;

import android.app.Fragment;
import android.app.FragmentManager;
import android.app.FragmentTransaction;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.Menu;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        FragmentManager fm=getFragmentManager();
        FragmentTransaction ft=fm.beginTransaction();

        Fragment fl=new FragmentoLista();
        ft.add(R.id.actividadPrincipal, fl);
        ft.commit();

       Fragment F2 =new BlankFragment();
       ft=fm.beginTransaction();
       ft.add(R.id.fragmento_agregar,F2);
       ft.commit();
    }
    /*public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_main, menu);
        return true;
    }*/
}
