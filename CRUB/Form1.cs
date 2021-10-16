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
using MetroFramework;

namespace CRUB
{
    public partial class Form1 : Form
    {
        private string action = "new";


        public Form1()
        {
            InitializeComponent();
        }

        private void clearData()
        {
            txtPeriodicoID.Clear();
            txtDescripcion.Clear();
            txtFecha.Clear();
            txtNombre.Clear();

            dtgPeriodico.Columns.Clear();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Debe escribir informacion", "VALIDACION",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();

            }
            else
            {
                Periodico periodico = new Periodico();

                periodico._descripcion = txtDescripcion.Text;
                periodico._fecha = txtFecha.Text;
                periodico._nombre = txtNombre.Text;

                string mensaje = "Esta seguro que desea guardar el registro?";
                if (MetroFramework.MetroMessageBox.Show(this, mensaje, "CONFIRMACION",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (periodico.newEditPeriodico(action))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Los datos se han guardado exitosamente!",
                            "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Los datos  no se han guardado!",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    clearData();
                    fillDataGridView();





                }

            }


        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {



            if (txtPeriodicoID.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Debe escribir el numero del registro que desee eliminar", "VALIDACION",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPeriodicoID.Focus();

            }
            else
            {
                string mensaje = "Esta seguro que desea eliminar el regristro?";
                if (MetroFramework.MetroMessageBox.Show(this, mensaje, "CONFIRMACION",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Periodico periodico = new Periodico();
                    periodico._periodicoId = int.Parse(txtPeriodicoID.Text);

                    //llamado al metodo deleteBook() de la clase Book
                    if (periodico.deletePeriodico())
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Los datos se han eliminado exitosamente!",
                            "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //actualizar datagridview
                        fillDataGridView();

                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Los datos  no se han podido eliminar",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                }


            }
        }
    }
}





    
        


 


 