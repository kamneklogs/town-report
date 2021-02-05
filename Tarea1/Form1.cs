using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog.FileName);

                    string s = sr.ReadLine();
                    s = sr.ReadLine();
                    int index = 0;
                    string[] temp = null;
                    while (s != null)
                    {
                        temp = s.Split(',');


                        index = dataTownGridRecord.Rows.Add();
                        dataTownGridRecord.Rows[index].Cells[0].Value = temp[0];
                        dataTownGridRecord.Rows[index].Cells[1].Value = temp[1];
                        dataTownGridRecord.Rows[index].Cells[2].Value = temp[2];
                        dataTownGridRecord.Rows[index].Cells[3].Value = temp[3];
                        dataTownGridRecord.Rows[index].Cells[4].Value = temp[4];






                        s = sr.ReadLine();
                    }






                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


    }
}
