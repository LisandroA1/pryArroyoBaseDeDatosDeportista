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
    public partial class frmConsultaDeportista : Form
    {

        //Declaro variables globales
        public OleDbConnection ConexionBase;
        public OleDbCommand QueQuieroDeLaBase;
        public OleDbDataReader LectorDeConsultas;

        public string varRutaBaseDeDatos = "DEPORTE.accdb";
        public frmConsultaDeportista()
        {
            InitializeComponent();
        }

        private void frmConsultaDeportista_Load(object sender, EventArgs e)
        {
            
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvConsultaDeportista.Rows.Clear();
            try
            {
                ConexionBase = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + varRutaBaseDeDatos);

                ConexionBase.Open();

                QueQuieroDeLaBase = new OleDbCommand();
                QueQuieroDeLaBase.Connection = ConexionBase;
                QueQuieroDeLaBase.CommandType = CommandType.TableDirect;
                QueQuieroDeLaBase.CommandText = "DEPORTISTA";

                LectorDeConsultas = QueQuieroDeLaBase.ExecuteReader();

                

                while (LectorDeConsultas.Read())
                {
                    dgvConsultaDeportista.Rows.Add(LectorDeConsultas["Nombre"], LectorDeConsultas["Apellido"], LectorDeConsultas["Direccion"],
                        LectorDeConsultas["Telefono"], LectorDeConsultas["Edad"], LectorDeConsultas["Deporte"]);
                }
                LectorDeConsultas.Close();
                ConexionBase.Close();
                

            }
            catch (Exception Mensaje)
            {
                MessageBox.Show (Mensaje.Message);
                
            }
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
