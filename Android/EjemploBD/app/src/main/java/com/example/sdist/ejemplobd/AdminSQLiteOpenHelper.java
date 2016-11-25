package com.example.sdist.ejemplobd;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

/**
 * Created by sdist on 22/11/2016.
 */
public class AdminSQLiteOpenHelper extends SQLiteOpenHelper{

    public AdminSQLiteOpenHelper(Context context, String name, SQLiteDatabase.CursorFactory factory, int version) {
        super(context, name, factory, version);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        db.execSQL("CREATE TABLE ALUMNOS (" +
                "cu INTEGER PRIMARY KEY," +
                "nombre text," +
                "carrera text," +
                "universidad text)");
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL("DROP TABLE IF EXISTS ALUMNOS");
        db.execSQL("CREATE TABLE ALUMNOS (" +
                "cu INTEGER PRIMARY KEY," +
                "nombre text," +
                "carrera text," +
                "universidad text)");
    }
}
