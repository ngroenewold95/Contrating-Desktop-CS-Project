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

namespace ContractingDesktop
{
    public partial class AddContract : Form
    {
        static public string constring = "Server = laptop-ade7qeuv; Database=Sealteam5; Integrated Security = True;";
        public SqlConnection connect = new SqlConnection(constring);
        public SqlDataReader myreader;
        public SqlDataAdapter adapter = new SqlDataAdapter();
        public AddContract()
        {
            InitializeComponent();
        }

        private void AddContract_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            connect.Open();
            adapter.InsertCommand = new SqlCommand("INSERT INTO CONTRACTORS (FirstName, LastName, Email) VALUES ('" + FirstText.Text + "','" + LastText.Text + "','" + CityText.Text + "')", connect);
            adapter.InsertCommand.ExecuteNonQuery();
            adapter.InsertCommand = new SqlCommand("INSERT INTO CLIENTS (ClientName) VALUES ('" + ZipText.Text + "')", connect);
            adapter.InsertCommand.ExecuteNonQuery();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            cmd.CommandText = "SELECT EmployeeID FROM CONTRACTORS WHERE FirstName = '" + FirstText.Text + "' and LastName = '" + LastText.Text + "'";
            int Emid = (int)cmd.ExecuteScalar();
            cmd.CommandText = "SELECT ClientID FROM Clients WHERE ClientName = '" + ZipText.Text + "'";
            int Clid = (int)cmd.ExecuteScalar();
            adapter.InsertCommand = new SqlCommand("INSERT INTO CONTRACT (EmployeeID, ClientID) VALUES ('" + Emid.ToString() + "','" + Clid.ToString() + "')", connect);
            adapter.InsertCommand.ExecuteNonQuery();
            connect.Close();

        }

        private void EmailText_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
