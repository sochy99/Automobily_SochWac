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
        //====================================================
        string Model;
        string RokVyroby;
        int Cena;
        int Spotreba;
        bool AutomatickaPrevodovka; 
        int Vykon;
        string Barva; 
        int PalivoId;
        int ZnackaId;

        string cesta = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\simon\Desktop\Automobily_SochWac-master\DTB_Auta.mdf; Integrated Security = True; Connect Timeout = 30";
        //====================================================
        private void Form1_Load(object sender, EventArgs e)
        {
           ComboVypis();
            LB_Helper.Hide();

          if (RB_vypis.Checked == true)
            {
                GB_1.Enabled = false;
                GB_2.Enabled = false;
            }

          if (RB_filtrace.Checked == true)
            {
                GB_1.Enabled = false;
                GB_2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textovepole();          
            string DB_key = cesta;
            SqlConnection pripojeni = new SqlConnection(DB_key);
            //-------------------------------------------
            //********************************************************************************************************
            string prikaz2 = "INSERT INTO [TB_main] (Model, Rok_vyroby, Cena, Spotreba, Automaticka_prevodovka, Vykon, Barva, Palivo_Id, Znacka_Id) VALUES (@Model, @Rok_vyroby, @Cena, @Spotreba, @Automaticka_prevodovka, @Vykon, @Barva, @Palivo_Id, @Znacka_Id)";
            SqlCommand sqlprikaz2 = new SqlCommand(prikaz2, pripojeni);
            //----------------------------------------
            sqlprikaz2.Parameters.AddWithValue("@Model", Model);
            sqlprikaz2.Parameters.AddWithValue("@Rok_vyroby", DTP_rok_vyroby.Value);
            sqlprikaz2.Parameters.AddWithValue("@Cena", Cena);
            sqlprikaz2.Parameters.AddWithValue("@Spotreba", Spotreba);
            sqlprikaz2.Parameters.AddWithValue("@Automaticka_prevodovka", AutomatickaPrevodovka);
            sqlprikaz2.Parameters.AddWithValue("@Vykon", Vykon);
            sqlprikaz2.Parameters.AddWithValue("@Barva", Barva);
            sqlprikaz2.Parameters.AddWithValue("@Palivo_Id", PalivoId);
            sqlprikaz2.Parameters.AddWithValue("@Znacka_Id", ZnackaId);

            pripojeni.Open();
            sqlprikaz2.ExecuteNonQuery();
            pripojeni.Close();
            //----------------------------------------
            //********************************************************************************************************
            vypsat();

        }
        //********************************************************************************************************
        // RADIOBUTTONS        
        private void RB_vypis_CheckedChanged(object sender, EventArgs e)
        {
            GB_1.Enabled = false;
            GB_2.Enabled = false;
        }

        private void RB_editace_CheckedChanged(object sender, EventArgs e)
        {
            GB_1.Enabled = true;
            GB_2.Enabled = false;
        }
        private void RB_filtrace_CheckedChanged(object sender, EventArgs e)
        {
            GB_1.Enabled = false;
            GB_2.Enabled = true;
        }
        //********************************************************************************************************
        private void BT_vypsat_Click(object sender, EventArgs e)
        {
            vypsat();
        }

        private void vypsat()
        {
            //---------------------------------------
            LB_seznam.Items.Clear();
            LB_Helper.Items.Clear();
            //--------------
            string DB_key = cesta;
            SqlConnection pripojeni = new SqlConnection(DB_key);
            //--------------
                string prikaz = "SELECT * FROM [TB_main]";
                SqlCommand sqlprikaz = new SqlCommand(prikaz, pripojeni);
            //--------------
            pripojeni.Open();
        
                SqlDataReader zaznamy = sqlprikaz.ExecuteReader();
                while (zaznamy.Read())
                {
                    LB_seznam.Items.Add($"{zaznamy[1]}");
                    LB_Helper.Items.Add($"{zaznamy[0]}");
                }
            pripojeni.Close();
            //----------------------------------------
        }

        private void LB_seznam_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            //MessageBox.Show(Convert.ToString(LB_seznam.SelectedIndex));
            //string vyber = Convert.ToString(LB_seznam.SelectedIndex);
            //------------------------------------------------------------------------
            string DB_key = cesta;
            SqlConnection pripojeni = new SqlConnection(DB_key);
            //*************************************************************************         
            string Id = LB_Helper.Items[LB_seznam.SelectedIndex].ToString();
            //*************************************************************************
            string prikaz = "SELECT * FROM [TB_main] WHERE id ="+ Id + ";";
            SqlCommand sqlprikaz = new SqlCommand(prikaz, pripojeni);
            //------------------------------------------------------------------------
            pripojeni.Open();
                SqlDataReader zaznamy = sqlprikaz.ExecuteReader();
                while (zaznamy.Read())
                {
                    //-------------------
                    TB_Id.Text = $"{zaznamy[0]}";
                    TB_cena.Text = $"{zaznamy[3]}";
                    TB_model.Text = $"{zaznamy[1]}";
                    TB_vykon.Text = $"{zaznamy[6]}";
                    TB_Barva.Text = $"{zaznamy[7]}";
                    TB_spotreba.Text = $"{zaznamy[4]}";
                    //-------------------
                    DateTime rokvyroby = Convert.ToDateTime($"{zaznamy[2]}");
                    DTP_rok_vyroby.Value = rokvyroby;
                    //-------------------
                    bool prevodovka = Convert.ToBoolean($"{zaznamy[5]}");
                    if (prevodovka == true)
                    {
                        RB_automaticka_prevodovka_ano.Checked = true;
                        RB_automaticka_prevodovka_ne.Checked = false;
                    }
                    else
                    {
                        RB_automaticka_prevodovka_ano.Checked = false;
                        RB_automaticka_prevodovka_ne.Checked = true;
                    }
                    //-------------------
                    PalivoId = Convert.ToInt32($"{zaznamy[8]}");
                    ZnackaId = Convert.ToInt32($"{zaznamy[9]}");
                }
            pripojeni.Close();
            //*************************************************************************
            string prikazPalivo = "SELECT Palivo FROM [TB_palivo] WHERE Id =" + PalivoId + ";";
            SqlCommand sqlprikazPalivo = new SqlCommand(prikazPalivo, pripojeni);
            //-------------------
            pripojeni.Open();
                SqlDataReader zaznamyPalivo = sqlprikazPalivo.ExecuteReader();
                while (zaznamyPalivo.Read())
                {
                    CB_palivo.Text = ($"{zaznamyPalivo[0]}");
                }
            pripojeni.Close();       
            //*************************************************************************
            string prikazZnacka = "SELECT Znacka FROM [TB_znacka] WHERE Id = '" + ZnackaId + "' ;";
            SqlCommand sqlprikazZnacka = new SqlCommand(prikazZnacka, pripojeni);
            //-------------------
            pripojeni.Open();
                SqlDataReader zaznamyZnacka = sqlprikazZnacka.ExecuteReader();
                while (zaznamyZnacka.Read())
                {
                    CB_znacka.Text = ($"{zaznamyZnacka[0]}"); ;
                }
            pripojeni.Close();
            //*************************************************************************


        }
        private void ComboVypis()
        {
            string DB_key = cesta;

            SqlConnection pripojeni = new SqlConnection(DB_key);

            string prikazPalivo = "SELECT * FROM [TB_palivo]";
            SqlCommand sqlprikazPalivo = new SqlCommand(prikazPalivo, pripojeni);
            //--------------

            pripojeni.Open();
            SqlDataReader zaznamyPalivo = sqlprikazPalivo.ExecuteReader();
            while (zaznamyPalivo.Read())
            {

                CB_palivo.Items.Add($"{zaznamyPalivo[1]}");

            }
            pripojeni.Close();
            //-------------------------------------------------
            string prikazZnacka = "SELECT * FROM [TB_znacka]";
            SqlCommand sqlprikazZnacka = new SqlCommand(prikazZnacka, pripojeni);
            //--------------

            pripojeni.Open();
            SqlDataReader zaznamyZnacka = sqlprikazZnacka.ExecuteReader();
            while (zaznamyZnacka.Read())
            {

                CB_znacka.Items.Add($"{zaznamyZnacka[1]}");

            }
            pripojeni.Close();
        }

        private void BT_upravit_Click(object sender, EventArgs e)
        {

            if (LB_seznam.SelectedIndex != -1)
            {

                textovepole();
                //string model = TB_model.Text;
                string DB_key = cesta; 
                SqlConnection pripojeni = new SqlConnection(DB_key);
                int Id = Convert.ToInt32(TB_Id.Text);
                //************************************************************************* 
                //string prikazUpdate = "UPDATE [TB_main] SET Model= 'OPEL' WHERE Id = 6";         
                string prikazUpdate = "UPDATE [TB_main]  SET Model= '" + Model + "', Cena= '" + Cena + "' , Spotreba= '" + Spotreba + "' , Automaticka_prevodovka= '" + AutomatickaPrevodovka + "' , Vykon= '" + Vykon + "' , Barva= '" + Barva + "' , Palivo_Id= '" + ZnackaId + "' , Znacka_Id= '" + PalivoId + "'  , Rok_Vyroby= '" + RokVyroby + "'  WHERE Id ='" + Id + "'";
                SqlCommand sqlprikazUpdate = new SqlCommand(prikazUpdate, pripojeni);
                //----------------------------------------
                pripojeni.Open();
                sqlprikazUpdate.ExecuteNonQuery();
                pripojeni.Close();
                //----------------------------------------
                vypsat();
                TB_model.Text = null;
                TB_Barva.Text = null;
                TB_spotreba.Text = null;
                TB_vykon.Text = null;
                TB_cena.Text = null;
                CB_palivo.Text = null;
                CB_znacka.Text = null;
                DTP_rok_vyroby.Text = null;
                RB_automaticka_prevodovka_ano.Checked = false;
                RB_automaticka_prevodovka_ne.Checked = true;
                //----------------------------------------
            }
            else
            {
                MessageBox.Show("Chyba, nevybrali jste položku");
            }
        }


        private void textovepole()
        {
            //************************************************************************* 
            string DB_key = cesta;
            SqlConnection pripojeni = new SqlConnection(DB_key);
            //************************************************************************* 
            string prikazPalivo = "SELECT Id FROM [TB_palivo] WHERE Palivo = '" + CB_palivo.SelectedItem + "' ;";
            SqlCommand sqlprikazPalivo = new SqlCommand(prikazPalivo, pripojeni);
            //--------------------------
            pripojeni.Open();
            SqlDataReader zaznamyPalivo = sqlprikazPalivo.ExecuteReader();
            while (zaznamyPalivo.Read())
            {
                //MessageBox.Show($"{zaznamyPalivo[0]}");
                PalivoId = Convert.ToInt32($"{zaznamyPalivo[0]}");
            }
            pripojeni.Close();
            //************************************************************************* 
            string prikazZnacka = "SELECT Id FROM [TB_znacka] WHERE Znacka = '" + CB_znacka.SelectedItem + "' ;";
            SqlCommand sqlprikazZnacka = new SqlCommand(prikazZnacka, pripojeni);
            //--------------------------
            pripojeni.Open();
            SqlDataReader zaznamyZnacka = sqlprikazZnacka.ExecuteReader();
            while (zaznamyZnacka.Read())
            {
                //MessageBox.Show($"{zaznamyZnacka[0]}");
                ZnackaId = Convert.ToInt32($"{zaznamyZnacka[0]}");
            }
            pripojeni.Close();
            //************************************************************************* 
            //-------------------------------------------
            if (TB_model.TextLength == 0)
            {
                MessageBox.Show("Model není vyplněný");
                Model = "neznámý";
            }
            else
            {
                Model = TB_model.Text;
            }
            //-------------------------------------------
            if (TB_spotreba.TextLength == 0)
            {
                MessageBox.Show("Spotřeba není vyplněná");
                Spotreba = 0;
            }
            else
            {
                Spotreba = Convert.ToInt32(TB_spotreba.Text);
            }
            //-------------------------------------------
            if (RB_automaticka_prevodovka_ano.Checked == true)
            {
                AutomatickaPrevodovka = true;
            }
            if (RB_automaticka_prevodovka_ano.Checked == false)
            {
                AutomatickaPrevodovka = false;
            }
            //-------------------------------------------
            if (TB_vykon.TextLength == 0)
            {
                MessageBox.Show("Výkon není vyplněný");
                Vykon = 0;
            }
            else
            {
                Vykon = Convert.ToInt32(TB_vykon.Text);
            }
            //-------------------------------------------
            if (TB_cena.TextLength == 0)
            {
                MessageBox.Show("Cena není vyplněná");
                Cena = 0;
            }
            else
            {
                Cena = Convert.ToInt32(TB_cena.Text);
            }
            //-------------------------------------------
            if (TB_Barva.TextLength == 0)
            {
                MessageBox.Show("Barva není vyplněněná");
                Barva = "neznámá";
            }
            else
            {
                Barva = TB_Barva.Text;
            }
            //-------------------------------------------
            RokVyroby = Convert.ToString(DTP_rok_vyroby.Value);
            //-------------------------------------------
        }

        private void BT_smazat_Click(object sender, EventArgs e)
        {
            string DB_key = cesta;
            SqlConnection pripojeni = new SqlConnection(DB_key);
            int Id = Convert.ToInt32(TB_Id.Text);
            //----------------------------------------
            string prikazUpdate = "DELETE FROM [TB_main] WHERE Id ='" + Id + "'";
            SqlCommand sqlprikazUpdate = new SqlCommand(prikazUpdate, pripojeni);
            //----------------------------------------
            pripojeni.Open();
            sqlprikazUpdate.ExecuteNonQuery();
            pripojeni.Close();

            vypsat();
            TB_model.Text = null;
            TB_Barva.Text = null;
            TB_spotreba.Text = null;
            TB_vykon.Text = null;
            TB_cena.Text = null;
            CB_palivo.Text = null;
            CB_znacka.Text = null;
            DTP_rok_vyroby.Text = null;
            RB_automaticka_prevodovka_ano.Checked = false;
            RB_automaticka_prevodovka_ne.Checked = true;
        }
    }
}
