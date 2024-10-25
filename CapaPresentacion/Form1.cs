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

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.listar();
        }
    }
}
