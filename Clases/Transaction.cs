using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VideoGameStoreBackend
{
    public class Transaction : BaseEntity
    {
        public Guid PaymentId { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public string Description { get; set; }
        public bool IsRefund { get; set; }
        public string Processor { get; set; }
        public string ReferenceCode { get; set; }

        public override bool IsValid() => Amount > 0 && !string.IsNullOrWhiteSpace(TransactionType);

        public static void SaveToFile(List<Transaction> transactions, string path)
        {
            var json = JsonConvert.SerializeObject(transactions, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        public static List<Transaction> LoadFromFile(string path)
        {
            return JsonConvert.DeserializeObject<List<Transaction>>(File.ReadAllText(path));
        }
    }

}
