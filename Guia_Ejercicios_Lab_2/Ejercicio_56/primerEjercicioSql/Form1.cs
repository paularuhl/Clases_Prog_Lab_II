using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace primerEjercicioSql
{
    public partial class Form1 : Form
    {
        SqlConnection miConexion;

        SqlDataReader objetoQueRecibeLaInfo;

        DataTable miTablita;

        public Form1()
        {
            miConexion = new SqlConnection("Data Source = .; Database = utnFra; Trusted_Connection=True;");

            miTablita = new DataTable();
            //miConexion = new SqlConnection("Data Source = .\\");

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

                dataGridView1.ReadOnly = true;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AllowUserToAddRows = false;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand miComando = new SqlCommand();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            miTablita.Rows.Clear();

            miComando.Connection = miConexion;
            miComando.CommandType = CommandType.Text;
            miComando.CommandText = "select * from Alumnos where curso = @cursoAFiltrar";

            miComando.Parameters.Clear();

            //miConexion.Open();
            miComando.Parameters.Add(new SqlParameter("cursoAFiltrar", int.Parse(tbCurso.Text)));
            try
            {
                miConexion.Open();

                objetoQueRecibeLaInfo = miComando.ExecuteReader();

                miTablita.Load(objetoQueRecibeLaInfo);
                //while (objetoQueRecibeLaInfo.Read())
                //{
                //    auxNombre = objetoQueRecibeLaInfo["nombre"].ToString();
                //    auxApellido = objetoQueRecibeLaInfo["apellido"].ToString();

                //}
                dataGridView1.DataSource = miTablita;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Rompimos todo");
            }
            finally
            {
                miConexion.Close();
            }
        }

        private void insertarDatos_Click(object sender, EventArgs e)
        {
            SqlCommand miComando = new SqlCommand();
            miComando.Connection = miConexion;
            miComando.CommandType = CommandType.Text;
            miComando.CommandText = "insert into Alumnos values (@legajo,@nombre,@apellido,@cursoAFiltrar)";

            miComando.Parameters.Clear();

            //miConexion.Open();
            miComando.Parameters.Add(new SqlParameter("legajo", int.Parse(tbCurso.Text)));
            miComando.Parameters.Add(new SqlParameter("nombre", "rauli"));
            miComando.Parameters.Add(new SqlParameter("apellido", "to"));
            miComando.Parameters.Add(new SqlParameter("cursoAFiltrar", int.Parse(tbCurso.Text)));
            try
            {
                miConexion.Open();

                int cantidadInsertados = miComando.ExecuteNonQuery();
                MessageBox.Show("Cantidad de lineas insertadas: " + cantidadInsertados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rompimos todo");
            }
            finally
            {
                miConexion.Close();
            }
        }
    }
}
