﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace UniSoft

{
    public partial class AddParent : Form
    {
        public AddParent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
                int parentId = Int32.Parse(textBox1.Text);
                String address = textBox2.Text;
                int gender = Int32.Parse(textBox3.Text);
                String telephoneNumber = textBox3.Text;


            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "prasanna@5912";
            builder.Database = "mydb";

            MySqlConnection connection = new MySqlConnection(builder.ToString());
            try { 
                connection.Open();

                String newStudent_mysql = "INSERT INTO parent (ParentId,Address,gender,`telephone number`) VALUES (@id, @address, @gender, @tp)";
                MySqlCommand newStudent = new MySqlCommand(newStudent_mysql, connection);
                newStudent.CommandText = newStudent_mysql;

                 
                newStudent.Parameters.AddWithValue("@id", parentId);
                newStudent.Parameters.AddWithValue("@address", address);
                newStudent.Parameters.AddWithValue("@gender", gender);
                newStudent.Parameters.AddWithValue("@tp", telephoneNumber);

                newStudent.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Success");
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }

           
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
