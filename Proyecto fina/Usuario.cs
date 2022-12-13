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
        private string nuevo_nombre;
        private string nuevo_apellido_paterno;
        private string nuevo_apellido_materno;
        private string nuevo_sexo;
        private string nuevo_fecha_nacimiento;
        private string nuevo_curp;
        private string nuevo_numero_nomina;
        private string nuevo_correo_electronico;
        private string nuevo_contraseña;
        private int id_usuario;
        private int id_tipo_rol;
        private int usuario_cambios;


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
            this.Nuevo_nombre = "";

            this.Nuevo_apellido_paterno = "";
            this.Nuevo_apellido_materno = "";
            this.Nuevo_sexo = "";
            this.Nuevo_fecha_nacimiento = "";
            this.Nuevo_curp = "";
            this.Nuevo_numero_nomina = "";
            this.Nuevo_correo_electronico = "";
            this.Nuevo_contraseña = "";
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
        public string Nuevo_nombre { get => nuevo_nombre; set => nuevo_nombre = value; }
        public string Nuevo_apellido_paterno { get => nuevo_apellido_paterno; set => nuevo_apellido_paterno = value; }
        public string Nuevo_apellido_materno { get => nuevo_apellido_materno; set => nuevo_apellido_materno = value; }
        public string Nuevo_sexo { get => nuevo_sexo; set => nuevo_sexo = value; }
        public string Nuevo_fecha_nacimiento { get => nuevo_fecha_nacimiento; set => nuevo_fecha_nacimiento = value; }
        public string Nuevo_curp { get => nuevo_curp; set => nuevo_curp = value; }
        public string Nuevo_numero_nomina { get => nuevo_numero_nomina; set => nuevo_numero_nomina = value; }
        public string Nuevo_correo_electronico { get => nuevo_correo_electronico; set => nuevo_correo_electronico = value; }
        public string Nuevo_contraseña { get => nuevo_contraseña; set => nuevo_contraseña = value; }
        public int Usuario_cambios { get => usuario_cambios; set => usuario_cambios = value; }
    }
}
