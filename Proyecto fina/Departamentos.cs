using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_fina
{
    class Departamentos
    {
        private int id_departamento;
        private string nombre_departamento;
        private int id_usuario;
        private string fecha;

        private string nuevo_nombre_departamento;
        private int nuevo_id_usuario;
        private string nueva_fecha;

        public Departamentos()
        {
            this.Fecha = "";
            this.Nombre_departamento = "";

            this.Nuevo_nombre_departamento = "";
        }

        public string Nombre_departamento { get => nombre_departamento; set => nombre_departamento = value; }
        public string Nuevo_nombre_departamento { get => nuevo_nombre_departamento; set => nuevo_nombre_departamento = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int Id_departamento { get => id_departamento; set => id_departamento = value; }
        public int Nuevo_id_usuario { get => nuevo_id_usuario; set => nuevo_id_usuario = value; }
        public string Nueva_fecha { get => nueva_fecha; set => nueva_fecha = value; }
    }

}
