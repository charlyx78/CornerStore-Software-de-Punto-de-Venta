using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_fina
{
    class Productos
    {
        private int codigo_producto;
        private int id_departamento;
        private int id_descuento;
        private string nombre_producto;
        private string unidad_medida;
        private float costo;
        private float precio_unitario;
        private string descripcion;
        private string fecha_alta;
        private int cantidad_existencia;
        private int cantidad_merma;
        private int punto_reorden;
        private int habilitado_para_venta;
        private int id_usuario;

        private int nuevo_id_departamento;
        private int nuevo_id_descuento;
        private string nuevo_nombre_producto;
        private string nuevo_unidad_medida;
        private float nuevo_costo;
        private float nuevo_precio_unitario;
        private string nueva_descripcion;
        private string nuevo_fecha_alta;
        private int nuevo_cantidad_existencia;
        private int nuevo_cantidad_merma;
        private int nuevo_punto_reorden;
        private int nuevo_habilitado_para_venta;
        private int nuevo_id_usuario;

        public Productos()
        {
            this.Nombre_producto = "";
            this.Unidad_medida = "";
            this.Costo = 0;
            this.Precio_unitario = 0;
            this.Descripcion = "";
            this.Fecha_alta = "";
            this.Cantidad_existencia = 0;
            this.Cantidad_merma = 0;
            this.Punto_reorden = 0;
            this.Habilitado_para_venta = 0;

            this.Nuevo_nombre_producto = "";
            this.Nuevo_unidad_medida = "";
            this.Nuevo_costo = 0;
            this.Descripcion = "";
            this.Nuevo_precio_unitario = 0;
            this.Nuevo_fecha_alta = "";
            this.Nuevo_cantidad_existencia = 0;
            this.Nuevo_cantidad_merma = 0;
            this.Nuevo_punto_reorden = 0;
            this.Nuevo_habilitado_para_venta = 0;
            this.Nuevo_id_usuario = 0;
        }

        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public string Unidad_medida { get => unidad_medida; set => unidad_medida = value; }
        public float Costo { get => costo; set => costo = value; }
        public float Precio_unitario { get => precio_unitario; set => precio_unitario = value; }
        public string Fecha_alta { get => fecha_alta; set => fecha_alta = value; }
        public int Cantidad_existencia { get => cantidad_existencia; set => cantidad_existencia = value; }
        public int Cantidad_merma { get => cantidad_merma; set => cantidad_merma = value; }
        public int Punto_reorden { get => punto_reorden; set => punto_reorden = value; }
        public int Habilitado_para_venta { get => habilitado_para_venta; set => habilitado_para_venta = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Codigo_producto { get => codigo_producto; set => codigo_producto = value; }
        public string Nuevo_nombre_producto { get => nuevo_nombre_producto; set => nuevo_nombre_producto = value; }
        public string Nuevo_unidad_medida { get => nuevo_unidad_medida; set => nuevo_unidad_medida = value; }
        public float Nuevo_costo { get => nuevo_costo; set => nuevo_costo = value; }
        public float Nuevo_precio_unitario { get => nuevo_precio_unitario; set => nuevo_precio_unitario = value; }
        public string Nuevo_fecha_alta { get => nuevo_fecha_alta; set => nuevo_fecha_alta = value; }
        public int Nuevo_cantidad_existencia { get => nuevo_cantidad_existencia; set => nuevo_cantidad_existencia = value; }
        public int Nuevo_cantidad_merma { get => nuevo_cantidad_merma; set => nuevo_cantidad_merma = value; }
        public int Nuevo_punto_reorden { get => nuevo_punto_reorden; set => nuevo_punto_reorden = value; }
        public int Nuevo_habilitado_para_venta { get => nuevo_habilitado_para_venta; set => nuevo_habilitado_para_venta = value; }
        public int Nuevo_id_usuario { get => nuevo_id_usuario; set => nuevo_id_usuario = value; }
        public int Id_departamento { get => id_departamento; set => id_departamento = value; }
        public int Id_descuento { get => id_descuento; set => id_descuento = value; }
        public int Nuevo_id_departamento { get => nuevo_id_departamento; set => nuevo_id_departamento = value; }
        public int Nuevo_id_descuento { get => nuevo_id_descuento; set => nuevo_id_descuento = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Nueva_descripcion { get => nueva_descripcion; set => nueva_descripcion = value; }
    }
}
