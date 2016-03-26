using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;

namespace StorageQueueDemo
{
    public partial class Form1 : Form
    {
        CloudQueue queue;

        public Form1()
        {
            InitializeComponent();
        }

        private async void InitialiserKø(string connectionString, string køNavn)            //<<< (async)   Initialiser køen. Lag ny, eller bruk eksisterende
        {
            CloudStorageAccount cloudStorageAccount = CloudStorageAccount.Parse(connectionString);  
                                                                                            // ^ Lager objekt for din Storage Account
            CloudQueueClient queueClient = cloudStorageAccount.CreateCloudQueueClient();    // < Lager et klient objekt for køen
            queue = queueClient.GetQueueReference(køNavn);                                  // < Setter kønavn og en referanse til klienten

            try { await queue.CreateIfNotExistsAsync(); }                                   // < Lager kø eller bruker en eksisterende om det finnes
            catch (Exception ex)
            { Console.WriteLine("Kunne ikke initialisere kø! Error: " + ex.Message); return; }

            gruppeBehandler.Enabled = true;
            LesFraKø();                                                                     // < Laster inn eksisterende elementer fra køen
        }
        
        private async void LesFraKø()                                                       //<<< (async)   Leser(Peek) elementer fra køen og legger de i listeboksen
        {
            try { await queue.FetchAttributesAsync(); }                                     // < Henter attributter fra køen (antall)            
            catch (Exception ex)
            { Console.WriteLine("Kunne ikke lese kø! Error: " + ex.Message); return; }

            int? antall = queue.ApproximateMessageCount;                                    // < Setter antall meldinger

            if (antall > 0)
            {
                var meldinger = await queue.PeekMessagesAsync(antall.Value);                // < Leser elementene(Peek), uten at andre brukere mister tilgang

                listeMeldinger.Items.Clear();

                for (int i = 0; i < meldinger.ToArray().Length; i++)
                    listeMeldinger.Items.Add(meldinger.ToArray()[i].AsString);              // < Legger elementene til listen
            }
            else
                listeMeldinger.Items.Clear();
        }

        private async void LeggTilMelding(string text)                                      //<<< (async)   Legger til et nytt element til køen og laster inn på nytt
        {
            CloudQueueMessage melding = new CloudQueueMessage(text);                        // < Lager objekt til køen med tekst
            try { await queue.AddMessageAsync(melding); }                                   // < Sender objektet til køen
            catch (Exception ex)
            { Console.WriteLine("Kunne ikke legge til melding i køen! Error: " + ex.Message); return; }

            LesFraKø();                                                                     // < Laster inn elementene på nytt
        }
        
        private async void FjernElementer()                                                 //<<< (async)   Fjerner alle elementer fra køen
        {
            try { await queue.ClearAsync(); }
            catch (Exception ex)
            { Console.WriteLine("Kunne ikke fjerne elementer fra køen! Error: " + ex.Message); return; }

            LesFraKø();
        }

        private void knappLeggTil_Click(object sender, EventArgs e)                         //<<< (Button)  Sender et element til køen
        {
            LeggTilMelding(tekstMelding.Text);
            tekstMelding.Text = "";
        }

        private void knappKobleTil_Click(object sender, EventArgs e)                        //<<< (Button)  Kobler til og initialiserer
        {
            InitialiserKø(tekstConnectionString.Text, tekstQueueName.Text);   
        }

        private void knappLastInn_Click(object sender, EventArgs e)                         //<<< (Button)  Laster inn på nytt
        {
            LesFraKø();
        }

        private void knappFjern_Click(object sender, EventArgs e)                           //<<< (Button)  Fjerner alle elementer
        {
            FjernElementer();
        }                               
    }
}
