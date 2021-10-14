using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CRUB
{
    class Periodico
    {
        //propiedades
        public int _periodicoId { get; set; }
        public string _descripcion { get; set; }
        public string _fecha { get; set; }
        public string _nombre { get; set; }
      

       
        private Crud crud = new Crud();

        
        public MySqlDataReader getAllPeriódico()
        {
            string query = "SELECT periodicoID,descripcion,fecha,nombre FROM periódico";

           
            return crud.select(query);
        }

        
    }
}