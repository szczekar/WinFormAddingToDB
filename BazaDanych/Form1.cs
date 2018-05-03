using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazaDanych
{
    public partial class Form1 : Form
    {
         
        SqlCommand sqlCommand;
        static string connectionString = "Server=KAROL;Database=TEST_CS;Trusted_Connection=true";
        SqlConnection connection = new SqlConnection(connectionString);

        private void openCloseDBconnection(string value)
        {
            using (sqlCommand = new SqlCommand(value, connection))
            {
                connection.Open();
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }

        }

        public Form1()
        {
            InitializeComponent();


        }

        private void buttonBaza_Click(object sender, EventArgs e)
        {
            
            string cmdText = "INSERT INTO dbo.Users (Name) VALUES ('Karol')";
            openCloseDBconnection(cmdText);
        }

        private void buttonDopiszDoBazy_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBoxNewUser.Text != null)
                {
                    // put name into DB
                    string inputText = textBoxNewUser.Text;
                    string newName = string.Format("INSERT INTO dbo.Users (Name) VALUES ('{0}')",inputText);
                    openCloseDBconnection(newName);
                    MessageBox.Show("Imie zostało dopisane do bazy !");

                    // put password into DB
                    string password = inputPassword.Text;
                    string newPassword = string.Format("INSERT INTO dbo.Users (Name) VALUES ('" + password + "')");
                    openCloseDBconnection(newPassword);
                    MessageBox.Show("Hasło zostało dopisane do bazy !");

                }

                else
                {
                    return;
                }

                
            }
             
            catch(InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }

        private void buttonDeleteTable_Click(object sender, EventArgs e)
        {
            string deleteFromDB = "DELETE FROM dbo.Users";
            openCloseDBconnection(deleteFromDB);
            string setMainKey = "DBCC CHECKIDENT('dbo.Users', RESEED, 0)";
            openCloseDBconnection(setMainKey);
            MessageBox.Show("Wszystkie dane z tabeli usunięte !");

        }
    }

}
