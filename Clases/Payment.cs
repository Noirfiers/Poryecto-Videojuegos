using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VideoGameStoreBackend
{
    public class Payment : BaseEntity
    {
        public Guid OrderId { get; set; }
        public string Method { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaidAt { get; set; }
        public string CardHolder { get; set; }
        public string CardNumber { get; set; }
        public string TransactionId { get; set; }
        public string Status { get; set; }

        public override bool IsValid()
        {
            return OrderId != Guid.Empty && Amount > 0 && !string.IsNullOrWhiteSpace(Method);
        }

        public static void SaveToFile(List<Payment> payments, string path)
        {
            var json = JsonConvert.SerializeObject(payments, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        public static List<Payment> LoadFromFile(string path)
        {
            return JsonConvert.DeserializeObject<List<Payment>>(File.ReadAllText(path));
        }
    }

}
