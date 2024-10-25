using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.CompilerServices; //librerias para trabajar sql


namespace CapaDatos
{
     public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private static Conexion con = null;
        /*private bool Seguridad; //establece metodo de autenticacion de windows
        private static Conexion con = null; //crear objeto de conexion*/

        private Conexion()
        {
            this.Base ="SoftwareCapas";
            this.Servidor = "Yoshi\\SQLEXPRESS";
            this.Usuario = "sa";
            this.Clave = "12345678";



            //this.Seguridad = true;//
        }

        //metodo publico para conexion

        //string cadena = "Data Source=Yoshi\\SQLEXPRESS;Initial Catalog=SoftwareCapas;User ID=sa;Password=12345678";//
        public SqlConnection crearConexion()
        {
            //variable sqlconection
            SqlConnection cadena = new SqlConnection();
            try
            {
                //crear cadena de conexion

                //validar la seguridad utilizada en la conexion
                cadena.ConnectionString = "Server=" +this.Servidor +
                                          "; Database=" + this.Base +
                                          "; user Id=" + this.Usuario +
                                          "; Password=" + this.Clave;
               
            }
            catch (Exception ex) 
            {
                cadena = null;
                throw ex; //muestra mensaje con el error establecido
            }
            return cadena;
        }

        //crear metodo para generar instancia al constructor dentro de esta clase
        public static Conexion crearInstancia()
        {
            if(con == null)
            {
                con = new Conexion();
            }
            return con;
        }

    }

}
