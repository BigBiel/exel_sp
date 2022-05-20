using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ExelAppV1
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


        }
        private void OK_SKU_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Selecione um arquivo.");
                return;
            }

            
            /*if (String.IsNullOrEmpty(textBox_SKU.Text))
            {               MessageBox.Show("Escreva o SKU.");
                return;
            } */

            try
            {

                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();


                foreach (ListViewItem arquivo in listView1.Items)
                {
                    Workbook sheet = excel.Workbooks.Open(arquivo.Text);
                    Worksheet x = excel.ActiveSheet as Worksheet;

                    string sku = x.Range["A2"].Value + ".png"; //textBox_SKU.Text;
                    
                    if (x.Range["A2"].Value == null)
                    {
                        pictureBox2.Visible = true;
                        MessageBox.Show("Campo SKU vazio");
                        return;
                    }

                    x.Range[x.Cells[3, 1], x.Cells[7, 150]].Value = null;
                    x.Range["EP2"].Value = "88";
                    x.Range["EQ2"].Value = sku;
                    x.Range["ER2"].Value = "201";
                    x.Range["ES2"].Value = "1";
                    x.Range["ET2"].Value = "0";
                    x.Range["Z2"].Formula = sku;
                    x.Range["AA2"].Value = "201";
                    x.Range["AX2"].Value = "201";
                    x.Range["AW2"].Value = sku;

                    pictureBox1.Visible = true;


                    sheet.Save();

                    sheet.Close(false);
                }
                MessageBox.Show("O arquivo foi alterado.");

                excel.Quit();
            }

            catch (Exception ex)
            {
                
                MessageBox.Show("Houve um erro com o processamente do arquivo. Detalhes do erro: " + ex.Message, "Erro do Sistema");
            }

        }

        private void BtnSearcExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Multiselect = true;

            ofd.Filter = "CSV FILE|*.csv";

            listView1.Items.Clear();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                foreach (string fileName in ofd.FileNames)
                {
                    listView1.Items.Add(fileName);
                }

                pictureBox1.Visible = false;
                pictureBox2.Visible = false;


            }
            

        }

    }
}