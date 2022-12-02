using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_fina
{
    class Usuario
    {
        private string nombre;
        private string apellido_paterno;
        private string apellido_materno;
        private string sexo;
        private string fecha_nacimiento;
        private string curp;
        private string numero_nomina;
        private string correo_electronico;
        private string contraseña;
        private int id_usuario;
        private int id_tipo_rol;


        public Usuario()
        {
            this.Nombre = "";
            this.Apellido_paterno = "";
            this.Apellido_materno = "";
            this.Sexo = "";
            this.Fecha_nacimiento = "";
            this.Curp = "";
            this.Numero_nomina = "";
            this.Correo_electronico = "";
            this.Contraseña = "";
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido_paterno { get => apellido_paterno; set => apellido_paterno = value; }
        public string Apellido_materno { get => apellido_materno; set => apellido_materno = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Curp { get => curp; set => curp = value; }
        public string Numero_nomina { get => numero_nomina; set => numero_nomina = value; }
        public string Correo_electronico { get => correo_electronico; set => correo_electronico = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Id_tipo_rol { get => id_tipo_rol; set => id_tipo_rol = value; }
    }
}
