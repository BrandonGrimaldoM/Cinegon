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
using System.IO;
using System.Drawing.Imaging;

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
            TablaDeDatos.AutoResizeColumns();
            TablaDeDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            con.Close();

        }
        public void datosGenero()
        {
            con.Open();

            OracleCommand sqlSelectGenero = new OracleCommand("select * from genero", con);
          
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = sqlSelectGenero;
            DataTable informacionG = new DataTable();
            adaptador.Fill(informacionG);

            for (int i = 0;i<informacionG.Rows.Count;i++)
            {
                cbxGenero.Items.Add(informacionG.Rows[i][0].ToString());
            }

            con.Close();
        }

        public void datosHorario()
        {
            con.Open();

            OracleCommand sqlSelectHorario = new OracleCommand("select * from horario", con);

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = sqlSelectHorario;
            DataTable informacionH = new DataTable();
            adaptador.Fill(informacionH);

            for (int i = 0; i < informacionH.Rows.Count; i++)
            {
                cbxHorario.Items.Add(informacionH.Rows[i][0].ToString());
            }

            con.Close();
        }

        public void insert() {

            if (txtPelicula.Text != "" &&
                cbxGenero.Text != "" &&
                cbxHorario.Text != "" &&
                txtDuracion.Text != "" &&
                cbxIdioma.Text != "" 
                ){
                
                int duration;
                con.Open();

                


                try
                {
                    duration = (int)long.Parse(txtDuracion.Text);
                }
                catch (Exception e)
                {
                    duration = 0;
                }



                OracleCommand sqlSelectInsert = new OracleCommand("INSERTARINFO", con);
                sqlSelectInsert.CommandType = System.Data.CommandType.StoredProcedure;
                sqlSelectInsert.Parameters.Add("PEL", OracleType.VarChar).Value = txtPelicula.Text;
                sqlSelectInsert.Parameters.Add("GEN", OracleType.VarChar).Value = cbxGenero.Text;
                sqlSelectInsert.Parameters.Add("HOR", OracleType.VarChar).Value = cbxHorario.Text;
                sqlSelectInsert.Parameters.Add("DUR", OracleType.Number).Value = duration;
                sqlSelectInsert.Parameters.Add("IDIO", OracleType.VarChar).Value = cbxIdioma.Text;
                if (cbxPanel.Text == "Sin Panel")
                {
                    sqlSelectInsert.Parameters.Add("PAN", OracleType.VarChar).Value = "";
                }
                else
                {
                    sqlSelectInsert.Parameters.Add("PAN", OracleType.VarChar).Value = cbxPanel.Text;
                }

                try
                {
                    sqlSelectInsert.ExecuteNonQuery();
                    txtPelicula.Text = "";
                    cbxGenero.Text = "";
                    cbxHorario.Text = "";
                    txtDuracion.Text = "";
                    cbxIdioma.Text = "";
                    cbxPanel.Text = "";
                }
                catch (Exception pan)
                {
                    MessageBox.Show("Ya esta asignado "+cbxPanel.Text + " o no seleccionaste panel");
                }


                con.Close();
            }
            else
            {
                MessageBox.Show("Debes llenar todos los campos para insertar Película");
            }
        }

        public void datosIdioma()
        {
            con.Open();

            OracleCommand sqlSelectIdioma = new OracleCommand("select * from idioma", con);

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = sqlSelectIdioma;
            DataTable informacionI = new DataTable();
            adaptador.Fill(informacionI);

            for (int i = 0; i < informacionI.Rows.Count; i++)
            {
                cbxIdioma.Items.Add(informacionI.Rows[i][0].ToString());
            }

            con.Close();
        }

        public void datosPanel()
        {
            con.Open();

            OracleCommand sqlSelectPanel = new OracleCommand("select * from panel", con);

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = sqlSelectPanel;
            DataTable informacionP = new DataTable();
            adaptador.Fill(informacionP);

            for (int i = 0; i < informacionP.Rows.Count; i++)
            {
                cbxPanel.Items.Add(informacionP.Rows[i][0].ToString());
            }

            con.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            datos();
            datosGenero();
            datosHorario();
            datosPanel();
            datosIdioma();
        }

        

        private void TablaDeDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPelicula.Text = TablaDeDatos.CurrentRow.Cells[1].Value.ToString();
            cbxGenero.Text = TablaDeDatos.CurrentRow.Cells[2].Value.ToString();
            cbxHorario.Text = TablaDeDatos.CurrentRow.Cells[3].Value.ToString();
            txtDuracion.Text = TablaDeDatos.CurrentRow.Cells[4].Value.ToString();
            cbxIdioma.Text = TablaDeDatos.CurrentRow.Cells[5].Value.ToString();
            cbxPanel.Text = TablaDeDatos.CurrentRow.Cells[6].Value.ToString();

            con.Open();
            string id = TablaDeDatos.CurrentRow.Cells[0].Value.ToString();

            string view = $"select imagen from pelicula where id_pelicula ='{id}'";

            OracleCommand sqlDir = new OracleCommand(view, con);

            OracleDataReader reader = sqlDir.ExecuteReader();
            try
            {
                reader.Read();
                MemoryStream ms = new MemoryStream((byte[])reader["imagen"]);
                Bitmap bm = new Bitmap(ms);
                ShowImage.Image = bm;
                txtImagen.Text = "Imagen Cargada";
            }
            catch (Exception m)
            {
                ShowImage.Image = null;
                txtImagen.Text = "Sin Imagen";
            }
            con.Close();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.Filter = "Imagenes| *.jpg; *.png;";
            getImage.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            getImage.Title = "Seleccione la imagen a subir";
            
            if (getImage.ShowDialog()==DialogResult.OK)
            {
                string cod = TablaDeDatos.CurrentRow.Cells[0].Value.ToString();
                con.Open();
                
                string creardirectorio = $"CREATE OR REPLACE DIRECTORY DIRECT AS '{getImage.FileName.Replace(getImage.SafeFileName,string.Empty)}'";
                string PLIMAGEN = "DECLARE " +
                    "IMAGENB BLOB; " +
                    "VARBFILE BFILE; " +
                    "NOMBREIMAGEN VARCHAR2(100); " +
                    "BEGIN " +
                    $"update pelicula set imagen = EMPTY_BLOB where id_pelicula = '{cod}'  RETURNING IMAGEN INTO IMAGENB; " +
                    $"nombreimagen := '{getImage.SafeFileName}';  " +
                    " varbfile := BFILENAME('DIRECT',nombreimagen);  " +
                    " DBMS_LOB.OPEN(VARBFILE,DBMS_LOB.LOB_READONLY); " +
                    " DBMS_LOB.LOADFROMFILE(IMAGENB,VARBFILE,DBMS_LOB.getlength(VARBFILE)); " +
                    "DBMS_LOB.CLOSE(VARBFILE); " +
                    "COMMIT; " +
                    "END;";


                

                OracleCommand sqlDir = new OracleCommand(creardirectorio, con);
                
                sqlDir.ExecuteNonQuery();

                OracleCommand sqlImagen = new OracleCommand(PLIMAGEN, con);
                sqlImagen.ExecuteNonQuery();

                ShowImage.Image = Image.FromFile(getImage.FileName);



                con.Close();
                txtImagen.Text = "Imagen Cargada";

                datos();
               

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            insert();
            datos();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (txtPelicula.Text != TablaDeDatos.CurrentRow.Cells[1].Value.ToString() ||
                cbxGenero.Text != TablaDeDatos.CurrentRow.Cells[2].Value.ToString() ||
                cbxHorario.Text != TablaDeDatos.CurrentRow.Cells[3].Value.ToString() ||
                txtDuracion.Text != TablaDeDatos.CurrentRow.Cells[4].Value.ToString() ||
                cbxIdioma.Text != TablaDeDatos.CurrentRow.Cells[5].Value.ToString() ||
                cbxPanel.Text != TablaDeDatos.CurrentRow.Cells[6].Value.ToString() 
                )
            {
                con.Open();
                string idselect = TablaDeDatos.CurrentRow.Cells[0].Value.ToString();
                int min;
                try
                {
                    min = (int)long.Parse(txtDuracion.Text);
                }
                catch (Exception num)
                {
                    min = 0;
                }

                string panelSelect;
                if (cbxPanel.Text == "Sin Panel")
                {
                    panelSelect = "";
                }
                else
                {
                    panelSelect = cbxPanel.Text;
                }

                string actualizar = $"update pelicula set pelicula = '{txtPelicula.Text}' , " +
                                    $"genero = '{cbxGenero.Text}' ," +
                                    $"horario = '{cbxHorario.Text}' , " +
                                    $"duracion = {min} , " +
                                    $"idioma = '{cbxIdioma.Text}' ,  " +
                                    $"panel = '{panelSelect}'"
                                    +$"where id_pelicula = '{idselect}'";

                OracleCommand sqlDir = new OracleCommand(actualizar, con);

                try
                {
                    sqlDir.ExecuteNonQuery();
                    MessageBox.Show("Editado");
                }
                catch (Exception RE)
                {
                    MessageBox.Show("Ya esta asignado el este Panel");
                }
                con.Close();
                datos();
                
            }
            else {
                MessageBox.Show("Debes seleccionar el campo y realizar cambios para usar esta función");
            }
        }

        private void TablaDeDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show($"¿Estas seguro que deseas eliminar la Película {txtPelicula.Text}?","Eliminando Película", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado==DialogResult.Yes)
            {
                con.Open();
                string x = TablaDeDatos.CurrentRow.Cells[0].Value.ToString();
                string eliminando = $"delete from pelicula where id_pelicula = {x}";

                OracleCommand sqlDir = new OracleCommand(eliminando, con);

                sqlDir.ExecuteNonQuery();

                con.Close();
                datos();
                MessageBox.Show("Pelicula eliminada");
            }
            else {
                MessageBox.Show("Cancelado");
            }
        }

        private void cbxPanel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
