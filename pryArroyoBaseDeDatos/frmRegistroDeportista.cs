using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryArroyoBaseDeDatos
{
    
    public partial class frmRegistroDeportista : Form
    {
        //Conexion a base de datos
        public OleDbConnection ConexionBaseDatos;
        //Representa una instruccion, que quiero de la base de datos, etc
        public OleDbCommand ComandoBaseDatos;

        //Ruta donde esta alojada la base de datos
        public string RutaBaseDatos = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "DEPORTE.accdb";

        public frmRegistroDeportista()
        {
            InitializeComponent();
        }

        private void cmdRegistroDeportistas_Click(object sender, EventArgs e)
        {
            //Creo variables
            string CodigoDeportista = txtCodigoDeportista.Text;
            string NombreDeportista = txtNombreDeportista.Text;
            string ApellidoDeportista = txtApellidoDeportista.Text;
            string DireccionDeportista = txtDireccionDeportista.Text;
            Int32 TelefonoDeportista = Convert.ToInt32(mskTelfonoDeportista.Text);
            Int32 EdadDeportista = Convert.ToInt32(txtEdad.Text);
            string DeporteDeportista = txtDeporte.Text;

            try
            {
                ConexionBaseDatos = new OleDbConnection(RutaBaseDatos);
                ConexionBaseDatos.Open();
                ComandoBaseDatos = new OleDbCommand();


                ComandoBaseDatos.Connection = ConexionBaseDatos; //Conecto a la base de datos
                ComandoBaseDatos.CommandType = CommandType.Text;
                ComandoBaseDatos.CommandText = "INSERT INTO" + " DEPORTISTA ([CODIGO DEPORTISTA], [NOMBRE], [APELLIDO], [DIRECCION], [TELEFONO], [EDAD], [DEPORTE])" +
                    "VALUES ('" + CodigoDeportista + "','" + NombreDeportista + "','" + ApellidoDeportista + "','" + DireccionDeportista + "','" + TelefonoDeportista + "','" + EdadDeportista + "','" + DeporteDeportista + "')";

                ComandoBaseDatos.ExecuteNonQuery();//numeros de filas afectadas
                MessageBox.Show("Datos cargados con exito");
                lblEstadoRegistroDeportista.Text = "Conectado";
                statusStrip1.BackColor = Color.GreenYellow;

            }
            catch (Exception Message)
            {
                MessageBox.Show("Los datos no se cargaron");
                statusStrip1.BackColor = Color.Red;
                lblEstadoRegistroDeportista.Text = Message.Message;
                //throw;
            }
            txtCodigoDeportista.Text = "";
            txtNombreDeportista.Text = "";
            txtApellidoDeportista.Text = "";
            txtDireccionDeportista.Text = "";
            mskTelfonoDeportista.Text = "";
            txtEdad.Text = "";
            txtDeporte.Text = "";

            txtCodigoDeportista.Focus();


        }

        private void frmRegistroDeportista_Load(object sender, EventArgs e)
        {
            
            try
            {
                ConexionBaseDatos = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + RutaBaseDatos);
                ConexionBaseDatos.Open();
                lblEstadoRegistroDeportista.Text = "Conectado" + ConexionBaseDatos.ConnectionString;
                statusStrip1.BackColor = Color.YellowGreen;
            }
            catch (Exception mensaje)
            {
                lblEstadoRegistroDeportista.Text = mensaje.Message;
                statusStrip1.BackColor = Color.Red;
                //throw;
            }
            txtCodigoDeportista.Focus();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Verificacion()
        {
            if (txtApellidoDeportista.Text != "" && txtCodigoDeportista.Text != "" && txtDireccionDeportista.Text != "" && txtNombreDeportista.Text != "" && txtEdad.Text != "" && txtDeporte.Text != "" && mskTelfonoDeportista.Text != "")
            {
                cmdRegistroDeportistas.Enabled = true;
            }
            else
            {
                cmdRegistroDeportistas.Enabled = false;
            }
        }

        private void txtCodigoDeportista_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void txtNombreDeportista_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void txtApellidoDeportista_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void txtDireccionDeportista_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void mskTelfonoDeportista_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Verificacion();
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
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
