using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Использование_бд
{
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Form1.conString);
            con.Open();
            SqlCommand query = new SqlCommand($@"Insert into
Users
Values ('{tbxFam.Text}','{tbxName.Text}','{tbxLogin.Text}','{tbxPass.Text}')", con);
            query.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Регистрация прошла успешно!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
