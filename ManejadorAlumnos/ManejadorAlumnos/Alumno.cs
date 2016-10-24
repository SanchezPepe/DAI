using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorAlumnos {
    class Alumno {
        public int folio { get; set;}
        public String nombre { get; set; }
        public String sexo { get; set; }
        public String correo { get; set; }
        public int semestre { get; set; }
        public int ingenieria { get; set; }

        public Alumno() {
        }

        public Alumno(int folio, String nombre, String sexo, String correo, int semestre, int ingenieria) {
            this.folio = folio;
            this.nombre = nombre;
            this.sexo = sexo;
            this.correo = correo;
            this.semestre = semestre;
            this.ingenieria = ingenieria;
        }

        public Alumno(int folio, String correo) {
            this.folio = folio;
            this.correo = correo;
        }
    }
}
