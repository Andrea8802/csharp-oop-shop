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

        public decimal fullPrice(decimal Prezzo)
        {
            return Prezzo * 22 / 100;
        }

        public Product(string nome, string descrizione, decimal prezzo, int iva)
        {
            Codice = rand.Next(1,1000);
            Nome = nome;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Iva = iva;

        }

    }
}
