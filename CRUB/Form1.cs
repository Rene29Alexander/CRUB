using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUB
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            
            fillDataGridView();




        }

        public void fillDataGridView()
        {
            Periodico periodico = new Periodico();

            clearDataGridView();

            dtgPeriodico.Columns.Add("periodicoId", "PERIODICO ID");
            dtgPeriodico.Columns.Add("decripcion", "DESCRIPCION");
            dtgPeriodico.Columns.Add("fecha", "FECHA");
            dtgPeriodico.Columns.Add("nombre", "NOMBRE");


            
            MySqlDataReader dataReader = periodico.getAllPeriódico();

            while (dataReader.Read())
            {
                dtgPeriodico.Rows.Add(
                        dataReader.GetValue(0),
                        dataReader.GetValue(1),
                        dataReader.GetValue(2),
                        dataReader.GetValue(3)
                       );


            }
        }

        public void clearDataGridView()
        {
            dtgPeriodico.Columns.Clear();
            dtgPeriodico.Rows.Clear();
        }






    }

}

    
        


 


 