using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaEntidad
{
     public class Cliente
    {
        //debemos agrupar las propiedades de acuerdo a cada campo de la tabla
        public int idCliente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set;}
        public int Edad {  get; set; }
        public string Correo {  get; set; }
        public string Telefono {  get; set; }
        public bool Estado { get; set; }

    }
}
