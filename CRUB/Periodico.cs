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

        public Boolean newEditPeriodico(string action)
        {
            if (action == "new")
            {
                string query = "INSERT INTO periódico(descripcion, fecha, nombre)" +
                    "VALUES ('" + _descripcion + "', '" + _fecha + "', '" + _nombre + "')";
                crud.executeQuery(query);
                return true;
            }
            else if (action == "edit")
            {
                string query = "UPDATE periódico SET "
                    + "descripcion='" + _descripcion + "' ,"
                    + "fecha='" + _fecha + "',"
                    + "nombre='" + _nombre + "'"
                    + "WHERE "
                    + "periodicoId='" + _periodicoId + "'";
                crud.executeQuery(query);
                return true;
            }

            return false;
        }

        
        public Boolean deletePeriodico()
        {
            string query = "DELETE FROM periódico WHERE periodicoId='" + _periodicoId + "'";
            crud.executeQuery(query);
            return true;
        }
    }
}