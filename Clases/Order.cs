using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VideoGameStoreBackend
{
    public class Order : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public List<Guid> GameIds { get; set; } = new List<Guid>();
        public decimal TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public string DeliveryAddress { get; set; }
        public string ContactPhone { get; set; }
        public bool IsDelivered { get; set; }

        public override bool IsValid() => GameIds.Count > 0 && TotalAmount > 0;

        public static void SaveToFile(List<Order> orders, string path)
        {
            var json = JsonConvert.SerializeObject(orders, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        public static List<Order> LoadFromFile(string path)
        {
            return JsonConvert.DeserializeObject<List<Order>>(File.ReadAllText(path));
        }
    }
}
