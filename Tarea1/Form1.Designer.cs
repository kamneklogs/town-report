
namespace Tarea1
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
            this.dataTownGridRecord = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.departamentoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MunicipioName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMunicipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataTownGridRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTownGridRecord
            // 
            this.dataTownGridRecord.AllowUserToAddRows = false;
            this.dataTownGridRecord.AllowUserToDeleteRows = false;
            this.dataTownGridRecord.AllowUserToOrderColumns = true;
            this.dataTownGridRecord.AllowUserToResizeColumns = false;
            this.dataTownGridRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTownGridRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departamentoID,
            this.municipioID,
            this.departamentoName,
            this.MunicipioName,
            this.tipoMunicipio});
            this.dataTownGridRecord.Location = new System.Drawing.Point(12, 179);
            this.dataTownGridRecord.Name = "dataTownGridRecord";
            this.dataTownGridRecord.Size = new System.Drawing.Size(776, 259);
            this.dataTownGridRecord.TabIndex = 0;
            this.dataTownGridRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Importar archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(448, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ver estadisticas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // departamentoID
            // 
            this.departamentoID.HeaderText = "Codigo Departamento";
            this.departamentoID.Name = "departamentoID";
            this.departamentoID.Width = 140;
            // 
            // municipioID
            // 
            this.municipioID.HeaderText = "Codigo Municipio";
            this.municipioID.Name = "municipioID";
            this.municipioID.Width = 140;
            // 
            // departamentoName
            // 
            this.departamentoName.HeaderText = "Nombre Departamento";
            this.departamentoName.Name = "departamentoName";
            this.departamentoName.Width = 140;
            // 
            // MunicipioName
            // 
            this.MunicipioName.HeaderText = "Nombre Municipio";
            this.MunicipioName.Name = "MunicipioName";
            this.MunicipioName.Width = 140;
            // 
            // tipoMunicipio
            // 
            this.tipoMunicipio.HeaderText = "Tipo";
            this.tipoMunicipio.Name = "tipoMunicipio";
            this.tipoMunicipio.Width = 140;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataTownGridRecord);
            this.Name = "Form1";
            this.Text = "Reporte de Municipios";
            ((System.ComponentModel.ISupportInitialize)(this.dataTownGridRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTownGridRecord;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MunicipioName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMunicipio;
    }
}

