using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ContractingDesktop
{
    public partial class Form1 : Form
    {
        static public string constring = "Server = laptop-ade7qeuv; Database=Sealteam5; Integrated Security = True;";
        public SqlConnection connect = new SqlConnection(constring);
        public SqlDataReader myreader;
        public SqlDataAdapter adapter = new SqlDataAdapter();
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = new SqlCommand("INSERT INTO CONTRACTORS (FirstName, LastName, Email) VALUES ('"+FirstText.Text+"','"+LastText.Text+"','"+EmailText.Text+"')", connect);
            connect.Open();
            adapter.InsertCommand.ExecuteNonQuery();
            adapter.InsertCommand = new SqlCommand("INSERT INTO CLIENTS (ClientName) VALUES ('"+ ClientText.Text+ "')", connect);
            adapter.InsertCommand.ExecuteNonQuery();
            connect.Close();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            cmd.CommandText = "SELECT EmployeeID FROM CONTRACTORS WHERE FirstName = '" + FirstText.Text + "' and LastName = '" + LastText.Text + "'";
            connect.Open();
            int Emid = (int) cmd.ExecuteScalar();

            cmd.CommandText = "SELECT ClientID FROM Clients WHERE ClientName = '" + ClientText.Text + "'";
            int Clid = (int) cmd.ExecuteScalar();

            connect.Close();
            connect.Open();
            adapter.InsertCommand = new SqlCommand("INSERT INTO CONTRACT (EmployeeID, ClientID) VALUES ('" + Emid.ToString() + "','" + Clid.ToString() + "')", connect);
            adapter.InsertCommand.ExecuteNonQuery();
            connect.Close();


        }

    }
    
}
