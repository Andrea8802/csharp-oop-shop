using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Product
    {
        private int codice;
        private string nome;
        private string descrizione;
        private decimal prezzo;
        private int iva;

        public int Codice { get; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public decimal Prezzo { get; set; }
        public int Iva { get; set; }

        Random rand = new Random();

        

        public Product(string nome, string descrizione, decimal prezzo, int iva)
        {
            Codice = rand.Next(1,1000);
            Nome = nome;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Iva = iva;

        }

        public decimal FullPrice(decimal prezzo, int iva)
        {
            return prezzo += prezzo * iva / 100;
        }

        public string FullName(string nome, int codice)
        {
            return nome + codice;
        }

        public string FullCode(int codice)
        {
            string codeString = codice.ToString();

            if (codeString.Length >= 8)
            {
                return codeString;
            }
            else
            {
                return codeString.PadLeft(8, '0');
            }
        }

    }
}
