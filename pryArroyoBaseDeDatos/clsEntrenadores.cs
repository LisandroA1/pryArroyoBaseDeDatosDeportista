using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace pryArroyoBaseDeDatos
{
    internal class clsEntrenadores
    {
        //Nos permite conectarnos con la base de datos 
        private OleDbConnection ConexionBaseDeDatos = new OleDbConnection();
        //Nos permite enviar una orden a la base de datos 
        private OleDbCommand Comando = new OleDbCommand();
        //nos sirve para adaptar los datos que estan en la base de datos a datos reconocidos por .NET
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter();

        //Ruta de base de datos
        private string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DEPORTE.accdb";
        //Tabla a utilizar de base de datos
        private string Tabla = "ENTRENADORES";

        string Cod_Entrenadores;
        string NombreEntrenador;
        string ApellidoEntrenador;
        string DireccionEntrenador;
        string ProvinciaEntrenador;
        string DeporteEntrenador;

        public string CodigoEntrenadores
        {
            get { return Cod_Entrenadores; }
            set { Cod_Entrenadores = value; }
        }
        public string NombreEnt
        {
            get { return NombreEntrenador; }
            set { NombreEntrenador = value; }
        }
        public string ApellidoEnt
        {
            get { return ApellidoEntrenador; }
            set { ApellidoEntrenador = value; }
        }
        public string DireccionEnt
        {
            get { return DireccionEntrenador; }
            set { DireccionEntrenador = value; }
        }
        public string ProvinciaEnt
        {
            get { return ProvinciaEntrenador; }
            set { ProvinciaEntrenador = value; }
        }
        public string DeporteEnt
        {
            get { return DeporteEntrenador; }
            set { DeporteEntrenador = value; }
        }

        public void Buscar(string Codigo)
        {
            try
            {
                ConexionBaseDeDatos.ConnectionString = CadenaConexion;
                ConexionBaseDeDatos.Open();
                Comando.Connection = ConexionBaseDeDatos;
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = Tabla;

                OleDbDataReader Lector = Comando.ExecuteReader();
                //si tiene filas
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetString(0) == Codigo)
                        {
                            Cod_Entrenadores = Lector.GetString(0);
                            NombreEntrenador = Lector.GetString(1);
                            ApellidoEntrenador = Lector.GetString(2);
                            DireccionEntrenador = Lector.GetString(3);
                            ProvinciaEntrenador = Lector.GetString(4);
                            DeporteEntrenador = Lector.GetString(5);
                        }
                    }
                }

                ConexionBaseDeDatos.Close();

            }
            catch (Exception MensajeAviso)
            {
                MessageBox.Show(MensajeAviso.Message);
                //throw;
            }

        }
        public void EliminarEntrenador(string CodigoEntrenadores)
        {
            try
            {
                string MDeport = "DELETE FROM ENTRENADORES " + "WHERE('" + CodigoEntrenadores + "'=[CODIGO DEPORTISTA])";

                ConexionBaseDeDatos.ConnectionString = CadenaConexion;
                ConexionBaseDeDatos.Open();
                Comando.Connection = ConexionBaseDeDatos;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = MDeport;
                Comando.ExecuteNonQuery();
                ConexionBaseDeDatos.Close();

                MessageBox.Show("Entrenador eliminado con éxito");
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show("El entrenador no se pudo eliminar" + Mensaje.Message);
                //throw;
            }
           

        }

        public void ModificarEntrenador(string CodigoEntrenadores)
        {
            try
            {
                //sentencia sql para modificar

                string MDeport = "UPDATE ENTRENADORES SET NOMBRE = '" + NombreEnt + "', APELLIDO='" + ApellidoEnt + "', DIRECCION='" + DireccionEnt + "', PROVINCIA='" + ProvinciaEnt + "', DEPORTE='" + DeporteEnt + "'WHERE [CODIGO DEPORTISTA] = '" + CodigoEntrenadores + "'";


                ConexionBaseDeDatos.ConnectionString = CadenaConexion;
                ConexionBaseDeDatos.Open();
                Comando.Connection = ConexionBaseDeDatos;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = MDeport;
                Comando.ExecuteNonQuery();
                ConexionBaseDeDatos.Close();

                MessageBox.Show("Cliente modificado con exito");





            }
            catch (Exception Mensaje)
            {

                MessageBox.Show("El cliente no se pudo modificar" + Mensaje.Message);
                //throw;
            }
        }

    }
}