using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhilardiAronne_BdT
{
    public class Prestito : IEquatable<Prestito>
    {
        public string _id;   // ID per riconoscere il prestito
        public Utente _emittente;   // Utente che presta le ore
        public Utente _ricevente;   // Utente che riceve le ore prestate
        public int _h;   // Numero di ore "prestate" dall'emmitente
        public DateTime _data;   // Data del prestito
        public string _type;   // Spiega per cosa sono state utilizate le ore prestate

        [JsonProperty]
        public string Id
        {
            get
            {
                return _id;
            }
            private set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    _id = value;
                }
                else
                {
                    throw new Exception("ERRORE! Id non valido.");
                }
            }
        }

        [JsonProperty]
        public Utente Emittente
        {
            get
            {
                return _emittente;
            }
            private set
            {
                if (value != null)
                {
                    _emittente = value;
                }
                else
                {
                    throw new Exception("ERRORE! Utente emittente non valido.");
                }
            }
        }

        [JsonProperty]
        public Utente Ricevente
        {
            get
            {
                return _ricevente;
            }
            private set
            {
                if (value != null)
                {
                    _ricevente = value;
                }
                else
                {
                    throw new Exception("ERRORE! Utente ricevente non valido.");
                }
            }
        }

        [JsonProperty]
        public int H
        {
            get
            {
                return _h;
            }
            private set
            {
                if (value > 0)
                {
                    _h = value;
                }
                else
                {
                    throw new Exception("ERRORE! Ore selezionate non valide.");
                }
            }
        }

        [JsonProperty]
        public DateTime Data
        {
            get
            {
                return _data;
            }
            private set
            {
                if (value != null)
                {
                    _data = value;
                }
                else
                {
                    throw new Exception("ERRORE! Data non valida.");
                }
            }
        }

        [JsonProperty]
        public string Type
        {
            get
            {
                return _type;
            }
            private set
            {
                if (value != null)
                {
                    _type = value;
                }
                else
                {
                    throw new Exception("ERRORE! Tipo non valido.");
                }
            }
        }

        public Prestito(string id, Utente emittente, Utente ricevente, int h, DateTime data, string type)
        {
            Id = id;
            Emittente = emittente;
            Ricevente = ricevente;
            H = h;
            Data = data;
            Type = type;
        }

        public Prestito()
        {

        }

        protected Prestito(Prestito other) : this(other.Id, other.Emittente, other.Ricevente, other.H, other.Data, other.Type)
        {

        }

        public Prestito Clone()
        {
            return new Prestito(this);
        }

        public bool Equals(Prestito p)
        {
            if (p == null)
            {
                return false;
            }
            if (this == p)
            {
                return true;
            }
            return (this.Id == p.Id);
        }

        public override string ToString()
        {
            return $"Prestazione:{Id} {Emittente}; {Ricevente}; {H}; {Data}; {Type}";
        }
    }
}
