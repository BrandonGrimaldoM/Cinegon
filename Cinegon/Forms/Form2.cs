using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
namespace Cinegon
{
    public partial class Form2 : Form
    {
        private OracleConnection con = new OracleConnection("Data source=xepdb1; user id = cine; password = clave;");
        
        public Form2()
        {
            InitializeComponent();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 app = new Form1();
            app.Show();
        }

        public void datos()
        {
            con.Open();
            
            OracleCommand sqlSelect = new OracleCommand("SELECTPELICULAS", con);
            sqlSelect.CommandType = System.Data.CommandType.StoredProcedure;
            sqlSelect.Parameters.Add("TABLA", OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = sqlSelect;
            DataTable informacion = new DataTable();
            adaptador.Fill(informacion);
            TablaDeDatos.DataSource = informacion;
            con.Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            datos();



        }

        

        private void TablaDeDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPelicula.Text = TablaDeDatos.CurrentRow.Cells[0].Value.ToString();
            cbxGenero.Text = TablaDeDatos.CurrentRow.Cells[1].Value.ToString();
            cbxHorario.Text = TablaDeDatos.CurrentRow.Cells[2].Value.ToString();
            txtDuracion.Text = TablaDeDatos.CurrentRow.Cells[3].Value.ToString();
            cbxIdioma.Text = TablaDeDatos.CurrentRow.Cells[4].Value.ToString();
            cbxPanel.Text = TablaDeDatos.CurrentRow.Cells[5].Value.ToString();
            if (TablaDeDatos.CurrentRow.Cells[6].Value.ToString() == "")
            {
                txtImagen.Text = "Sin imagen";
            }
            else
            {
                txtImagen.Text = "Con imagen";
            }
            //txtImagen.Text = TablaDeDatos.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
