using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExelAppV1
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            senha_registro.PasswordChar = '*';
        }
        private void f1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
  
        {
            string Conexao = "Server=localhost; Database=exel; Uid=root;Pwd=Ongrace@123";
            var connection = new MySqlConnection(Conexao);
            var comand = connection.CreateCommand();
            MySqlCommand query = new MySqlCommand("select count(*) from usuario where nome= '" + textBox1.Text + "' and senha= '" + textBox2.Text + "'", connection);
            connection.Open();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(query);
            da.Fill(dataTable);
            connection.Close();


            foreach (DataRow list in dataTable.Rows)
            {
                if (Convert.ToInt32(list.ItemArray[0]) > 0)
                {
                    Form1 f1 = new Form1();

                    f1.FormClosed += new FormClosedEventHandler(f1_FormClosed);
                    f1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Atenção! Senha/Usuário Inválido");
                }
            }


            connection.Close();

        } 

        private void button2_Click(object sender, EventArgs e)
        {
            string Conexao = "Server=localhost; Database=exel; Uid=root;Pwd=Ongrace@123";         
            string insertQuery = "insert into usuario(nome,senha) values('" + usuario_registro.Text + "','" + senha_registro.Text + "')";
            var connection = new MySqlConnection(Conexao);
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);


            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Usuário registrado");
                }
                else
                {
                    MessageBox.Show("Usuário não Registrado");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }
            

        }
    }
