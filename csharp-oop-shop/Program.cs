using System.Xml.Linq;

namespace csharp_oop_shop
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Product[] products = new Product[]{
                new Product("Computer da gaming", "Computer molto potente per giocare", 1499.99m, 22),
                new Product("PlayStation 5", "Console da gaming", 498.98m, 22),
                new Product("Latte", "Latte di mucca", 1.99m, 4),
                new Product("Iphone 14", "Smartphone di ultima generazione", 1119.97m, 22),
                new Product("Pane", "Pane di grano duro", 2.95m, 4)
            };

            foreach(var product in products)
{
                Console.WriteLine($"Nome prodotto: {product.Nome} \n" +
                    $"Nome esteso: {product.FullName(product.Nome, product.Codice)} \n" +
                    $"Descrizione: {product.Descrizione} \n" +
                    $"Prezzo: {product.Prezzo}$ \n" +
                    $"Prezzo con IVA: {product.FullPrice(product.Prezzo, product.Iva)}$ \n" +
                    $"Codice prodotto: {product.FullCode(product.Codice)} \n" +
                    $"--------------------------------------------------------- \n");
            }

        }
    }
}