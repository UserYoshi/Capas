using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}
