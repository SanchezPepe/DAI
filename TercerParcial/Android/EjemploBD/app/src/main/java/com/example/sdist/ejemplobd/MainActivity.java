package com.example.sdist.ejemplobd;

import android.content.ContentValues;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    EditText et1, et2, et3, et4;



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        et1 = (EditText)findViewById(R.id.edtCU);
        et2 = (EditText)findViewById(R.id.edtNom);
        et3 = (EditText)findViewById(R.id.edtCar);
        et4 = (EditText)findViewById(R.id.edtUni);
    }

    public void alta(View v){
        AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, "Administracion", null, 1);
        SQLiteDatabase db = admin.getWritableDatabase();
        String cu = et1.getText().toString();
        String nombre = et2.getText().toString();
        String carrera = et3.getText().toString();
        String uni = et4.getText().toString();

        ContentValues registro = new ContentValues();
        registro.put("cu", cu);
        registro.put("nombre", nombre);
        registro.put("carrera", carrera);
        registro.put("universidad", uni);

        db.insert("ALUMNOS", null, registro);
        db.close();

        limpia(v);

        mostrar("Se cargaron los datos correctamente");

    }

    public void consulta(View v){
        AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, "Administracion", null, 1);
        SQLiteDatabase db = admin.getWritableDatabase();
        String cu = et1.getText().toString();
        Cursor file = db.rawQuery("SELECT nombre, carrera, universidad FROM alumnos WHERE cu = " + cu, null);
        if(file.moveToFirst()){
            et2.setText(file.getString(0));
            et3.setText(file.getString(1));
            et4.setText(file.getString(2));
        } else{
            mostrar("No existe");
        }
        db.close();

    }

    public void elimina(View v){
        AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, "Administracion", null, 1);
        SQLiteDatabase db = admin.getWritableDatabase();
        String cu = et1.getText().toString();
        int cant = db.delete("alumnos", "cu = " + cu, null);
        db.close();
        limpia(v);
        if(cant == 1){
            mostrar("Se eliminó correctamente");
        } else{
            mostrar("El alumno no existe");
        }
        db.close();
    }

    public void modifica(View v){
        AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, "Administracion", null, 1);
        SQLiteDatabase db = admin.getWritableDatabase();
        String cu = et1.getText().toString();
        String nombre = et2.getText().toString();
        String carrera = et3.getText().toString();
        String uni = et4.getText().toString();

        ContentValues registro = new ContentValues();
        registro.put("cu", cu);
        registro.put("nombre", nombre);
        registro.put("carrera", carrera);
        registro.put("universidad", uni);

        db.update("alumnos", registro, "cu = " + cu, null);
        db.close();

        limpia(v);

        mostrar("Se actualizó los datos correctamente");
    }

    public void limpia(View v){
        et1.setText("");
        et2.setText("");
        et3.setText("");
        et4.setText("");
    }

    public void mostrar(String s){
        Toast.makeText(this, s, Toast.LENGTH_SHORT).show();
    }
}
