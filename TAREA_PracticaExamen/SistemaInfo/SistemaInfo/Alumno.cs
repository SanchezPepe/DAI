using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInfo
{
    class Alumno
    {
        public String nombre { get; set; }
        public char sexo { get; set; }
        public String fechaN { get; set; }
        public String correo { get; set; }
        public int grado { get; set; }
        public int programa { get; set; }

        public Alumno()
        {
        }

        public Alumno(String nombre, char sexo, String fechaN, String correo, int grado, int prog)
        {
            this.nombre = nombre;
            this.sexo = sexo;
            this.fechaN = fechaN;
            this.correo = correo;
            this.grado = grado;
            this.programa = prog;
        }

        public Alumno(String nombre, String correo)
        {
            this.nombre = nombre;
            this.correo = correo;
        }
    }
}
