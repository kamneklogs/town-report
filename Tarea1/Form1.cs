using System;
using System.IO;
using System.Security;
using System.Windows.Forms;

namespace Tarea1
{
    public partial class Form1 : Form
    {

        private string mainPath { get; set; }

      

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
                int index = 0;

                try
                {
                    mainPath = openFileDialog.FileName;

                    var sr = new StreamReader(mainPath);

                    string s = sr.ReadLine();
                    s = sr.ReadLine();
                    string[] temp = null;
                    while (s != null)
                    {
                        temp = s.Split(',');

                        index = dataTownGridRecord.Rows.Add();
                        dataTownGridRecord.Rows[index].Cells[0].Value = temp[0];
                        dataTownGridRecord.Rows[index].Cells[1].Value = int.Parse(temp[1]);
                        dataTownGridRecord.Rows[index].Cells[2].Value = temp[2];
                        dataTownGridRecord.Rows[index].Cells[3].Value = temp[3];
                        dataTownGridRecord.Rows[index].Cells[4].Value = temp[4];
                        s = sr.ReadLine();
                    }


                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
                catch(IndexOutOfRangeException ex)
                {
                    MessageBox.Show($"\n\nError message: {ex.Message}\n\n" +
                   $"Details:\n\n{ex.StackTrace}");
                }
                catch(FormatException)
                {
                    dataTownGridRecord.Rows.RemoveAt(index);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StatForm newWindow = new StatForm(dataTownGridRecord.Rows);
            newWindow.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
    

            int bottom = int.Parse(textBox1.Text);

            int top = int.Parse(textBox2.Text);

            for (int i = 0; i < dataTownGridRecord.Rows.Count; i++)
            {
                int value = (int)dataTownGridRecord.Rows[i].Cells[1].Value;
                if ((value> top)||(value < bottom))
                {
                    dataTownGridRecord.Rows.RemoveAt(i);
                    i--;
                }

            }
         
        }

        private void button4_Click(object sender, EventArgs e)
        {

            dataTownGridRecord.Rows.Clear();
            int index = 0;

            try
            {

                var sr = new StreamReader(mainPath);

                string s = sr.ReadLine();
                s = sr.ReadLine();
                string[] temp = null;
                while (s != null)
                {
                    temp = s.Split(',');

                    index = dataTownGridRecord.Rows.Add();
                    dataTownGridRecord.Rows[index].Cells[0].Value = temp[0];
                    dataTownGridRecord.Rows[index].Cells[1].Value = int.Parse(temp[1]);
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
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show($"\n\nError message: {ex.Message}\n\n" +
               $"Details:\n\n{ex.StackTrace}");
            }
            catch (FormatException)
            {
                dataTownGridRecord.Rows.RemoveAt(index);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("El archivo ya no se encuentra en la ubicacion inicial");
            }


        }
    }
}