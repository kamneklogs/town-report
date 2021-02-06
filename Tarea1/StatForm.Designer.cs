
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartTown = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartTown)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTown
            // 
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Name = "ChartArea1";
            this.chartTown.ChartAreas.Add(chartArea1);
            this.chartTown.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            legend1.Title = "Clasificacion";
            legend1.TitleAlignment = System.Drawing.StringAlignment.Near;
            this.chartTown.Legends.Add(legend1);
            this.chartTown.Location = new System.Drawing.Point(0, 0);
            this.chartTown.Name = "chartTown";
            this.chartTown.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = " ";
            series1.Legend = "Legend1";
            series1.MarkerSize = 0;
            series1.Name = "TownType";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValuesPerPoint = 4;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartTown.Series.Add(series1);
            this.chartTown.Size = new System.Drawing.Size(474, 420);
            this.chartTown.TabIndex = 0;
            this.chartTown.Text = "Tipo";
            title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "Tipos";
            this.chartTown.Titles.Add(title1);
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
            this.Name = "StatForm";
            this.Text = "StatForm";
            ((System.ComponentModel.ISupportInitialize)(this.chartTown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTown;
    }
}