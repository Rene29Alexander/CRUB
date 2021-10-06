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
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string connectionStrin = "";
            MySqlConnection conn;

            try 
            {
                connectionStrin = @"server=localhost;Database=smis060720;Uid=root;
                                       Pwd=usbw;SSL Mode=None";
                conn = new MySqlConnection(connectionStrin);
                conn.Open();
                MetroFramework.MetroMessageBox.Show(this, "se establecio conexion!", "Conexion exitosa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,ex.Message,"Error",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
