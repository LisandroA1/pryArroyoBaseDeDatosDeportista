using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArroyoBaseDeDatos
{
    public partial class frmModificarRegistroEntrenador : Form
    {
        public frmModificarRegistroEntrenador()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string CodigoEntrenadores = txtCodigoEntrenadores.Text;

            try
            {
                clsEntrenadores BuscarD = new clsEntrenadores();
                BuscarD.Buscar(CodigoEntrenadores);
                if (BuscarD.CodigoEntrenadores != CodigoEntrenadores)
                {
                    MessageBox.Show("El cliente no se encuentra registrado");
                    txtCodigoEntrenadores.Text = "";
                }
                else
                {
                    txtNombre.Text = BuscarD.NombreEnt;
                    txtApellido.Text = BuscarD.ApellidoEnt;
                    txtDireccion.Text = BuscarD.DireccionEnt;
                    txtProvincia.Text = BuscarD.ProvinciaEnt;
                    txtDeporte.Text = BuscarD.DeporteEnt;
                }
            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message);
                throw;
            }
           
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            clsEntrenadores Entrenadores = new clsEntrenadores();
            string CodigoEntrenadores = txtCodigoEntrenadores.Text;

            if (Entrenadores.CodigoEntrenadores != CodigoEntrenadores)
            {
                MessageBox.Show("El codigo entrenador no se encuentra registrado");
            }
            else
            {
                Entrenadores.EliminarEntrenador(CodigoEntrenadores);
                txtCodigoEntrenadores.Focus();
                txtCodigoEntrenadores.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDireccion.Text = "";
                txtDeporte.Text = "";
                txtProvincia.Text = "";
                MessageBox.Show("Registro eliminado con exito");
            }
           
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            clsEntrenadores BuscarD = new clsEntrenadores();
            string CodigoEntenador = txtCodigoEntrenadores.Text;
            string Nombre = txtNombre.Text;
            string Apellido = txtApellido.Text;
            string Direccion = txtDireccion.Text;
            string Deporte = txtDeporte.Text;
            string Provincia = txtProvincia.Text;

            if (BuscarD.CodigoEntrenadores != CodigoEntenador)
            {
                MessageBox.Show("El registro no se pudo modificar porque el codigo no coincide");
                txtCodigoEntrenadores.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDireccion.Text = "";
                txtDeporte.Text = "";
                txtProvincia.Text = "";
                txtCodigoEntrenadores.Focus();
            }
            else
            {
                BuscarD.NombreEnt = Nombre;
                BuscarD.ApellidoEnt = Apellido;
                BuscarD.DireccionEnt = Direccion;
                BuscarD.DeporteEnt = Deporte;
                BuscarD.ProvinciaEnt = Provincia;
                BuscarD.ModificarEntrenador(CodigoEntenador);

                txtCodigoEntrenadores.Focus();
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDireccion.Text = "";
                txtDeporte.Text = "";
                txtProvincia.Text = "";
                MessageBox.Show("Registro modificado con exito");
            }

            



            
        }

        private void frmModificarRegistroEntrenador_Load(object sender, EventArgs e)
        {
            txtCodigoEntrenadores.Focus();
        }

        public void Modificacion()
        {
            if (txtApellido.Text != "" && txtCodigoEntrenadores.Text != "" && txtDireccion.Text != "" && txtNombre.Text != "" && txtProvincia.Text != "" && txtDeporte.Text != "")
            {
                cmdModificar.Enabled = true;
            }
            else
            {
                cmdModificar.Enabled = false;
            }
        }

        public void Verificacion()
        {
            if (txtCodigoEntrenadores.Text != "")
            {
                cmdEliminar.Enabled = true;
            }
            else
            {
                cmdEliminar.Enabled = false;
            }
        }

        private void txtCodigoEntrenadores_TextChanged(object sender, EventArgs e)
        {
            Modificacion();
            Verificacion();

            if (txtCodigoEntrenadores.Text != "")
            {
                cmdBuscar.Enabled = true;
            }
            else
            {
                cmdBuscar.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Modificacion();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            Modificacion();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            Modificacion();
        }

        private void txtProvincia_TextChanged(object sender, EventArgs e)
        {
            Modificacion();
        }

        private void txtDeporte_TextChanged(object sender, EventArgs e)
        {
            Modificacion();
        }
    }
}
