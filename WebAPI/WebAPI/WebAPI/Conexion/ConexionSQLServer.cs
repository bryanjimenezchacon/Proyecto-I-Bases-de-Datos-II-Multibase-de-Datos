using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Reflection;
using System.Data.Common;

namespace WebApplication3.Conexiones
{
    /// <summary>
    /// Descripción breve de ConexionSQLServer
    /// </summary>
    public class ConexionSQLServer
    {
        // Paso 1 - Crear una instancia de la clase SqlConnection
        string datosConexion = "Data Source = localhost\\SQLEXPRESS;"
        + "Initial Catalog = Base1SQLSERVER ; Integrated Security = true;";
        public ConexionSQLServer()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(datosConexion))
                    //Paso 2 - Abrir la conexión
                    con.Open();

                // Paso 3 - Crear un nuevo comando

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void consulta()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(datosConexion))
                {
                    //Paso 2 - Abrir la conexión
                    con.Open();

                    // Paso 3 - Crear un nuevo comando

                    string textoCmd = "UPDATE Base1SQLSERVER.dbo.TablaPruebaSQL set columna1= 666 where columna2 = 12;";

                    SqlCommand cmd = new SqlCommand(textoCmd, con);

                    //Paso 4 - Ejecutar el comando
                    try
                    {
                        cmd.ExecuteNonQuery();

                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }

        public string ConvertDataTabletoString()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(datosConexion))
            {
                //Paso 2 - Abrir la conexión
                con.Open();
                string textoCmd = "select * from Base1SQLSERVER.dbo.TablaPruebaSQL;";

                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
                Dictionary<string, object> row;
                foreach (DataRow dr in dt.Rows)
                {
                    row = new Dictionary<string, object>();
                    foreach (DataColumn col in dt.Columns)
                    {
                        row.Add(col.ColumnName, dr[col]);
                    }
                    rows.Add(row);
                }
                return serializer.Serialize(rows);
            }
        }
    }
}