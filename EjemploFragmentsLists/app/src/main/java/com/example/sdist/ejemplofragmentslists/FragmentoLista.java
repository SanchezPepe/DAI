package com.example.sdist.ejemplofragmentslists;


import android.database.Cursor;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.support.v4.app.ListFragment;
import android.support.v4.widget.SimpleCursorAdapter;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ListView;
import android.widget.Toast;


/**
 * A simple {@link Fragment} subclass.
 */
public class FragmentoLista extends ListFragment{

    ListView lv;
    InterfazBD ibd;

    public FragmentoLista() {
        // Required empty public constructor
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        Cursor res;
        //ADAPTADOR
        SimpleCursorAdapter sca;
        View v = super.onCreateView(inflater, container, savedInstanceState);
        String arregloC[] = {"_id","_datos"};
        int to[] = {R.id.texto1, R.id.texto2};
        //CREAR LA CONEXION CON LA BASE DE DATOS
        ibd = new InterfazBD(this.getActivity());
        //CURSOR DE LA BASE DE DATOS CON LOS RESULTADOS DE LA TABLA
        res = ibd.traerDatos();
        //PASARLE EL CURSOR A LA ACTIVIDAD Y CREAR EL ADAPTADOR PARA MOSTRAR LOS DATOS
        sca = new SimpleCursorAdapter(this.getActivity(), R.layout.formato_renglon, res, arregloC, to, 0);
        this.setListAdapter(sca);
        return v;
    }

    public void onListItemClick(ListView l, View v, int position, long id){
        if(ibd == null)
                ibd = new InterfazBD(this.getActivity());
        String s = ibd.traerDatos(id);
        Toast t = Toast.makeText(getActivity(), s, Toast.LENGTH_LONG);
        t.show();
    }

}
