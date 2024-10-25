using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data; //permite utilizar el metodo DataTable
using System.Data.SqlClient; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class Datos_cliente
    {
        //metodo para listar los elementos de la tabla clientes
        public DataTable Listar()
        {
            SqlDataReader resultado;//permite leer una secuencia de filas en una tabla sql
            DataTable Tabla = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();


                conexion.Open();
                Console.WriteLine("Conexión exitosa");

                SqlCommand comando = new SqlCommand("listar_cliente", conexion);

                comando.CommandType = CommandType.StoredProcedure;
                
                


                resultado = comando.ExecuteReader();

                Tabla.Load(resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close(); //cerramos la conexion
                }
            }
        }

        //metodo para buscar

        public DataTable Buscar(string valor) 
        {
            SqlDataReader resultado;//permite leer una secuencia de filas en una tabla sql
            DataTable Tabla = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("buscar_cliente", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@valor",SqlDbType.VarChar).Value = valor;
                conexion.Open();
                resultado = comando.ExecuteReader();
                Tabla.Load(resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close(); //cerramos la conexion

            }
        }

        //metodo para insertar datos del cliente
        public string Insertar(Cliente obj)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("insertar_cliente", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Nombres", SqlDbType.VarChar).Value = obj.Nombres;
                comando.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = obj.Apellidos;
                comando.Parameters.Add("@Edad", SqlDbType.VarChar).Value = obj.Edad;
                comando.Parameters.Add("@Correo", SqlDbType.VarChar).Value = obj.Correo;
                comando.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = obj.Telefono;
                conexion.Open();

                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close(); //cerramos la conexion

            }
            return respuesta;
        }

        public string Actualizar(Cliente obj)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("actualizar_cliente", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idCliente", SqlDbType.VarChar).Value = obj.idCliente;
                comando.Parameters.Add("@Nombres", SqlDbType.VarChar).Value = obj.Nombres;
                comando.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = obj.Apellidos;
                comando.Parameters.Add("@Edad", SqlDbType.VarChar).Value = obj.Edad;
                comando.Parameters.Add("@Correo", SqlDbType.VarChar).Value = obj.Correo;
                comando.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = obj.Telefono;
                conexion.Open();

                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close(); //cerramos la conexion

            }
            return respuesta;
        }

        //metodo para eliminar datos del cliente

        public string Eliminar(int idCliente)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("eliminar_cliente", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idCliente", SqlDbType.VarChar).Value = idCliente;
                
                conexion.Open();

                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close(); //cerramos la conexion

            }
            return respuesta;
        }

        //metodo para activar el registro del cliente

        public string Activar(int idCliente)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("activar_cliente", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idCliente", SqlDbType.VarChar).Value = idCliente;

                conexion.Open();

                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo activar el registro";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close(); //cerramos la conexion

            }
            return respuesta;
        }

        //metodo para desactivar el registro de usuario

        public string Desactivar(int idCliente)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("desactivar_cliente", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idCliente", SqlDbType.VarChar).Value = idCliente;

                conexion.Open();

                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo desactivar el registro";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close(); //cerramos la conexion

            }
            return respuesta;
        }


    }
}
