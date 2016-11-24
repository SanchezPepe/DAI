package com.example.sdist.ejemplofragmentslists;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

/**
 * Created by sdist on 24/11/2016.
 */
public class ConexionBD extends SQLiteOpenHelper {

    String cadenaCreate = "CREATE TABLE IF NOT EXISTS tablaPrueba(" +
            "_id INTEGER PRIMARY AUTOINCREMENT," +
            "datos TEXT NOT NULL);";

    public ConexionBD(Context context){
        super(context, "prueba.db", null, 1);
    }

    public void onCreate(SQLiteDatabase db){
        db.execSQL(cadenaCreate);
    }

    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion){
        String cad = "DROP TABLE IF EXISTS tablaPrueba;";
        db.execSQL(cad);
        onCreate(db);
    }



}
