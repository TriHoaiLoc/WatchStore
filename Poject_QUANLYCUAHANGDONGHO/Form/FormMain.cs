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
using Project_QUANLYCUAHANGDONGHO.Class;
using Project_QUANLYCUAHANGDONGHO.DAO;


namespace Project_QUANLYCUAHANGDONGHO
{
    
    public partial class FormMain : Form
    {
        public FormMain()
        {
<<<<<<< HEAD
=======
            sqlCon = new SqlConnection(sqlstring);
            /*if (sqlCon == null)
            {
                sqlCon = new SqlConnection(sqlstring);


            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                //  MessageBox.Show("Connected Sucessfully");

            }*/
>>>>>>> e37f5c34c636489248faf6a4decc1a69d33b3dc8
            InitializeComponent();
            ShowProduct();
        }
        private void ShowProduct()
        {
<<<<<<< HEAD
            ProductDAO productDAO = new ProductDAO();
            dataGridView1.DataSource = productDAO.ShowProduct();
=======
            SqlDataReader reader = null;


            //if (sqlCon == null)
            //{
            //    sqlCon = new SqlConnection(sqlstring);


            //}
            //if (sqlCon.State == ConnectionState.Closed)
            //{
            //    sqlCon.Open();
            //    //  MessageBox.Show("Connected Sucessfully");

            //}
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandText = "FIND_CUS";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter idpara = new SqlParameter("@PHONE", SqlDbType.NVarChar);
            idpara.Value = textBox5.Text;

            cmd.Parameters.Add(idpara);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox6.Text = reader.GetString(0) ;
                textBox2.Text = reader.GetString(1);
                textBox3.Text = reader.GetString(2);
            }
            else
            {
                MessageBox.Show("KHÔNG THẤY");
            }
            //01919331

            reader.Close();
            sqlCon.Close();

>>>>>>> e37f5c34c636489248faf6a4decc1a69d33b3dc8
        }

    }
}
