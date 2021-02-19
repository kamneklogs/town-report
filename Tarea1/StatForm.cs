using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1
{
    public partial class StatForm : Form
    {

        private DataGridViewRowCollection rows { get; set; }

        private  String[] types = { "Municipio", "Isla", "Área no municipalizada"};

        public StatForm(DataGridViewRowCollection rows)
        {
            InitializeComponent();

            this.rows = rows;

            double total = rows.Count;
            double municipioCount = 0;
            double noMunicipioCount = 0;
            double otroCount = 0;
            double islaCount = 0;

            foreach (DataGridViewRow item in rows)
            {
                if (((string)item.Cells[4].Value).Equals(types[0]))
                {
                    municipioCount++;
                }else
                if (((string)item.Cells[4].Value).Equals(types[1]))
                {
                    islaCount++;
                }else
                if (((string)item.Cells[4].Value).Equals(types[2]))
                {
                    noMunicipioCount++;
                }else
                {
                    otroCount++;
                }
            }

            municipioCount /= total;
            islaCount /= total;
            noMunicipioCount /= total;

            chartTown.Series["TownType"].Points.AddXY("MUNICIPIO",municipioCount);
            chartTown.Series["TownType"].Points.AddXY("ÁREA NO MUNICIPALIZADA",noMunicipioCount);
            chartTown.Series["TownType"].Points.AddXY("SIN VALOR",1.0-municipioCount-islaCount-noMunicipioCount);
            chartTown.Series["TownType"].Points.AddXY("ISLA",islaCount);

        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            this.Close();
            //testing git
        }
    }
}
