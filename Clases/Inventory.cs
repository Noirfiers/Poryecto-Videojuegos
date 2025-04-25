using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VideoGameStoreBackend
{
    public class Inventory : BaseEntity
    {
        public Guid GameId { get; set; }
        public int Quantity { get; set; }
        public string Location { get; set; }
        public string BatchNumber { get; set; }
        public DateTime ReceivedDate { get; set; }
        public string Supplier { get; set; }
        public bool IsAvailable { get; set; }
        public string Notes { get; set; }

        public override bool IsValid()
        {
            return GameId != Guid.Empty && Quantity >= 0 && !string.IsNullOrWhiteSpace(Location);
        }

        public static void SaveToFile(List<Inventory> items, string path)
        {
            var json = JsonConvert.SerializeObject(items, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        public static List<Inventory> LoadFromFile(string path)
        {
            return JsonConvert.DeserializeObject<List<Inventory>>(File.ReadAllText(path));
        }
    }
}
