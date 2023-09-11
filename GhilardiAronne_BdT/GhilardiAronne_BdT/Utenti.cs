using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhilardiAronne_BdT
{
    public class Utente : IEquatable<Utente>
    {
        public string _cognome;
        public string _nome;
        public double _nrTelefono;
        public int _debito;
        public bool _registro; // Indica se il socio fa parte della segreteria

        [JsonProperty]
        public string Cognome
        {
            get
            {
                return _cognome;
            }
            private set
            {
                if (!String.IsNullOrWhiteSpace(value))
                { 
                    _cognome = value; 
                }
                else
                {
                    throw new Exception("ERRORE! Cognome inesistente.");
                }
            }
        }

        [JsonProperty]
        public string Nome
        {
            get
            {
                return _nome;
            }
            private set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    _nome = value;
                }
                else
                {
                    throw new Exception("ERRORE! Nome inesistente.");
                }
            }
        }

        [JsonProperty]
        public double NrTelefono
        {
            get
            {
                return _nrTelefono;
            }
            private set
            {
                if (!String.IsNullOrWhiteSpace(value.ToString()) && value.ToString().Length == 10)
                {
                    _nrTelefono = value;
                }
                else
                {
                    throw new Exception("ERRORE! Numero di telefono non valido.");
                }
            }
        }

        [JsonProperty]
        public int Debito
        {
            get
            {
                return _debito;
            }
            set
            {
                _debito = value;
            }
        }

        [JsonProperty]
        public bool Registro
        {
            get
            {
                return _registro;
            }
            private set
            {
                if (!String.IsNullOrWhiteSpace(value.ToString()))
                    _registro = value;
                else
                    throw new Exception("ERRORE! Utente non presente all'interno del registro.");
            }
        }

        [JsonProperty]
        public List<Prestito> Prestiti { get; set; }   // Elenco dei prestiti EMESSI o RICEVUTI da un utente

        public Utente(string cognome, string nome, double nrTelefono, int debito, bool registro)
        {
            Cognome = cognome;
            Nome = nome;
            NrTelefono = nrTelefono;
            Debito = debito;
            Registro = registro;
            Prestiti = new List<Prestito>();
        }
        public Utente()
        {
            Cognome = "empty";
            Nome = "empty";
            NrTelefono = 9999999999;
            Debito = 0;
            Registro = false;
            Prestiti = new List<Prestito>();
        }

        public void AggiungerePrestito(Prestito prestito)   // Funzione per AGGIUNGERE un prestito a un utente
        {
            Prestiti.Add(prestito);
        }

        public int CalcolareDebito()   // Funzione per CALCOLARE le ore EMESSE e RICEVUTE
        {
            int hEmesse = 0;
            int hRicevute = 0;

            foreach (Prestito prestito in Prestiti)
            {
                if (prestito.Emittente.Equals(this))
                {
                    hEmesse += prestito.H;
                }
                else if (prestito.Ricevente.Equals(this))
                {
                    hRicevute += prestito.H;
                }
            }
            this.Debito = hRicevute - hEmesse;
            return this.Debito;
        }

        protected Utente(Utente other) : this(other.Cognome, other.Nome, other.NrTelefono, other.Debito, other.Registro)
        {

        }

        public Utente Clone()
        {
            return new Utente(this);
        }

        public bool Equals(Utente u)
        {
            if (u == null)
            {
                return false;
            }
            if (this == u)
            {
                return true;
            }
            return (this.Cognome == u.Cognome && this.Nome == u.Nome);
        }

        public override string ToString()
        {
            return $"Utente: {Cognome} {Nome}; {NrTelefono}, {Debito}";
        }
    }
}
