﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stresstest
{
   
    public partial class Form1 : Form
    {
        String tabell,tabell2;
        SqlConnection cnn;
        string connectionString;
        int fran;
        int till;
        String datum;
      //  datum = DateTime.Now.ToString("MMMM dd, yyyy");
        public Form1()
        {
            InitializeComponent();
            tabell = "dbo_Analysis Blood";
            tabell2 = "dbo.[Analysis Blood]";
            datum = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

            String Sql;

            Sql = "Select * from dbo.[Patients]";
          
            SqlDataReader reader = Datacontainer.command.ExecuteReader();
            reader.Read();
            //   int antal = (int)Datacontainer.command.ExecuteScalar();
            // antal = (int)Datacontainer.command.ExecuteScalar();
            Datacontainer.personnummer = (String)reader.GetValue(1);
            Datacontainer.Familyname = (String)reader.GetValue(2);
            Datacontainer.fornamn = (String)reader.GetValue(3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            textBox1.Update();
            textBox2.Update();
          //  textBox3.Update();
         //   textBox4.Update();
           
         //   fran = Int16.Parse(textBox3.Text);
           
        //    till = Int16.Parse(textBox4.Text);
            // connectionString = @"Data Source=Klingen-test-su-db,62468;Initial Catalog=Klingen_Test;User ID=tomha5;Password=202211";
            connectionString = @"Data Source=Klingen-test-su-db,62468;Initial Catalog=Klingen_Test;User ID=" + textBox1.Text + ";Password=" + textBox2.Text +"";
            //  connectionString = @"ODBC;DRIVER={SQL Server};UID=tomha5;PWD=202211;server = Klingen-test-su-db,62468;DATABASE = KlinGen_Test";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");


            //////////////////////////////////////////////////////////


            //SqlCommand command;
            //SqlDataReader dataReader;
            //String Sql, Output = "";
            //Sql = "sp_insert_enkel";
            //command = new SqlCommand(Sql, cnn);
            //command.CommandType = CommandType.StoredProcedure;


            ////command.Parameters.Add(new SqlParameter("@tabell", "Analysis Blood"));
            ////command.Parameters.Add(new SqlParameter("@analystyp", 1000));

            //command.Parameters.Add(new SqlParameter("@tabell",tabell));
            //command.Parameters.Add(new SqlParameter("@analystyp", 1));
            //command.Parameters.Add(new SqlParameter("@patient", 12171));
            //command.Parameters.Add(new SqlParameter("@Signature", textBox1.Text));
            //command.Parameters.Add(new SqlParameter("@SubmitterName", "GB"));
            //command.Parameters.Add(new SqlParameter("@Submitter", "xx"));
            //command.Parameters.Add(new SqlParameter("@Type", 1));
            //command.Parameters.Add(new SqlParameter("@Urgent", 1));
            //command.Parameters.Add(new SqlParameter("@Arriveddate_s", "20121001"));
            //command.Parameters.Add(new SqlParameter("@InvoiceDate_s", "20121002"));
            //command.Parameters.Add(new SqlParameter("@Indication", 1));
            //command.Parameters.Add(new SqlParameter("@Research", 1));
            //command.Parameters.Add(new SqlParameter("@Savedmaterial", 1));
            //command.Parameters.Add(new SqlParameter("@Canister", "xxx"));
            //command.Parameters.Add(new SqlParameter("@Box", "fg"));
            //command.Parameters.Add(new SqlParameter("@Number", "123"));
            //command.Parameters.Add(new SqlParameter("@Remark", "yyyy"));
            //command.Parameters.Add(new SqlParameter("@OrdererInternal", 1));
            //command.Parameters.Add(new SqlParameter("@Orderer", 1));
            //command.Parameters.Add(new SqlParameter("@AccountableInternal", 1));
            //command.Parameters.Add(new SqlParameter("@Accountable", 1));
            //command.Parameters.Add(new SqlParameter("@Result", 7));
            //command.Parameters.Add(new SqlParameter("@Quality", 8));
            //command.Parameters.Add(new SqlParameter("@Diagnosis", "fel"));
            //command.Parameters.Add(new SqlParameter("@McKusick_s", "12"));
            //command.Parameters.Add(new SqlParameter("@Answered", 1));
            //command.Parameters.Add(new SqlParameter("@Price_s", "1000"));
            //command.Parameters.Add(new SqlParameter("@AnsweredDate_s", "20121004"));
            //command.Parameters.Add(new SqlParameter("@InvoiceNr", 10));
            //command.Parameters.Add(new SqlParameter("@Doctor", 11));
            //command.Parameters.Add(new SqlParameter("@Metaphase", "yyy"));
            //command.Parameters.Add(new SqlParameter("@Locked", 1));
            //command.Parameters.Add(new SqlParameter("@Change", "zzz"));
            //command.Parameters.Add(new SqlParameter("@ResultInternal", "tt"));
            //command.Parameters.Add(new SqlParameter("@Prenatal", 1));
            //command.Parameters.Add(new SqlParameter("@ResultInternal2", 100));
            //command.Parameters.Add(new SqlParameter("@Family", 200));
            //command.Parameters.Add(new SqlParameter("@CareDate_s", "20121003"));
            //command.Parameters.Add(new SqlParameter("@SpecimenType", "xxx"));


            //dataReader = command.ExecuteReader();
            //dataReader.Close();
            //  for (int a = fran; a <= till; a++)
            //   {
            //    // SqlDataReader dataReader2;
            //   command.Parameters.RemoveAt(1);
            //    //    command.Parameters.Add(new SqlParameter("@analystyp", a));
            //    command.Parameters.Insert(1, new SqlParameter("@analystyp", a));
            //       dataReader = command.ExecuteReader();
            //    if(a < till)
            //       dataReader.Close();
            //}
            //while (dataReader.Read())
            //{
            //    Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1);

            //}
            //MessageBox.Show(Output);


            //cnn.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          //  textBox1.Update();
           // textBox1.valu
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tabell = "dbo_Analysis Blood";
            tabell2 = "dbo.[Analysis Blood]";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tabell = "dbo_Analysis DNA";
            tabell2 = "dbo.[Analysis DNA]";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tabell = "dbo_Analysis Tumor";
            tabell2 = "dbo.[Analysis Tumor]";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            tabell = "dbo_Analysis FISH";
            tabell2 = "dbo.[Analysis FISH]";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            tabell = "dbo_Analysis Counselling";
            tabell2 = "dbo.[Analysis Counselling]";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            tabell = "dbo_Analysis Referral";
            tabell2 = "dbo.[Analysis Referral]";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            tabell = "dbo_Analysis Foetus";
            tabell2 = "dbo.[Analysis Foetus]";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            tabell = "dbo_Analysis Fibroblast";
            tabell2 = "dbo.[Analysis Fibroblast]";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            tabell = "dbo_Analysis Amnion";
            tabell2 = "dbo.[Analysis Amnion]";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            tabell = "dbo_Analysis Chorion";
            tabell2 = "dbo.[Analysis Chorion]";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataReader dataReader;
            textBox3.Update();
            textBox4.Update();

            fran = Int16.Parse(textBox3.Text);

            till = Int16.Parse(textBox4.Text);
            String Sql, Output = "";
            Sql = "sp_insert_enkel2";
            command = new SqlCommand(Sql, cnn);
            command.CommandType = CommandType.StoredProcedure;


            //command.Parameters.Add(new SqlParameter("@tabell", "Analysis Blood"));
            //command.Parameters.Add(new SqlParameter("@analystyp", 1000));
          //  String datum;
          //  datum = DateTime.Now.ToString("MMMM dd, yyyy");

            command.Parameters.Add(new SqlParameter("@tabell", tabell));
            command.Parameters.Add(new SqlParameter("@analystyp", fran));
            command.Parameters.Add(new SqlParameter("@patient", 12171));
            command.Parameters.Add(new SqlParameter("@Signature", textBox1.Text));
            command.Parameters.Add(new SqlParameter("@SubmitterName", "GB"));
            command.Parameters.Add(new SqlParameter("@Submitter", "xx"));
            command.Parameters.Add(new SqlParameter("@Type", 1));
            command.Parameters.Add(new SqlParameter("@Urgent", 1));
            command.Parameters.Add(new SqlParameter("@Arriveddate_s", "20121001"));
            command.Parameters.Add(new SqlParameter("@InvoiceDate_s", "20121002"));
            command.Parameters.Add(new SqlParameter("@Indication", 1));
            command.Parameters.Add(new SqlParameter("@Research", 1));
            command.Parameters.Add(new SqlParameter("@Savedmaterial", 1));
            command.Parameters.Add(new SqlParameter("@Canister", "xxx"));
            command.Parameters.Add(new SqlParameter("@Box", "fg"));
            command.Parameters.Add(new SqlParameter("@Number", "123"));
            command.Parameters.Add(new SqlParameter("@Remark", "yyyy"));
            command.Parameters.Add(new SqlParameter("@OrdererInternal", 1));
            command.Parameters.Add(new SqlParameter("@Orderer", 1));
            command.Parameters.Add(new SqlParameter("@AccountableInternal", 1));
            command.Parameters.Add(new SqlParameter("@Accountable", 1));
            command.Parameters.Add(new SqlParameter("@Result", 7));
            command.Parameters.Add(new SqlParameter("@Quality", 8));
            command.Parameters.Add(new SqlParameter("@Diagnosis", "fel"));
            command.Parameters.Add(new SqlParameter("@McKusick_s", "12"));
            command.Parameters.Add(new SqlParameter("@Answered", 1));
            command.Parameters.Add(new SqlParameter("@Price_s", "1000"));
            command.Parameters.Add(new SqlParameter("@AnsweredDate_s", datum));
            command.Parameters.Add(new SqlParameter("@InvoiceNr", 10));
            command.Parameters.Add(new SqlParameter("@Doctor", 11));
            command.Parameters.Add(new SqlParameter("@Metaphase", "yyy"));
            command.Parameters.Add(new SqlParameter("@Locked", 1));
            command.Parameters.Add(new SqlParameter("@Change", "zzz"));
            command.Parameters.Add(new SqlParameter("@ResultInternal", "tt"));
            command.Parameters.Add(new SqlParameter("@Prenatal", 1));
            command.Parameters.Add(new SqlParameter("@ResultInternal2", 100));
            command.Parameters.Add(new SqlParameter("@Family", 200));
            command.Parameters.Add(new SqlParameter("@CareDate_s", "20121003"));
            command.Parameters.Add(new SqlParameter("@SpecimenType", "xxx"));


            dataReader = command.ExecuteReader();
            dataReader.Close();
            for (int a = fran+1; a <= till; a++)
            {
                // SqlDataReader dataReader2;
                command.Parameters.RemoveAt(1);
                //    command.Parameters.Add(new SqlParameter("@analystyp", a));
                command.Parameters.Insert(1, new SqlParameter("@analystyp", a));
                dataReader = command.ExecuteReader();
                //    Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1);
            //    Output = Output + dataReader.GetValue(0);
                if (a < till) 
                   dataReader.Close();
            }
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1);

            }
            MessageBox.Show("Inskrivning klar!");


            //   cnn.Close();
            dataReader.Close();
      //      button3.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String Sql = "Delete  from " + tabell2 + " where patient=12171 and signature = '" + textBox1.Text + "'" + " and [Answered Date] = '" + datum + "'";
            SqlCommand command = new SqlCommand(Sql, cnn);
            command.ExecuteNonQuery();
            MessageBox.Show("städat!");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

           // String Sql = "Select count(*) from dbo.[" + tabell + "] where patient=12171 and signature = " + textBox1.Text + "";
            String Sql = "Select count(*) from " + tabell2 + " where patient=12171 and signature = '" + textBox1.Text + "'" + " and [Answered Date] = '" + datum + "'";



           // SqlCommand command;
          //  command.CommandText = "SELECT COUNT(*) FROM table_name";
        //    Int32 count = (Int32)cmd.ExecuteScalar();




            //  SqlCommand command = new SqlCommand("Select count(*) from " + tabell + " where patient=12171 and signature = " + textBox1.Text + "", cnn);
            SqlCommand command = new SqlCommand(Sql, cnn);
            //  command.Parameters.AddWithValue("@zip", "india");
            // int result = command.ExecuteNonQuery();
            //    using (SqlDataReader reader = command.ExecuteReader())
        //    using (SqlDataReader reader = command.ExecuteScalar())
                Int32 Count = (Int32)command.ExecuteScalar();
            {
              //  if (reader.Read())
                {
                    int bb;
                    bb = 0;
                    if(Count == ((till - fran)+1))
                    {
                        MessageBox.Show("Verifierat!");
                    }
                    else
                    {
                        MessageBox.Show("Något gick fel!");
                    }
                }
            }
        }
    }
}
