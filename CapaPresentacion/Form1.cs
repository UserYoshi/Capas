using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //metodo para llenar el datagrid
        private void listar()
        {
            try
            {
                dgvDatos.DataSource = Logica_Cliente.Listar();
                this.formato();
                lbTotal.Text = "Total registros: " + Convert.ToString(dgvDatos.Rows.Count);
                this.Limpiar();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //metodo para darle formato al datagrid
        private void formato()
        {
            dgvDatos.Columns[0].Visible = false;
            dgvDatos.Columns[1].Visible = false;//idCliente
            dgvDatos.Columns[2].Width = 100;
            dgvDatos.Columns[3].Width = 100;
            dgvDatos.Columns[4].Width = 50;
            dgvDatos.Columns[5].Width = 200;
            dgvDatos.Columns[6].Width = 80;
            dgvDatos.Columns[7].Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.listar();
        }

        //metodo para buscar los registros
        private void Buscar()
        {
            try
            {
                dgvDatos.DataSource = Logica_Cliente.Buscar(txtBuscar.Text);
                this.formato();
                lbTotal.Text = "Total registros: " + Convert.ToString(dgvDatos.Rows.Count);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        //metodo para limpiar los campos
        private void Limpiar()
        {
            txtidCliente.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtEdad.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            btnInsertar.Visible = true;
            error.Clear();
            btnActualizar.Visible = false;

            dgvDatos.Columns[0].Visible = false;
            btnActivar.Visible = false;
            btnDesactivar.Visible = false;
            btnEliminar.Visible = false;
            chkSeleccionar.Checked = false;

        }
        //metodo para el control de los mensajes de errores
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Control de clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Control de clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                //validaciones 
                if(txtNombres.Text == string.Empty){
                    this.MensajeError("Campos Incompletos, estos seran marcados");
                    error.SetError(txtNombres, "Ingrese sus nombres");
                    return;
                }
                if(txtApellidos.Text == string.Empty){
                    this.MensajeError("Campos Incompletos, estos seran marcados");
                    error.SetError(txtApellidos, "Ingrese sus apellidos");
                    return;
                }
                if (txtEdad.Text == string.Empty)
                {
                    this.MensajeError("Campos Incompletos, estos seran marcados");
                    error.SetError(txtEdad, "Ingrese su edad");
                    return;
                }
                if (txtCorreo.Text == string.Empty)
                {
                    this.MensajeError("Campos Incompletos, estos seran marcados");
                    error.SetError(txtCorreo, "Ingrese su correo");
                    return;
                }
                if (txtTelefono.Text == string.Empty)
                {
                    this.MensajeError("Campos Incompletos, estos seran marcados");
                    error.SetError(txtTelefono, "Ingrese su telefono");
                    return;
                }

                //envio de informacion a la capa logica
                respuesta = Logica_Cliente.Insertar(txtNombres.Text,txtApellidos.Text,
                                            Convert.ToInt32 (txtEdad.Text),txtCorreo.Text,
                                            txtTelefono.Text);
                if (respuesta.Equals("OK"))
                {
                    this.MensajeOk("Se inserto el registro");
                    this.Limpiar();
                    this.listar();
                }
                else
                {
                    this.MensajeError (respuesta);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            tabG.SelectedIndex = 0;
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                this.Limpiar();
                btnActualizar.Visible = true;
                btnInsertar.Visible = false;
                txtidCliente.Text = Convert.ToString(dgvDatos.CurrentRow.Cells["idCliente"].Value);
                txtNombres.Text = Convert.ToString(dgvDatos.CurrentRow.Cells["Nombres"].Value);
                txtApellidos.Text = Convert.ToString(dgvDatos.CurrentRow.Cells["Apellidos"].Value);
                txtEdad.Text = Convert.ToString(dgvDatos.CurrentRow.Cells["Edad"].Value);
                txtCorreo.Text = Convert.ToString(dgvDatos.CurrentRow.Cells["Correo"].Value);
                txtTelefono.Text = Convert.ToString(dgvDatos.CurrentRow.Cells["Telefono"].Value);
                tabG.SelectedIndex = 1; //con esto pasa automaticamente al tabpage mantemiento

            }
            catch(Exception)
            {
                MessageBox.Show("Selecione desde celda nombres");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                //validaciones 
                if (txtidCliente.Text == string.Empty)
                {
                    this.MensajeError("Campos Incompletos, estos seran marcados");
                    error.SetError(txtidCliente, "Ingrese el id");
                    return;
                }

                if (txtNombres.Text == string.Empty)
                {
                    this.MensajeError("Campos Incompletos, estos seran marcados");
                    error.SetError(txtNombres, "Ingrese sus nombres");
                    return;
                }
                if (txtApellidos.Text == string.Empty)
                {
                    this.MensajeError("Campos Incompletos, estos seran marcados");
                    error.SetError(txtApellidos, "Ingrese sus apellidos");
                    return;
                }
                if (txtEdad.Text == string.Empty)
                {
                    this.MensajeError("Campos Incompletos, estos seran marcados");
                    error.SetError(txtEdad, "Ingrese su edad");
                    return;
                }
                if (txtCorreo.Text == string.Empty)
                {
                    this.MensajeError("Campos Incompletos, estos seran marcados");
                    error.SetError(txtCorreo, "Ingrese su correo");
                    return;
                }
                if (txtTelefono.Text == string.Empty)
                {
                    this.MensajeError("Campos Incompletos, estos seran marcados");
                    error.SetError(txtTelefono, "Ingrese su telefono");
                    return;
                }

                //envio de informacion a la capa logica
                respuesta = Logica_Cliente.Actualizar(
                                            Convert.ToInt32 (txtidCliente.Text),txtNombres.Text, txtApellidos.Text,
                                            Convert.ToInt32(txtEdad.Text), txtCorreo.Text,
                                            txtTelefono.Text);
                if (respuesta.Equals("OK"))
                {
                    this.MensajeOk("Se actualizo el registro");
                    this.Limpiar();
                    this.listar();
                }
                else
                {
                    this.MensajeError(respuesta);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void chkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeleccionar.Checked)
            {
                dgvDatos.Columns[0].Visible = true;
                btnActivar.Visible = true;
                btnDesactivar.Visible = true;
                btnEliminar.Visible = true;
            }
            else
            {
                dgvDatos.Columns[0].Visible = false;
                btnActivar.Visible = false;
                btnDesactivar.Visible = false;
                btnEliminar.Visible = false;
            }
        }

        //metodo para seleccionar contenido
        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDatos.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgvDatos.Rows[e.RowIndex].Cells["Seleccionar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                string respuesta = "";
                int codigo;
                Opcion = MessageBox.Show("Desea eliminar el registro","Control de clientes", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if(Opcion == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dgvDatos.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            respuesta = Logica_Cliente.Eliminar(codigo);
                            if (respuesta.Equals("OK"))
                            {
                                this.MensajeOk("se elimino el registro: "+ Convert.ToString(row.Cells[2].Value) + " " + Convert.ToString(row.Cells[3].Value));
                            }
                            else
                            {
                                this.MensajeError(respuesta);
                            }
                        }
                    }
                    this.listar();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                string respuesta = "";
                int codigo;
                Opcion = MessageBox.Show("Desea desactivar el registro", "Control de clientes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dgvDatos.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            respuesta = Logica_Cliente.Desactivar(codigo);
                            if (respuesta.Equals("OK"))
                            {
                                this.MensajeOk("se desactivo el registro: " + Convert.ToString(row.Cells[2].Value) + " " + Convert.ToString(row.Cells[3].Value));
                            }
                            else
                            {
                                this.MensajeError(respuesta);
                            }
                        }
                    }
                    this.listar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                string respuesta = "";
                int codigo;
                Opcion = MessageBox.Show("Desea activar el registro", "Control de clientes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dgvDatos.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            respuesta = Logica_Cliente.Activar(codigo);
                            if (respuesta.Equals("OK"))
                            {
                                this.MensajeOk("se activo el registro: " + Convert.ToString(row.Cells[2].Value) + " " + Convert.ToString(row.Cells[3].Value));
                            }
                            else
                            {
                                this.MensajeError(respuesta);
                            }
                        }
                    }
                    this.listar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
