using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VideoGameStoreBackend
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string LoyaltyCardNumber { get; set; }
        public bool IsSubscribed { get; set; }

        public override bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(Name) && Email.Contains("@") && Phone.Length >= 8;
        }

        public static void SaveToFile(List<Customer> customers, string path)
        {
            var json = JsonConvert.SerializeObject(customers, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        public static List<Customer> LoadFromFile(string path)
        {
            return JsonConvert.DeserializeObject<List<Customer>>(File.ReadAllText(path));
        }
    }
}
