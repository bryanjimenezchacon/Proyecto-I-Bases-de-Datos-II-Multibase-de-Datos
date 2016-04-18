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
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace WebApplication3.Conexiones
{
    /// <summary>
    /// Descripción breve de Class1
    /// </summary>
    public class ConexionMariaDBMeta
    {
        private DbConnection dbcon;
        private DbCommand dbcomn;
        private String cadenaConexion;
        private static DbProviderFactory fabrica = null;
        MySqlConnection Conexion = new MySqlConnection("Data Source=localhost;Database=META;User id=root;Password='salmo23';");
        public ConexionMariaDBMeta()
        {
            try
            {
                string proveedor = @"MySql.Data.MySqlClient";
                this.cadenaConexion = @"Data Source = localhost; Database = META; User id = root; Password = 'salmo23';";
                fabrica = DbProviderFactories.GetFactory(proveedor);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectarse a META", ex);
            }


        }

        public void conectar()
        {
            try
            {
                if (this.dbcon != null && !this.dbcon.State.Equals(ConnectionState.Closed))
                {
                    throw new Exception("La conexion con META esta abierta");

                }
                if (this.dbcon == null)
                {
                    this.dbcon = fabrica.CreateConnection();
                    this.dbcon.ConnectionString = this.cadenaConexion;
                }
                this.dbcon.Open();

            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectarse a META ", ex);
            }
        }
        public void InsertarMongo(string database_name) {
            try
            {
                Conexion.Open();
                MySqlCommand Insertar = new MySqlCommand("INSERT INTO meta.mongobds(Name) VALUES('" + database_name + "');", Conexion);
                Insertar.ExecuteNonQuery();
                Conexion.Clone();
            }
            catch (Exception e) {
            }

        }
        public string Insertar(string database_type, string user,string  pass, string server,string protocol,string port, string alias, string nombre)
        {
            try
            {
                Conexion.Open();
                MySqlCommand Insertar = new MySqlCommand("INSERT INTO meta.bds (database_type, user, pass, server, protocol, port, alias, nombre) VALUES ('" + database_type +"','"+user+"', '"+server+"', '"+server+"', '"+protocol+"', "+ port + ", '" + alias + "', '" + nombre + "');", Conexion);
                Insertar.ExecuteNonQuery();
                Conexion.Clone();

                return ("Datos Insertados Correctamente en MEtA");
            }
            catch (Exception error)
            {
                return ("Error, Insertar en META");

            }
        }

        public string Eliminar(int Codigo)
        {
            try
            {
                Conexion.Open();
                MySqlCommand Eliminar = new MySqlCommand("DELETE FROM datos WHERE columna1 = " + Codigo + ";", Conexion);
                Eliminar.ExecuteNonQuery();
                Conexion.Clone();

                return ("Datos Eliminados Correctamente en MEtA");
            }
            catch (Exception error)
            {
                return ("Error, Eliminar en META");

            }
        }

        public string Actualizar(int Codigo, int Nombres, int Apellidos, int Direccion)
        {
            try
            {
                Conexion.Open();
                MySqlCommand Actualizar = new MySqlCommand("UPDATE datos SET columna1 = 99 WHERE Columna1 = + " + Codigo + ";", Conexion);
                Actualizar.ExecuteNonQuery();
                Conexion.Clone();

                return ("Datos Actualizados Correctamente en MEtA");
            }
            catch (Exception error)
            {
                return ("Error, Actualizados en META");

            }
        }

        public void desconectar()
        {
            if (this.dbcon.State == ConnectionState.Open)
            {
                this.dbcon.Close();
                throw new Exception("Se ha desconectado de META");
            }
        }

         public void ConvertirVariables(string database_type, string user, string pass, string server, string protocol, int port, string alias)
        {
            //{ "NombreFruta":"Manzana" , "Cantidad":20 }
            /*           string var = "{database_type: """+database_type+'," +
          "user": "user",
          "pass": "pass",
          "server": "server",
          "protocol": "tcp",
          "port": 4100,
          "alias": "alias"
          };
          */
         Models.addDatabase datos = new Models.addDatabase();
        string json = JsonConvert.SerializeObject(datos);
            

    }

        public string ConvertDataTabletoString()
        {
            DataTable dt = new DataTable();
           // Conexion.Open();
            using (MySqlCommand cmd = new MySqlCommand("select * from BDS;", Conexion))
            {
                
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                JavaScriptSerializer serializer = new JavaScriptSerializer();
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