using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_fina
{

    class Utilidades
    {
        public static System.Drawing.Font printFont;
        public static StreamReader streamToPrint;
        public int getUltimoIDUsuario(string tabla)
        {
            int id = 0;
            Conexion con = new Conexion();
            string ultimo_id = "SELECT IDENT_CURRENT('" + tabla + "') as id;";
            SqlCommand cmd = new SqlCommand(ultimo_id, con.conectar());
            id = Convert.ToInt32(cmd.ExecuteScalar());
            return id;
        }
        public static float getPrecioProducto(int id_producto)
        {
            float precio = 0;
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("SP_OBTENER_PRECIO_PRODUCTO", con.conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_producto", id_producto);
            precio = (float)Convert.ToDecimal(cmd.ExecuteScalar());
            return precio;
        }
        public static float getDescuentoProducto(int id_producto)
        {
            float descuento = 0;
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("SP_OBTENER_DESCUENTO_PRODUCTO", con.conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_producto", id_producto);
            descuento = Convert.ToInt32(cmd.ExecuteScalar());
            descuento /= 100;
            return descuento;
        }
        public static string getNombreUsuario(int id_usuario_rol)
        {
            string nombreUsuario = "";
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("SP_IMPRIMIR_NOMBRE", con.conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_usuario_rol", id_usuario_rol);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                nombreUsuario = rd.GetString(0);
            }
            return nombreUsuario;
        }

        public SqlDataReader getUsuarioCambio(string tabla, string columna, int id)
        {
            Conexion con = new Conexion();
            string usuario = "SELECT CONCAT(nombre, ' ', apellido_paterno, ' ', apellido_materno) FROM tb_usuario A INNER JOIN " + tabla + " B ON A.id_usuario=B.usuario_cambios WHERE " + columna + "= " + id + ";";
            SqlCommand comando = new SqlCommand(usuario, con.conectar());
            SqlDataReader rd = comando.ExecuteReader();
            return rd;
        }
        public SqlDataReader getFechaCambio(string tabla, string columna, int id)
        {
            Conexion con2 = new Conexion();
            string fecha = "SELECT fecha_cambios FROM " + tabla + " WHERE " + columna + "= " + id + ";";
            SqlCommand comando = new SqlCommand(fecha, con2.conectar());
            SqlDataReader rd2 = comando.ExecuteReader();
            return rd2;
        }
        public static SqlDataReader convertirID(string idColumn, string table, string column, string value)
        {
            Conexion con = new Conexion();
            string deptos = "SELECT " + idColumn + " FROM " + table + " WHERE " + column + "= '" + value + "';";
            SqlCommand comando = new SqlCommand(deptos, con.conectar());
            SqlDataReader rd = comando.ExecuteReader();
            return rd;
        }
        public int stringToInt(string texto)
        {
            int valor;
            valor = Int32.Parse(texto);
            return valor;
        }

        public class CreaTicket
        {
            public static StringBuilder line = new StringBuilder();
            string ticket = "";
            string parte1, parte2;

            public static int max = 45;
            int cort;
            private string[] cadenaserver;

            public byte[] Serverbyte { get; private set; }

            public static string LineasGuion()
            {
                string LineaGuion = "--------------------------------------------------";   // agrega lineas separadoras -

                return line.AppendLine(LineaGuion).ToString();
            }


            public static void EncabezadoVenta()
            {
                string LineEncavesado = "Articulo       Cant   Precio    Subtotal     Desc.";   // 40 caracteres agrega lineas de  encabezados
                line.AppendLine(LineEncavesado);
            }
            public void TextoIzquierda(string par1)                          // agrega texto a la izquierda
            {
                max = par1.Length;
                if (max > 50)                                 // **********
                {
                    cort = max - 50;
                    parte1 = par1.Remove(50, cort);        // si es mayor que 40 caracteres, lo corta
                }
                else { parte1 = par1; }                      // **********
                line.AppendLine(ticket = parte1);

            }
            public void TextoDerecha(string par1)
            {
                ticket = "";
                max = par1.Length;
                if (max > 40)                                 // **********
                {
                    cort = max - 40;
                    parte1 = par1.Remove(40, cort);           // si es mayor que 40 caracteres, lo corta
                }
                else { parte1 = par1; }                      // **********
                max = 45 - par1.Length;                     // obtiene la cantidad de espacios para llegar a 40
                for (int i = 0; i < max; i++)
                {
                    ticket += " ";                          // agrega espacios para alinear a la derecha
                }
                line.AppendLine(ticket += parte1 + "\n");                //Agrega el texto

            }
            public void TextoCentro(string par1)
            {
                ticket = "";
                max = par1.Length;
                if (max > 50)                                 // **********
                {
                    cort = max - 50;
                    parte1 = par1.Remove(50, cort);          // si es mayor que 40 caracteres, lo corta
                }
                else { parte1 = par1; }                      // **********
                max = (int)(50 - parte1.Length) / 2;         // saca la cantidad de espacios libres y divide entre dos
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios antes del texto a centrar
                }                                            // **********
                line.AppendLine(ticket += parte1 + "\n");

            }
            public void TextoExtremos(string par1, string par2)
            {
                max = par1.Length;
                if (max > 18)                                 // **********
                {
                    cort = max - 18;
                    parte1 = par1.Remove(18, cort);          // si par1 es mayor que 18 lo corta
                }
                else { parte1 = par1; }                      // **********
                ticket = parte1;                             // agrega el primer parametro
                max = par2.Length;
                if (max > 18)                                 // **********
                {
                    cort = max - 18;
                    parte2 = par2.Remove(18, cort);          // si par2 es mayor que 18 lo corta
                }
                else { parte2 = par2; }
                max = 40 - (parte1.Length + parte2.Length);
                for (int i = 0; i < max; i++)                 // **********
                {
                    ticket += " ";                            // Agrega espacios para poner par2 al final
                }                                             // **********
                line.AppendLine(ticket += parte2 + "\n");                   // agrega el segundo parametro al final

            }
            public void AgregaTotales(string par1, double total)
            {
                max = par1.Length;
                if (max > 25)                                 // **********
                {
                    cort = max - 25;
                    parte1 = par1.Remove(25, cort);          // si es mayor que 25 lo corta
                }
                else { parte1 = par1; }                      // **********
                ticket = parte1;
                parte2 = total.ToString() + "$";
                max = 50 - (parte1.Length + parte2.Length);
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios para poner el valor de moneda al final
                }                                            // **********
                line.AppendLine(ticket += parte2 + "\n");

            }

            // se le pasan los Aticulos  con sus detalles
            public void AgregaArticulo(string Articulo, double precio, double cant, double subtotal, int desc)
            {
                if (cant.ToString().Length <= 5 && precio.ToString("c").Length <= 15 && subtotal.ToString("c").Length <= 16 && desc.ToString().Length <= 8) // valida que cant precio y total esten dentro de rango
                {
                    string elementos = "", espacios = "";
                    bool bandera = false;
                    int nroEspacios = 0;

                    if (Articulo.Length > 45)                                 // **********
                    {
                        //cort = max - 16;
                        //parte1 = Articulo.Remove(16, cort);          // corta a 16 la descripcion del articulo
                        nroEspacios = (3 - cant.ToString().Length);
                        espacios = "";
                        for (int i = 0; i < nroEspacios; i++)
                        {
                            espacios += " ";
                        }
                        elementos += espacios + cant.ToString();

                        // colocamos el precio a la derecha
                        nroEspacios = (10 - precio.ToString().Length);
                        espacios = "";

                        for (int i = 0; i < nroEspacios; i++)
                        {
                            espacios += " ";
                        }
                        elementos += espacios + precio.ToString() + "$";

                        //colocar el subtotal a la dercha
                        nroEspacios = (10 - subtotal.ToString().Length);
                        espacios = "";

                        for (int i = 0; i < nroEspacios; i++)
                        {
                            espacios += " ";
                        }
                        elementos += espacios + subtotal.ToString() + "$";

                        //colocar el descuento a la dercha
                        nroEspacios = (8 - desc.ToString().Length);
                        espacios = "";

                        for (int i = 0; i < nroEspacios; i++)
                        {
                            espacios += " ";
                        }
                        elementos += espacios + desc.ToString() + "%";

                        int CaracterActual = 0;// indica en que caracter se quedo
                        for (int Longtext = Articulo.Length; Longtext > 16; Longtext++)
                        {
                            if (bandera == false)
                            {
                                line.AppendLine(Articulo.Substring(CaracterActual, 16) + elementos);
                                bandera = true;
                            }
                            else
                            {
                                line.AppendLine(Articulo.Substring(CaracterActual, 16));

                            }
                            CaracterActual += 16;
                        }
                        line.AppendLine(Articulo.Substring(CaracterActual, Articulo.Length - CaracterActual));


                    }
                    else
                    {
                        for (int i = 0; i < (16 - Articulo.Length); i++)
                        {
                            espacios += " ";

                        }
                        elementos = Articulo + espacios;

                        nroEspacios = (3 - cant.ToString().Length);
                        espacios = "";
                        for (int i = 0; i < nroEspacios; i++)
                        {
                            espacios += " ";
                        }
                        elementos += espacios + cant.ToString();

                        // colocamos el precio a la derecha
                        nroEspacios = (10 - precio.ToString().Length);
                        espacios = "";

                        for (int i = 0; i < nroEspacios; i++)
                        {
                            espacios += " ";
                        }
                        elementos += espacios + precio.ToString() + "$";

                        //colocar el subtotal a la dercha
                        nroEspacios = (10 - subtotal.ToString().Length);
                        espacios = "";

                        for (int i = 0; i < nroEspacios; i++)
                        {
                            espacios += " ";
                        }
                        elementos += espacios + subtotal.ToString() + "$";

                        //colocar el descuento a la dercha
                        nroEspacios = (8 - desc.ToString().Length);
                        espacios = "";

                        for (int i = 0; i < nroEspacios; i++)
                        {
                            espacios += " ";
                        }
                        elementos += espacios + desc.ToString() + "%";

                        line.AppendLine(elementos);

                    }
                }
                else
                {
                    MessageBox.Show("Valores fuera de rango");

                }
            }

            public void ImprimirTiket(string Impresora)
            {
                File.WriteAllText("Factura.txt", line.ToString());


                line = new StringBuilder();

                try
                {
                    streamToPrint = new StreamReader
                       ("Factura.txt");
                    try
                    {
                        printFont = new System.Drawing.Font("Consolas", 10);
                        PrintDocument pd = new PrintDocument();
                        pd.PrintPage += new PrintPageEventHandler
                           (this.pd_PrintPage);
                        //  pd.PrinterSettings.PrinterName = "EPSON L3110 SERIES";// Nombre de la impresora
                        //pd.PrinterSettings.PrinterName = "Microsoft Print to PDF";// Nombre de la impresora
                        pd.PrinterSettings.PrinterName = Impresora;// Nombre de la impresora

                        //pd.DefaultPageSettings.PaperSize = new PaperSize("", 10, 800);
                        pd.DocumentName = "Factura" + DateTime.Now.ToString();

                        pd.Print();
                    }
                    finally
                    {
                        streamToPrint.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Elija impresora valida");
                }


            }
            public void pd_PrintPage(object sender, PrintPageEventArgs ev)
            {
                float linesPerPage = 0;
                float yPos = 0;
                int count = 0;
                float leftMargin = ev.MarginBounds.Left;
                float topMargin = ev.MarginBounds.Top;
                string line = null;



                // Calculate the number of lines per page.
                linesPerPage = ev.MarginBounds.Height /
                   printFont.GetHeight(ev.Graphics);

                // Print each line of the file.
                while (count < linesPerPage &&
                   ((line = streamToPrint.ReadLine()) != null))
                {
                    yPos = topMargin + (count *
                       printFont.GetHeight(ev.Graphics));
                    ev.Graphics.DrawString(line, printFont, Brushes.Black,
                       leftMargin, yPos, new StringFormat());
                    count++;

                }

                // If more lines exist, print another page.
                if (line != null)
                    ev.HasMorePages = true;
                else
                    ev.HasMorePages = false;
            }
        }
    }
}
