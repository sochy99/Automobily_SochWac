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

namespace Automobily_SochWac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Model;
        int RokVyroby;
        int Cena;
        int Spotreba;
        bool AutomatickaPrevodovka;
        int Vykon;
        string Barva;
        string PalivoId;
        string ZnackaId;




        private void Form1_Load(object sender, EventArgs e)
        {
            //***********************************
            string DB_key = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\DTB_sch2.mdf; Integrated Security = True; Connect Timeout = 30";
            SqlConnection pripojeni = new SqlConnection(DB_key);
            //***********************************
            string prikazND = "SELECT * FROM [TB_main]";
            SqlCommand sqlprikazND = new SqlCommand(prikazND, pripojeni);
            //***********************************
            pripojeni.Open();//-------------------------------------------------------------  Pripojeni Open
            SqlDataReader zaznamy = sqlprikazND.ExecuteReader();
            //***********************************
            while (zaznamy.Read())
            {
                LB_seznam.Items.Add($"{zaznamy[1]} {zaznamy[2]}");
            }
            pripojeni.Close(); //-------------------------------------------------------------  Pripojeni Close



            TB_model.Text = Model;
            RokVyroby = Convert.ToInt32(DTP_rok_vyroby.Value);
            Vykon = Convert.ToInt32(TB_vykon);
            Cena = Convert.ToInt32(TB_cena);
            Spotreba = Convert.ToInt32(TB_spotreba);




        }

        private void button2_Click(object sender, EventArgs e)
        {
            //***********************************
            string DB_key = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\DTB_sch2.mdf; Integrated Security = True; Connect Timeout = 30";
            SqlConnection pripojeni = new SqlConnection(DB_key);
            //***********************************
            string prikazND = "SELECT * FROM [TB_main]";
            SqlCommand sqlprikazND = new SqlCommand(prikazND, pripojeni);
            //***********************************
            sqlprikazND.Parameters.AddWithValue("@Model", Model);
            sqlprikazND.Parameters.AddWithValue("@Rok_vyroby", RokVyroby);
            sqlprikazND.Parameters.AddWithValue("@Cena", Cena);
            sqlprikazND.Parameters.AddWithValue("@Spotreba", Spotreba);
            sqlprikazND.Parameters.AddWithValue("@Automaticka_prevodovka", AutomatickaPrevodovka);
            sqlprikazND.Parameters.AddWithValue("@Vykon", Vykon);
            //***********************************
            pripojeni.Open();
            sqlprikazND.ExecuteNonQuery();
            pripojeni.Close();
        }
    }
}
