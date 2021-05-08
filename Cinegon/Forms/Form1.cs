using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinegon
{
    public partial class Form1 : Form
    {
        private OracleConnection conp = new OracleConnection("Data source=xepdb1; user id = cine; password = clave;");
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            imagenUno();
            imagenDos();
            imagenTres();

            conp.Open();

            OracleCommand sqlSelectinfop = new OracleCommand("select pelicula,idioma,horario,genero,duracion,panel from pelicula", conp);

            OracleDataAdapter adapt = new OracleDataAdapter();
            adapt.SelectCommand = sqlSelectinfop;
            DataTable informacionw = new DataTable();
            adapt.Fill(informacionw);

            for (int i = 0; i < informacionw.Rows.Count; i++)
            {
                
                if ("Panel uno" == informacionw.Rows[i][5].ToString())
                {
                    txtPelicula.Text = informacionw.Rows[i][0].ToString();
                    txtIdioma.Text = informacionw.Rows[i][1].ToString();
                    txtHorario.Text = informacionw.Rows[i][2].ToString();
                    txtGenero.Text = informacionw.Rows[i][3].ToString();
                    txtDuracion.Text = informacionw.Rows[i][4].ToString();

                    txtCampoIdioma.Text = "Idioma:";
                    txtCampoHorario.Text = "Horario:";
                    txtCampoGenero.Text = "Genero:";
                    txtCampoDuracion.Text = "Duracion:";

                    
                }else if ("Panel dos" == informacionw.Rows[i][5].ToString())
                {
                    txtPelicula2.Text = informacionw.Rows[i][0].ToString();
                    txtIdioma2.Text = informacionw.Rows[i][1].ToString();
                    txtHorario2.Text = informacionw.Rows[i][2].ToString();
                    txtGenero2.Text = informacionw.Rows[i][3].ToString();
                    txtDuracion2.Text = informacionw.Rows[i][4].ToString();

                    txtCampoIdioma2.Text = "Idioma:";
                    txtCampoHorario2.Text = "Horario:";
                    txtCampoGenero2.Text = "Genero:";
                    txtCampoDuracion2.Text = "Duracion:";

                }
                else if ("Panel tres" == informacionw.Rows[i][5].ToString())
                {
                    txtPelicula3.Text = informacionw.Rows[i][0].ToString();
                    txtIdioma3.Text = informacionw.Rows[i][1].ToString();
                    txtHorario3.Text = informacionw.Rows[i][2].ToString();
                    txtGenero3.Text = informacionw.Rows[i][3].ToString();
                    txtDuracion3.Text = informacionw.Rows[i][4].ToString();

                    txtCampoIdioma3.Text = "Idioma:";
                    txtCampoHorario3.Text = "Horario:";
                    txtCampoGenero3.Text = "Genero:";
                    txtCampoDuracion3.Text = "Duracion:";
                }
            }

            


            conp.Close();
        }


        public void imagenUno()
        {
            conp.Open();


            string viewp1 = "select imagen  from pelicula where panel='Panel uno'";

            OracleCommand sqlPanelview1 = new OracleCommand(viewp1, conp);

            OracleDataReader reader1 = sqlPanelview1.ExecuteReader();

            try
            {
                reader1.Read();
                MemoryStream ms = new MemoryStream((byte[])reader1["imagen"]);
                Bitmap bm = new Bitmap(ms);
                panelBox1.Image = bm;

            }
            catch (Exception m)
            {
                panelBox1.Image = null;

            }
            conp.Close();

        }

        public void imagenDos()
        {
            conp.Open();
            string viewp2 = "select imagen  from pelicula where panel='Panel dos'";

            OracleCommand sqlPanelview2 = new OracleCommand(viewp2, conp);

            OracleDataReader reader2 = sqlPanelview2.ExecuteReader();

            try
            {
                reader2.Read();
                MemoryStream ms2 = new MemoryStream((byte[])reader2["imagen"]);
                Bitmap bm2 = new Bitmap(ms2);
                panelBox2.Image = bm2;

            }
            catch (Exception m)
            {
                panelBox2.Image = null;

            }
            conp.Close();
        }

        public void imagenTres()
        {
            conp.Open();

            string viewp3 = "select imagen  from pelicula where panel='Panel tres'";

            OracleCommand sqlPanelview3 = new OracleCommand(viewp3, conp);

            OracleDataReader reader3 = sqlPanelview3.ExecuteReader();

            try
            {
                reader3.Read();
                MemoryStream ms3 = new MemoryStream((byte[])reader3["imagen"]);
                Bitmap bm3 = new Bitmap(ms3);
                panelBox3.Image = bm3;

            }
            catch (Exception m)
            {
                panelBox3.Image = null;

            }

            conp.Close();

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtDuracion3_Click(object sender, EventArgs e)
        {

        }
    }
}
