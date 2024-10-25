namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabG = new System.Windows.Forms.TabControl();
            this.tab = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.lbTotal = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabG.SuspendLayout();
            this.tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabG
            // 
            this.tabG.Controls.Add(this.tab);
            this.tabG.Controls.Add(this.tabPage2);
            this.tabG.Location = new System.Drawing.Point(0, 0);
            this.tabG.Name = "tabG";
            this.tabG.SelectedIndex = 0;
            this.tabG.Size = new System.Drawing.Size(799, 447);
            this.tabG.TabIndex = 0;
            // 
            // tab
            // 
            this.tab.Controls.Add(this.btnBuscar);
            this.tab.Controls.Add(this.txtBuscar);
            this.tab.Controls.Add(this.lbTotal);
            this.tab.Controls.Add(this.dgvDatos);
            this.tab.Location = new System.Drawing.Point(4, 25);
            this.tab.Name = "tab";
            this.tab.Padding = new System.Windows.Forms.Padding(3);
            this.tab.Size = new System.Drawing.Size(791, 418);
            this.tab.TabIndex = 0;
            this.tab.Text = "Listado";
            this.tab.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToOrderColumns = true;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dgvDatos.Location = new System.Drawing.Point(10, 80);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(771, 258);
            this.dgvDatos.TabIndex = 0;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(490, 362);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(38, 16);
            this.lbTotal.TabIndex = 1;
            this.lbTotal.Text = "Total";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(24, 26);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(373, 22);
            this.txtBuscar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(434, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabG);
            this.Name = "Form1";
            this.Text = "Formulario Para el registro de los Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabG.ResumeLayout(false);
            this.tab.ResumeLayout(false);
            this.tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabG;
        private System.Windows.Forms.TabPage tab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
    }
}

