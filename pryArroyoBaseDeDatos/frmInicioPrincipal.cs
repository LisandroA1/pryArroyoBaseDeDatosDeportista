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
    public partial class frmInicioPrincipal : Form
    {

        //Declaro variables globales
        public OleDbConnection ConexionBase;
        public OleDbCommand QueQuieroDeLaBase;
        public OleDbDataReader LectorDeConsultas;

        public string varRutaBaseDeDatos = "DEPORTE.accdb";
        public frmInicioPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void deportistaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaDeportista ConsultaDeportista = new frmConsultaDeportista();
            ConsultaDeportista.ShowDialog();

        }

        private void entrenadorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaEntrenador ConsultaEntrenador = new frmConsultaEntrenador();
            ConsultaEntrenador.ShowDialog();
        }

        private void deportistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroDeportista newObject = new frmRegistroDeportista();
            newObject.ShowDialog();
        }

        private void entrenadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroEntrenador newObject = new frmRegistroEntrenador();
            newObject.ShowDialog();
        }

        private void frmInicioPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                lblFechaActual.Text = DateTime.Now.ToString();

                ConexionBase = new OleDbConnection  ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + varRutaBaseDeDatos);
                ConexionBase.Open();

                lblEstado.Text = "Conectado" + ConexionBase.ConnectionString;
                statusStrip1.BackColor = Color.GreenYellow;
            }
            catch (Exception Mensaje)
            {
                lblEstado.Text = Mensaje.Message;
                statusStrip1.BackColor = Color.Red;
                //throw;
            }
        }

        private void deportistaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmModificarRegistroDeportista RegistroDeportista = new frmModificarRegistroDeportista();
            RegistroDeportista.ShowDialog();
        }

        private void entrenadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarRegistroEntrenador RegistroEntrenador = new frmModificarRegistroEntrenador();
            RegistroEntrenador.ShowDialog();
        }
    }
}
