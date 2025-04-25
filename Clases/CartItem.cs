using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VideoGameStoreBackend
{
    public class CartItem : BaseEntity
    {
        public Guid GameId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice => Quantity * UnitPrice;
        public Guid UserId { get; set; }
        public bool IsCheckedOut { get; set; }
        public string Notes { get; set; }
        public string Platform { get; set; }

        public override bool IsValid()
        {
            return GameId != Guid.Empty && Quantity > 0 && UnitPrice >= 0;
        }

        public static void SaveToFile(List<CartItem> items, string path)
        {
            var json = JsonConvert.SerializeObject(items, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        public static List<CartItem> LoadFromFile(string path)
        {
            return JsonConvert.DeserializeObject<List<CartItem>>(File.ReadAllText(path));
        }
    }
}
