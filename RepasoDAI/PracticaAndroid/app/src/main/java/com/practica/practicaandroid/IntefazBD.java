package com.practica.practicaandroid;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteDatabaseLockedException;
import android.database.sqlite.SQLiteException;

import java.sql.SQLDataException;

/**
 * Created by Pepe on 05/12/2016.
 */

public class IntefazBD {

    ConexionBD con;
    SQLiteDatabase db;

    public IntefazBD(Context c){
        con = new ConexionBD(c);
    }

    public void open() throws SQLiteException{
        db = con.getWritableDatabase();
    }

    public void close() throws SQLDataException{
        con.close();
    }

    public long insertaDato(String s){
        ContentValues cv = new ContentValues();
        open();
        cv.put("nombre", s);
        long res = db.insert("mascotas", null, cv);
        return res;
    }

    public void insertaDatosPrueba(){
        insertaDato("Perro");
        insertaDato("Gato");
        insertaDato("Iguana");
        insertaDato("Perico");
        insertaDato("Pez");
        insertaDato("Mono");
    }

    public String traerNomre(long id){
        open();
        String cad = "SELECT nombre FROM mascotas WHERE _id = " + id;
        Cursor c = db.rawQuery(cad, null);
        c.moveToFirst();
        String res = c.getString(0);
        c.close();
        return res;
    }

    public Cursor traerTodos() {
        open();
        Cursor res = null;
        String cad = "SELECT * FROM mascotas";
        res = db.rawQuery(cad, null);
        res.moveToFirst();
        if(res.getCount() == 0) {
            insertaDatosPrueba();
            res = db.rawQuery(cad, null);
        }
        return res;
    }

    public void elimina(int id){
        open();
        db.delete("mascotas", "_id = " + id, null);
    }

    public int cuentaElems(){
        open();
        String query = "SELECT MAX(_id) FROM mascotas";
        Cursor res = db.rawQuery(query, null);
        res.moveToFirst();
        return res.getInt(0);
    }



}
