using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryArroyoBaseDeDatos
{
    public partial class frmRegistroEntrenador : Form
    {
        //Conexion a base de datos
        public OleDbConnection ConexionBaseDeDatos;
        //Representa una instruccion, que quiero de la base de datos, etc
        public OleDbCommand ComandoBaseDeDatos;

        //Ruta donde esta alojada la base de datos
        public string RutaBaseDatos = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "DEPORTE.accdb";

        public frmRegistroEntrenador()
        {
            InitializeComponent();
        }

        private void cmdRegistroDeportistas_Click(object sender, EventArgs e)
        {
            //Creo Variablaes
            string CodigoEntrenador = txtCodigoEntrenador.Text;
            string NombreEntrenador = txtNombreEntrenador.Text;
            string ApellidoEntrenador = txtApellidoEntrenador.Text;
            string DireccionEntrenador = txtDireccionEntrenador.Text;
            string ProvinciaEntrenador = txtProvincia.Text;
            string DeporteEntrenador = txtDeporte.Text;

            try
            {
                ConexionBaseDeDatos = new OleDbConnection(RutaBaseDatos);
                ConexionBaseDeDatos.Open();
                ComandoBaseDeDatos = new OleDbCommand();

                ComandoBaseDeDatos.Connection = ConexionBaseDeDatos;
                ComandoBaseDeDatos.CommandType = CommandType.Text;
                ComandoBaseDeDatos.CommandText = "INSERT INTO" + " ENTRENADORES ([CODIGO DEPORTISTA], [NOMBRE], [APELLIDO], [DIRECCION], [PROVINCIA], [DEPORTE])" +
                    "VALUES ('" + CodigoEntrenador + "','" + NombreEntrenador + "','" + ApellidoEntrenador + "','" + DireccionEntrenador + "','" + ProvinciaEntrenador + "','"  + DeporteEntrenador + "')";
                ComandoBaseDeDatos.ExecuteNonQuery();
                MessageBox.Show("Datos cargados con exito");
                lblEstado.Text = "Conectado";
                statusStrip1.BackColor = Color.YellowGreen;
            }
            catch (Exception Mensaje)
            {
                lblEstado.Text = Mensaje.Message;
                statusStrip1.BackColor = Color.Red;
                //throw;
            }
            txtCodigoEntrenador.Text = "";
            txtNombreEntrenador.Text = "";
            txtApellidoEntrenador.Text = "";
            txtDireccionEntrenador.Text = "";
            txtProvincia.Text = "";
            txtDeporte.Text = "";
        }

        private void frmRegistroEntrenador_Load(object sender, EventArgs e)
        {
            txtCodigoEntrenador.Focus();
            try
            {
                ConexionBaseDeDatos = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + RutaBaseDatos);
                ConexionBaseDeDatos.Open();
                lblEstado.Text = "Conectado" + ConexionBaseDeDatos.ConnectionString;
                statusStrip1.BackColor = Color.YellowGreen;
            }
            catch (Exception mensaje)
            {
                lblEstado.Text = mensaje.Message;
                statusStrip1.BackColor = Color.Red;
                //throw;
            }
        }

        private void Verificacion()
        {
            if (txtCodigoEntrenador.Text != "" && txtNombreEntrenador.Text != "" && txtApellidoEntrenador.Text != "" && txtDireccionEntrenador.Text != "" && txtProvincia.Text != "" && txtDeporte.Text != "" )
            {
                cmdRegistroEntrenador.Enabled = true;
            }
            else
            {
                cmdRegistroEntrenador.Enabled = false;
            }
        }

        private void txtCodigoEntrenador_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void txtNombreEntrenador_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void txtApellidoEntrenador_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void txtDireccionEntrenador_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void txtProvincia_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void txtDeporte_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
