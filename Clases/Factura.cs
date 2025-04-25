using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VideoGameStoreBackend
{
    public class Factura : BaseEntity
    {
        public Guid OrderId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string BillingAddress { get; set; }
        public DateTime IssuedDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Notes { get; set; }
        public string TaxId { get; set; }

        public override bool IsValid() => OrderId != Guid.Empty && TotalAmount > 0;

        public static void SaveToFile(List<Factura> facturas, string path)
        {
            var json = JsonConvert.SerializeObject(facturas, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        public static List<Factura> LoadFromFile(string path)
        {
            return JsonConvert.DeserializeObject<List<Factura>>(File.ReadAllText(path));
        }
    }
}
