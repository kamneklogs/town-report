
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataTownGridRecord = new System.Windows.Forms.DataGridView();
            this.departamentoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MunicipioName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMunicipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Importar archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(553, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ver clasificación de municipios";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Tag = "";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "De:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Filtrar por rango de codigo Dane del Municipio";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(308, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Ejecutar filtro";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(421, 130);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Borrar filtro";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataTownGridRecord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Reporte de Municipios";
            ((System.ComponentModel.ISupportInitialize)(this.dataTownGridRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

