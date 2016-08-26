using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace slotmachine
{
    public partial class db_rezult : Form
    {
        public db_rezult(string result)
        {
            InitializeComponent();
            result_lbl.Text = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vards = name_txt.Text;
            string punkti = result_lbl.Text;
            OleDbConnection connect = new OleDbConnection();
            connect.ConnectionString = (@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\db.mdb"); //sitais strings md jasuuta
            connect.Open();
            MessageBox.Show("ir savienojums");

            OleDbCommand cmd = new OleDbCommand("INSERT INTO punkti (vards,punkti) VALUES(@vards, @punkti)", connect);

            if (connect.State == ConnectionState.Open)
            {
                cmd.Parameters.Add("@vards", OleDbType.Char, 100).Value = vards;
                cmd.Parameters.Add("@punkti", OleDbType.Char, 100).Value = punkti;
               

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("dati saglabati");
                    this.Close();


                }
                catch (Exception excp)
                {
                }

            }


        }  

            
 
    }
}
