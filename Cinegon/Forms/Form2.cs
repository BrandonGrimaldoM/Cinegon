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
            con.Open();
            int duration;
            try
            {
                duration = (int)long.Parse(txtDuracion.Text);
            }
            catch(Exception e)
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
            sqlSelectInsert.Parameters.Add("PAN", OracleType.VarChar).Value = cbxPanel.Text;
            
            sqlSelectInsert.ExecuteNonQuery();

             txtPelicula.Text = "";
             cbxGenero.Text = "";
             cbxHorario.Text = "";
             txtDuracion.Text = "";
             cbxIdioma.Text ="";
             cbxPanel.Text = "";
             
            

            con.Close();
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
                MessageBox.Show(getImage.FileName.Replace(getImage.SafeFileName, string.Empty));
                MessageBox.Show(getImage.SafeFileName);
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
                txtImagen.Text = "Imagen subida";

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
            }
            catch(Exception m)
            {
                MessageBox.Show("no se a agregado imagen a esta pelicula");
                ShowImage.Image = null;
            }

            

            



            con.Close();
        }
    }
}
