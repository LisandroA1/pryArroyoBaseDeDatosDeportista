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
    public partial class frmModificarRegistroDeportista : Form
    {
        public frmModificarRegistroDeportista()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string CodigoDeportista = txtCodigoDeportista.Text;
            clsDeportista BuscarD = new clsDeportista();
            BuscarD.Buscar(CodigoDeportista);
            if (BuscarD.CodigoDeport != CodigoDeportista)
            {
                MessageBox.Show("El cliente no se encuentra registrado");
                txtCodigoDeportista.Text = "";
            }
            else
            {
                txtNombre.Text = BuscarD.NombreDeportista;
                txtApellido.Text = BuscarD.ApellidoDeportista;
                txtDireccion.Text = BuscarD.DireccionDeportista;
                txtTelefono.Text = Convert.ToString(BuscarD.TelefonoDeportista);
                txtEdad.Text = Convert.ToString(BuscarD.EdadDeportista);
                txtDeporte.Text = BuscarD.DeporteDeportista;
            }
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            clsDeportista BuscarD = new clsDeportista();
            string CodigoDeportista = txtCodigoDeportista.Text;
            string Nombre = txtNombre.Text;
            string Apellido = txtApellido.Text;
            string Direccion = txtDireccion.Text;
            Int32 Telefono = Convert.ToInt32(txtTelefono.Text);
            Int32 Edad = Convert.ToInt32(txtEdad.Text);
            string Deporte = txtDeporte.Text;

            if (BuscarD.CodigoDeport != CodigoDeportista)
            {
                BuscarD.NombreDeportista = Nombre;
                BuscarD.ApellidoDeportista = Apellido;
                BuscarD.DireccionDeportista = Direccion;
                BuscarD.TelefonoDeportista = Convert.ToInt32(Telefono);
                BuscarD.EdadDeportista = Convert.ToInt32(Edad);
                BuscarD.DeporteDeportista = Deporte;
                BuscarD.ModificarDeportista(CodigoDeportista);

                txtCodigoDeportista.Focus();
                txtCodigoDeportista.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDireccion.Text = "";
                txtTelefono.Text = "";
                txtEdad.Text = "";
                txtDeporte.Text = "";
                MessageBox.Show("Registro modificado con exito");
            }
            else
            {
                MessageBox.Show("El registro no se pudo modificar porque el codigo no coincide");
                txtCodigoDeportista.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDireccion.Text = "";
                txtTelefono.Text = "";
                txtEdad.Text = "";
                txtDeporte.Text = "";
                txtCodigoDeportista.Focus();
            }

            




        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            clsDeportista Deportistas = new clsDeportista();
            string CodigoDeportista = txtCodigoDeportista.Text;

            if (Deportistas.CodigoDeport != txtCodigoDeportista.Text)
            {
                MessageBox.Show("El codigo deportista no se encuentra registrado");
                txtCodigoDeportista.Text = "";
            }
            else
            {
                Deportistas.EliminarDeportista(CodigoDeportista);
                txtCodigoDeportista.Focus();
                txtCodigoDeportista.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDireccion.Text = "";
                txtTelefono.Text = "";
                txtEdad.Text = "";
                txtDeporte.Text = "";

                MessageBox.Show("Registro eliminado con exito");
            }
            
        }

        private void txtCodigoDeportista_TextChanged(object sender, EventArgs e)
        {
            Modificacion();
            Verificacion();
            if (txtCodigoDeportista.Text != "")
            {
                cmdBuscar.Enabled = true;
            }
            else
            {
                cmdBuscar.Enabled = false;
            }
        }

        private void frmModificarRegistroDeportista_Load(object sender, EventArgs e)
        {
            txtCodigoDeportista.Focus();
        }

        

        public void Verificacion()
        {
            if (txtCodigoDeportista.Text != "")
            {
                cmdEliminar.Enabled = true;
            }
            else
            {
                cmdEliminar.Enabled = false;
            }
        }

        public void Modificacion()
        {
            if (txtApellido.Text != "" && txtCodigoDeportista.Text != "" && txtDireccion.Text != "" && txtNombre.Text != "" && txtEdad.Text != "" && txtDeporte.Text != "" && txtTelefono.Text != "")
            {
                cmdModificar.Enabled = true;
            }
            else
            {
                cmdModificar.Enabled = false;
            }
        }

        private void txtDeporte_TextChanged(object sender, EventArgs e)
        {
            Modificacion();
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

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            Modificacion();
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            Modificacion();
        }
    }
}
