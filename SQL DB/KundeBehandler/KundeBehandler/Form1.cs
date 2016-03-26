using System;
using System.Windows.Forms;
using System.Collections.Generic;
using D = System.Data;
using C = System.Data.SqlClient;


namespace KundeBehandler
{
    public partial class Form1 : Form
    {
        private string SQLConnectionString = "";
        private List<Kunde> kunder = new List<Kunde>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)                                 //<<< (void)    Form load, henter inn kunder
        {
            OppdaterKunder();                                                               // < Laster ned eksisterende kunder
        }                              

        private void OppdaterKunder()                                                       //<<< (void)    Laster ned kunder fra databasen til listeboksen
        {
            using (C.SqlConnection tilkobling = new C.SqlConnection(SQLConnectionString))   // < Setter tilkoblingen
            {
                C.SqlCommand kommando = new C.SqlCommand();
                kommando.Connection = tilkobling;                                           // < Fester tilkoblingen til SQL kommandoen

                kommando.CommandType = D.CommandType.Text;                                  // < Setter kommandotype til tekst, slik at vi kan sende tekst-forespørsler til databasen
                kommando.CommandText = @"SELECT * FROM Kunder;";                            // < Setter kommandoen til å hente alle kundene

                tilkobling.Open();                                                          // < Åpner tilkoblingen til databasen
                C.SqlDataReader leser = kommando.ExecuteReader();                           // < Utfører kommandoen

                kunder.Clear();                                                             // < Fjerner alle kunder
                while (leser.Read())                                                        // < Leser alle kunder fra vår forespørsel
                    kunder.Add(new Kunde((int)leser[0], (string)leser[1], (string)leser[2], (decimal)leser[3]));
                                                                                            // ^ Legger til kunde som leses fra forespørselen
                listeKunder.Items.Clear();                                                  // < Fjerner alle kunder fra listeboksen

                foreach (Kunde kunde in kunder)                                             // < Leser alle kunder fra kunder listen
                    listeKunder.Items.Add(kunde.fornavn + " " + kunde.etternavn);           // < Legger til kunde i listeboksen
            }
        }

        private void listeKunder_SelectedIndexChanged(object sender, EventArgs e)           //<<< (Change)  Setter data til UI kontroller
        {
            if (listeKunder.SelectedIndex != -1)                                            // < Om et element er valgt   
            {
                gruppeKunde.Enabled = true;                                                 // <
                labelID.Text = "ID: " + kunder[listeKunder.SelectedIndex].ID.ToString();    // <
                tekstFornavn.Text = kunder[listeKunder.SelectedIndex].fornavn;              // < Aktiverer UI kontroller og oppdaterer verdier til UI
                tekstEtternavn.Text = kunder[listeKunder.SelectedIndex].etternavn;          // <
                numeriskSaldo.Value = kunder[listeKunder.SelectedIndex].saldo;              // <
            }
            else
                gruppeKunde.Enabled = false;                                                // < Deaktiverer UI kontroller hvis ingen elementer er valgt
        }

        private void knappLeggTil_Click(object sender, EventArgs e)                         //<<< (Button)  Legger til en ny kunde til databasen og oppdaterer
        {
            using (C.SqlConnection tilkobling = new C.SqlConnection(SQLConnectionString))   // < Setter tilkoblingen
            {
                C.SqlCommand kommando = new C.SqlCommand();
                kommando.Connection = tilkobling;                                           // < Kobler SQL kommandoen til tilkoblingen

                kommando.CommandType = D.CommandType.Text;                                  // < Setter kommandotype til tekst, slik at vi kan sende tekst-forespørsler til databasen
                kommando.CommandText =                                                      // < Setter komandoen til å lage en ny kunde: 'Ola Normann'
                    @"INSERT INTO Kunder (fornavn, etternavn, saldo)                        
                        VALUES ('Ola', 'Normann', 0);";
                tilkobling.Open();                                                          // < Åpner tilkoblingen til databasen

                kommando.ExecuteReader();                                                   // < Utfører kommandoen og lager ny kunde i databasen

                OppdaterKunder();                                                           // < Laster ned eksisterende kunder
                listeKunder.SelectedIndex = listeKunder.Items.Count - 1;                    // < Velger det nyeste elementet i listen
            }
        }

        private void knappFjern_Click(object sender, EventArgs e)                           //<<< (Button)  Fjerner den valgte kunden i listeboksen
        {
            if (listeKunder.SelectedIndex != -1)                                            // < Om et element er valgt
            {
                using (C.SqlConnection tilkobling = new C.SqlConnection(SQLConnectionString))
                {                                                                           // ^ Setter tilkoblingen
                    C.SqlCommand kommando = new C.SqlCommand();      
                    kommando.Connection = tilkobling;                                       // < Fester tilkoblingen til SQL kommandoen

                    kommando.CommandType = D.CommandType.Text;                              // < Setter kommandotype til tekst, slik at vi kan sende tekst-forespørsler til databasen
                    kommando.CommandText =                                                  // < Setter kommandoen til å slette kunden med valgt ID
                        @"DELETE FROM Kunder
                        WHERE ID = " + kunder[listeKunder.SelectedIndex].ID.ToString() + ";";
                    tilkobling.Open();                                                      // < Åpner tilkoblingen til databasen

                    kommando.ExecuteReader();                                               // < Utfører kommandoen
                }
                gruppeKunde.Enabled = false;                                                // < Deaktiverer UI kontrollene
                OppdaterKunder();                                                           // < Laster ned eksisterende kunder 
            }
        }

        private void knappOppdater_Click(object sender, EventArgs e)                        //<<< (Button)  Oppdaterer valgt kunde med data fra UI kontrollene
        {
            if (listeKunder.SelectedIndex != -1)                                            // < Om et element er valgt
            {
                using (C.SqlConnection tilkobling = new C.SqlConnection(SQLConnectionString))
                {                                                                           // ^ Setter tilkoblingen
                    C.SqlCommand kommando = new C.SqlCommand();
                    kommando.Connection = tilkobling;                                       // < Fester tilkoblingen til SQL kommandoen

                    kommando.CommandType = D.CommandType.Text;                              // < Setter kommandotype til tekst, slik at vi kan sende tekst-forespørsler til databasen
                    kommando.CommandText =                                                  // < Setter kommandoen til å oppdatere med informasjonen fra UI kontrollene. (fornavn, etternavn, saldo)
                        @"UPDATE Kunder
                            SET fornavn='" + tekstFornavn.Text + "', etternavn ='" + tekstEtternavn.Text + "', saldo=" + numeriskSaldo.Value + @"
                            WHERE ID=" + kunder[listeKunder.SelectedIndex].ID + ";";
                    tilkobling.Open();                                                      // < Åpner tilkoblingen til databasen

                    kommando.ExecuteReader();                                               // < Utfører kommandoen
                }
                OppdaterKunder();                                                           // < Laster ned eksisterende kunder
            }
        }
    }
}

public struct Kunde                                                                         //<<< (Class)   Kunde klasse for midlertidig lagring av kundene
{
    public int ID;
    public string etternavn;
    public string fornavn;
    public decimal saldo;

    public Kunde(int _ID, string _fornavn, string _etternavn, decimal _saldo)               //<<< (Constructor) Setter alle verdier for kunden
    {
        ID = _ID;
        fornavn = _fornavn;
        etternavn = _etternavn;
        saldo = _saldo;
    }
}