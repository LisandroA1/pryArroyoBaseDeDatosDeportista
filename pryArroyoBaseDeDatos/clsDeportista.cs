using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryArroyoBaseDeDatos
{
    internal class clsDeportista
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
        private string Tabla = "Deportista";

        private string Cod_deportista;
        private string Nombre;
        private string Apellido;
        private string Direccion;
        private Int32 Telefono;
        private int Edad;
        private string Deporte;


        public string CodigoDeport
        {
            get { return Cod_deportista; }
            set { Cod_deportista = value; }
        }

        public string NombreDeportista
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public string ApellidoDeportista
        {
            get { return Apellido; }
            set { Apellido = value; }
        }

        public string DireccionDeportista
        {
            get { return Direccion; }
            set { Direccion = value; }
            
        }

        public Int32 TelefonoDeportista
        {
            get { return Telefono; }
            set { Telefono = value; }
        }
        
        public Int32 EdadDeportista
        {
            get { return Edad; }
            set { Edad = value; }
        }

        public string DeporteDeportista
        {
            get { return Deporte; }
            set { Deporte = value; }
        }
        
        //Creo los procedimiento a utilizar en los respectivos botones de comando

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
                            Cod_deportista = Lector.GetString(0);
                            Nombre = Lector.GetString(1);
                            Apellido = Lector.GetString(2);
                            Direccion = Lector.GetString(3);
                            Telefono = Convert.ToInt32(Lector.GetString(4));
                            Edad = Int32.Parse(Lector.GetString(5));
                            Deporte = Lector.GetString(6);

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

        public void ModificarDeportista(string CodigoDeportista)
        {
            
            
            try
            {
                //sentencia sql para modificar

                string MDeport = "UPDATE DEPORTISTA SET NOMBRE= '" + NombreDeportista + "', APELLIDO='" + ApellidoDeportista + "', DIRECCION='" + DireccionDeportista + "', TELEFONO=" + TelefonoDeportista + ", EDAD=" + EdadDeportista + ", DEPORTE='" + DeporteDeportista + "' WHERE [CODIGO DEPORTISTA] = '" + CodigoDeportista + "'";    


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

        public void EliminarDeportista(string CodigoDeportista)
        {
            try
            {
                string MDeport = "DELETE FROM DEPORTISTA " + "WHERE('" + CodigoDeportista + "'=[CODIGO DEPORTISTA])";

                ConexionBaseDeDatos.ConnectionString = CadenaConexion;
                ConexionBaseDeDatos.Open();
                Comando.Connection = ConexionBaseDeDatos;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = MDeport;
                Comando.ExecuteNonQuery();
                ConexionBaseDeDatos.Close();

                MessageBox.Show("Cliente eliminado con éxito");
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show("El cliente no se pudo eliminar" + Mensaje.Message);
                //throw;
            }


        }


    }
}
