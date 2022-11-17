using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.modelo
{
    internal class Usuario
    {
        private string documento;
        private string nombres;
        private string apellidos;
        private int edad;
        private string direccion;

        public Usuario ()
        {
            this.documento = "";
            this.nombres = "";
            this.apellidos= "";
            this.edad = 0;
            this.direccion = "";

        }

        public string Documento { get => documento; set => documento = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
