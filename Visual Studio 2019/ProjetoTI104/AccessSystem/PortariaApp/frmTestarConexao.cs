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

namespace PortariaApp
{
    public partial class frmTestarConexao : Form
    {
        public frmTestarConexao()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server=localhost;Port=3306;Database=dbPortaria;Uid=root;Pwd=''";
            try
            {
                conn.Open();
                lblnome.Text = "Banco de dados conectado";
            }catch(MySqlException)
            {
                lblnome.Text = "Erro ao conectar";
            }

        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();

            try
            {
                conn.Close();
                lblnome.Text = "Banco de dados desconectado";
            }
            catch
            {
                lblnome.Text = "Erro ao conectar";
            }
            
        }
    }
}
