package com.practica.practicaandroid;

import android.content.ClipData;
import android.content.Intent;
import android.database.Cursor;
import android.view.View;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.EditText;
import android.widget.SimpleCursorAdapter;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.ListView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    IntefazBD ibd;
    Cursor res;
    SimpleCursorAdapter sca;
    ListView lv;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        ibd = new IntefazBD(this);
        //Lenar la lista con los elementos actualas de la tabla
        lv = (ListView)findViewById(R.id.lvMascot);
        String col [] = {"_id","nombre"};
        int to[] = {R.id.idMas, R.id.nombreMasc};
        res = ibd.traerTodos();
        sca = new SimpleCursorAdapter(this, R.layout.formato_renglon, res, col, to, 0);
        lv.setAdapter(sca);

        lv.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            EditText ed = (EditText)findViewById(R.id.editText);
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                // When clicked, show a toast with the TextView text or do whatever you need.
                String nom = ibd.traerNomre(id);
                ed.setText(nom);
                Toast.makeText(getApplicationContext(), ibd.traerNomre(id), Toast.LENGTH_SHORT).show();
                Bundle b = new Bundle();
                Intent i = new Intent(MainActivity.this, Menu.class);
                b.putString("Animal", nom);
                i.putExtras(b);
                startActivity(i);
            }
        });

        Button b = (Button)findViewById(R.id.button);
        b.setOnClickListener(new View.OnClickListener() {
            EditText et = (EditText)findViewById(R.id.editText);
            public void onClick(View view) {
                ibd.insertaDato(et.getText().toString());
                res = ibd.traerTodos();
                sca.changeCursor(res);
            }
        });

        Button b2 = (Button)findViewById(R.id.btElimina);
        b2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                mensaje("" + ibd.cuentaElems());
                ibd.elimina(ibd.cuentaElems());
                res = ibd.traerTodos();
                sca.changeCursor(res);
            }
        });
    }

    public void mensaje(String s){
        Toast t = Toast.makeText(this, s, Toast.LENGTH_LONG);
        t.show();
    }
}
