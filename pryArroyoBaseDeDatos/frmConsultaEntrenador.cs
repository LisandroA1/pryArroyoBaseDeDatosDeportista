using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArroyoBaseDeDatos
{
    public partial class frmConsultaEntrenador : Form
    {

        //Declaro variables globales
        public OleDbConnection ConexionBase;
        public OleDbCommand QueQuieroDeLaBase;
        public OleDbDataReader LectorDeConsultas;

        public string varRutaBaseDeDatos = "DEPORTE.accdb";
        public frmConsultaEntrenador()
        {
            InitializeComponent();
        }

        private void frmConsultaEntrenador_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {dgvConsultaEntrenador.Rows.Clear();
            try
            {
                ConexionBase = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + varRutaBaseDeDatos);

                ConexionBase.Open();

                QueQuieroDeLaBase = new OleDbCommand();
                QueQuieroDeLaBase.Connection = ConexionBase;
                QueQuieroDeLaBase.CommandType = CommandType.TableDirect;
                QueQuieroDeLaBase.CommandText = "ENTRENADORES";

                LectorDeConsultas = QueQuieroDeLaBase.ExecuteReader();

                

                while (LectorDeConsultas.Read())
                {
                    dgvConsultaEntrenador.Rows.Add(LectorDeConsultas["Nombre"], LectorDeConsultas["Apellido"], LectorDeConsultas["Direccion"],
                        LectorDeConsultas["Provincia"], LectorDeConsultas["Deporte"]);
                }
                LectorDeConsultas.Close();
                ConexionBase.Close();
                

            }
            catch (Exception Mensaje)
            {
                MessageBox.Show( Mensaje.Message);
                
            }
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
