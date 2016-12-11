package com.practica.practicaandroid;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

/**
 * Created by Pepe on 05/12/2016.
 */

public class ConexionBD extends SQLiteOpenHelper {

    public String cad = "CREATE TABLE IF NOT EXISTS mascotas(_id INTEGER PRIMARY KEY AUTOINCREMENT, nombre TEXT NOT NULL)";

    public ConexionBD(Context con){
        super(con, "Mascotas.db", null, 1);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        db.execSQL(cad);

    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int i, int i1) {
        String cad = "DROP TABLE IF EXISTS mascotas";
        db.execSQL(cad);
        onCreate(db);
    }
}
