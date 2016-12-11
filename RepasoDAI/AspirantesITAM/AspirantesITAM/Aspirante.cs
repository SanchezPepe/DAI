using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspirantesITAM
{
    class Aspirante
    {
        public String nombre { get; set; }
        public char sexo { get; set; }
        public String fechaNac { get; set; }
        public String correo { get; set; }
        public int grado { get; set; }
        public String programa { get; set; }


        public Aspirante(){

        }

        public Aspirante(String nom, char sxo, String fN, String correo, int grado, String programa)
        {
            this.nombre = nom;
            this.sexo = sxo;
            this.fechaNac = fN;
            this.correo = correo;
            this.grado = grado;
            this.programa = programa;
        }

    }
}
