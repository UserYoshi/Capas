using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaLogica
{
    public class Logica_Cliente
    {
        //metodo de listar clientes
        public static DataTable Listar()
        {
            //generar una instancia a la clase Datos_cliente
            Datos_cliente datos = new Datos_cliente();
            return datos.Listar();
        }

        //metodo para buscar a los clientes
        public static DataTable Buscar(string valor)
        {
            //generar una instancia a la clase Datos_cliente
            Datos_cliente datos = new Datos_cliente();
            return datos.Buscar(valor);
        }

        //metodo para insertar los clientes
        public static string Insertar(string Nombres, string Apellidos, int Edad, string Correo, string Telefono)
        {
            //1.realizo la referencia hacia la clase Datos_cliente y la clase Cliente
            Datos_cliente datos = new Datos_cliente();
            Cliente obj = new Cliente();
            //2.la informacion de las variables del metodo insertar de la capa de negocios
            //de la clase alumno
            obj.Nombres = Nombres;
            obj.Apellidos = Apellidos;
            obj.Edad = Edad;
            obj.Correo = Correo;
            obj.Telefono = Telefono;
            return datos.Insertar(obj);
        }

        //metodo para actualizar a los alumnos
        public static string Actualizar(int idCliente, string Nombres, string Apellidos, int Edad, string Correo, string Telefono)
        {
            //1.realizo la referencia hacia la clase Datos_alumno
            Datos_cliente datos = new Datos_cliente();
            Cliente obj = new Cliente();
            //2.la informacion de las variables del metodo insertar de la capa de negocios
            //de la clase alumno
            obj.idCliente = idCliente;
            obj.Nombres = Nombres;
            obj.Apellidos = Apellidos;
            obj.Edad = Edad;
            obj.Correo = Correo;
            obj.Telefono = Telefono;
            return datos.Insertar(obj);
        }

        //metodo para eliminar los registros de los clientes

        public static string Eliminar(int idCliente)
        {
            //generamos una instancia a la clase Datos_cliente
            Datos_cliente datos = new Datos_cliente();
            return datos.Eliminar(idCliente);
        }

        //metodo para activar los registros de los clientes
        public static string Activar(int idCliente)
        {
            //generamos una instancia a la clase Datos_cliente
            Datos_cliente datos = new Datos_cliente();
            return datos.Activar(idCliente);
        }

        //metodo para desactivar los registros de los clientes
        public static string Desactivar(int idCliente)
        {
            //generamos una instancia a la clase Datos_cliente
            Datos_cliente datos = new Datos_cliente();
            return datos.Desactivar(idCliente);
        }




    }
}
