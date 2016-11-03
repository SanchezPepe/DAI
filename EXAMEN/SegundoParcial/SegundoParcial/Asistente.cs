using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial
{
    class Asistente
    {
        public int claveU { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public char sexo { get; set; }
        public String correo { get; set; }
        public String carrera { get; set; }
        public String uni { get; set; }

        public Asistente(int clave, String nom, String ap, char sexo, String correo, String car, String uni){
            this.claveU = clave;
            this.nombre = nom;
            this.apellido = ap;
            this.sexo = sexo;
            this.correo = correo;
            this.carrera = car;
            this.uni = uni;
        }

        public Asistente(int clave, String nom, String ap, char sexo, String correo)
        {
            this.claveU = clave;
            this.nombre = nom;
            this.apellido = ap;
            this.sexo = sexo;
            this.correo = correo;
        }

    }

    
}
