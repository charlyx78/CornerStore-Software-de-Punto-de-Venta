using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_fina
{
    class Descuentos
    {
        private int id_descuento;
        private string nombre_descuento;
        private int cantidad_descuento;
        private string fecha_inicio;
        private string fecha_fin;
        private int id_usuario;

        private string nuevo_nombre_descuento;
        private int nueva_cantidad_descuento;
        private string nueva_fecha_inicio;
        private string nueva_fecha_fin;
        private int nuevo_id_usuario;


        public Descuentos()
        {
            this.Nombre_descuento = "";
            this.cantidad_descuento = 0;
            this.Fecha_inicio = "";
            this.Fecha_fin = "";

            this.Nuevo_nombre_descuento = "";
            this.Nueva_cantidad_descuento = 0;
            this.Nueva_fecha_inicio = "";
            this.Nueva_fecha_fin = "";
        }

        public string Nombre_descuento { get => nombre_descuento; set => nombre_descuento = value; }
        public int Cantidad_descuento { get => cantidad_descuento; set => cantidad_descuento = value; }
        public string Nuevo_nombre_descuento { get => nuevo_nombre_descuento; set => nuevo_nombre_descuento = value; }
        public int Nueva_cantidad_descuento { get => nueva_cantidad_descuento; set => nueva_cantidad_descuento = value; }
        public int Id_descuento { get => id_descuento; set => id_descuento = value; }
        public string Fecha_inicio { get => fecha_inicio; set => fecha_inicio = value; }
        public string Fecha_fin { get => fecha_fin; set => fecha_fin = value; }
        public string Nueva_fecha_inicio { get => nueva_fecha_inicio; set => nueva_fecha_inicio = value; }
        public string Nueva_fecha_fin { get => nueva_fecha_fin; set => nueva_fecha_fin = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Nuevo_id_usuario { get => nuevo_id_usuario; set => nuevo_id_usuario = value; }
    }
}
