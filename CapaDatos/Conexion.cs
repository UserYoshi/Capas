using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //librerias para trabajar sql


namespace CapaDatos
{
     class Conexion
    {
        
        private bool Seguridad; //establece metodo de autenticacion de windows
        private static Conexion con = null; //crear objeto de conexion

        public Conexion()
        {
            
            this.Seguridad = true;
        }

        //metodo publico para conexion

        string cadena = "Data Source=Yoshi\\SQLEXPRESS;Initial Catalog=SoftwareCapas;User ID=sa;Password=12345678";
        public SqlConnection crearConexion()
        {
            //variable sqlconection
            SqlConnection cadena = new SqlConnection();
            try
            {
                //crear cadena de conexion
                
                //validar la seguridad utilizada en la conexion
                if (this.Seguridad)
                {

                    cadena.ConnectionString = cadena.ConnectionString + "Integrated Security = SSPI";

                }
                else
                {
                    cadena.ConnectionString = cadena + "Data Source = Yoshi\\SQLEXPRESS; Initial Catalog = SoftwareCapas; User ID = sa; Password = 12345678";
                    
                }
               
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
