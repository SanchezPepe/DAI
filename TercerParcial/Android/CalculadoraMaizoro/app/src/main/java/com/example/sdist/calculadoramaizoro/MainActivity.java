package com.example.sdist.calculadoramaizoro;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    private EditText op1, op2;
    private RadioGroup rg;
    private int op;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        op1 = (EditText)findViewById(R.id.editText);
        op2 = (EditText)findViewById(R.id.editText2);
        rg = (RadioGroup)findViewById(R.id.radiogroup);

    }

    public void operacion(View v){
        op = rg.getCheckedRadioButtonId();
        double num1, num2, res = 0;
        try{
            num1 = Integer.parseInt(op1.getText().toString());
            num2 = Integer.parseInt(op2.getText().toString());
            switch (op){
                case 2131492949:
                    res = num1 + num2;
                    break;
                case 2131492950:
                    res = num1 - num2;
                    break;
                case 2131492951:
                    if(num2 != 0)
                        res = num1/num2;
                    else {
                        res = -1;
                        mostrar("No se puede dividir entre 0");
                    }
                    break;
                case 2131492952:
                    res = num1*num2;
                    break;
                case 2131492953:
                    res = Math.sqrt(num1);
                    break;
                case 2131492954:
                    res = Math.pow(num1, num2);
                    break;
                default:
                    mostrar("No se seleccionó nada");
                    break;
            }
            mostrar(res);
        }catch(Exception e){
            mostrar("Vacío");
        }
    }

    public void mostrar(Object o){
        Toast.makeText(this, "Resultado: " + o.toString(),Toast.LENGTH_LONG).show();
    }


}
