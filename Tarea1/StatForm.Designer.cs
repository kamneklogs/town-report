
namespace Tarea1
{
    partial class StatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatForm));
            this.chartTown = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartTown)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTown
            // 
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Name = "ChartArea1";
            this.chartTown.ChartAreas.Add(chartArea2);
            this.chartTown.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            legend2.Title = "Clasificacion";
            legend2.TitleAlignment = System.Drawing.StringAlignment.Near;
            this.chartTown.Legends.Add(legend2);
            this.chartTown.Location = new System.Drawing.Point(0, 0);
            this.chartTown.Name = "chartTown";
            this.chartTown.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.LabelFormat = " ";
            series2.Legend = "Legend1";
            series2.MarkerSize = 0;
            series2.Name = "TownType";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series2.YValuesPerPoint = 4;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartTown.Series.Add(series2);
            this.chartTown.Size = new System.Drawing.Size(474, 420);
            this.chartTown.TabIndex = 0;
            this.chartTown.Text = "Tipo";
            title2.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            title2.Name = "Title1";
            title2.Text = "Tipos";
            this.chartTown.Titles.Add(title2);
            // 
            // btnButton
            // 
            this.btnButton.Location = new System.Drawing.Point(367, 371);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(75, 23);
            this.btnButton.TabIndex = 1;
            this.btnButton.Text = "Volver";
            this.btnButton.UseVisualStyleBackColor = true;
            this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // StatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 420);
            this.Controls.Add(this.btnButton);
            this.Controls.Add(this.chartTown);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatForm";
            this.Text = "Municipios";
            ((System.ComponentModel.ISupportInitialize)(this.chartTown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTown;
    }
}