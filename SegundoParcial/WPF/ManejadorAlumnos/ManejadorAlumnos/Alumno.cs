using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorAlumnos {
    class Alumno {
        public int folio { get; set; }
        public String nombre { get; set; }
        public String sexo { get; set; }
        public String correo { get; set; }
        public int semestre { get; set; }
        public String ingenieria { get; set; }

        public Alumno() {
        }

        public Alumno(String nombre, String sexo, String correo, int semestre, String ingenieria) {
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
