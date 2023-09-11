using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GhilardiAronne_BdT
{
    public partial class Form1 : Form
    {
        public List<Utente> utenti = new List<Utente>();
        public List<Prestito> prestiti = new List<Prestito>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            UpdateData();
        }

        private void LoadData()   // Funzione che CARICA i DATI dal file JSON
        {
            if (File.Exists("Utenti.json"))
            {
                string utentiJson = File.ReadAllText("Utenti.json");
                utenti = JsonConvert.DeserializeObject<List<Utente>>(utentiJson);
            }
            if (File.Exists("Prestiti.json"))
            {
                string prestitiJson = File.ReadAllText("Prestiti.json");
                prestiti = JsonConvert.DeserializeObject<List<Prestito>>(prestitiJson);
            }
        }

        private void SaveData()   // Funzione che SALVA i DATI sul file JSON
        {
            string utentiJson = JsonConvert.SerializeObject(utenti);
            File.WriteAllText("Utenti.json", utentiJson);
            string prestitiJson = JsonConvert.SerializeObject(prestiti);
            File.WriteAllText("Prestiti.json", prestitiJson);
        }

        private void UpdateData()   // Funzione che AGGIORNA i DATI sull'interfaccia grafica
        {
            listUtenti.Items.Clear();
            foreach (Utente utenti in utenti)
            {
                listUtenti.Items.Add($"{utenti.Cognome} {utenti.Nome} - Tel: {utenti.NrTelefono}");
            }
        }

        private void buttonRegistro_Click(object sender, EventArgs e)   // Funzione che VISUALIZZA i soci nel registro
        {
            List<Utente> registroUtenti = utenti.Where(s => s.Registro).ToList();
            listRegistro.Items.Clear();
            foreach (Utente registroUtente in registroUtenti)
            {
                listRegistro.Items.Add($"{registroUtente.Cognome} {registroUtente.Nome} - Tel: {registroUtente.NrTelefono}");
            }
        }

        private void buttonPrestiti_Click(object sender, EventArgs e)   // Funzione che RIORDINA e VISUALIZZA i prestiti
        {
            List<Prestito> prestitiOrdinate = prestiti.OrderByDescending(p => p.H).ToList();
            listPrestiti.Items.Clear();
            foreach (Prestito prestito in prestitiOrdinate)
            {
                listPrestiti.Items.Add($"{prestito.Emittente.Cognome} {prestito.Emittente.Nome} -> {prestito.Ricevente.Cognome}, {prestito.Ricevente.Nome} - {prestito.H} ore di {prestito.Type}");
            }
        }

        private void buttonDebito_Click(object sender, EventArgs e)   // Funzione che CREA la lista degli UTENTI con DEBITI
        {
            List<Utente> debitori = utenti.Where(s => s.CalcolareDebito() > 0).ToList();
            listDebiti.Items.Clear();
            foreach (Utente debitore in debitori)
            {
                listDebiti.Items.Add($"{debitore.Cognome} {debitore.Nome} | Debito: {debitore.Debito}");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
