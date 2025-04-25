using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VideoGameStoreBackend
{
    public class Review : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid GameId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }
        public bool IsApproved { get; set; }
        public string Title { get; set; }
        public string ReviewerName { get; set; }

        public override bool IsValid()
        {
            return Rating >= 1 && Rating <= 5 && !string.IsNullOrWhiteSpace(Comment);
        }

        public static void SaveToFile(List<Review> reviews, string path)
        {
            var json = JsonConvert.SerializeObject(reviews, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        public static List<Review> LoadFromFile(string path)
        {
            return JsonConvert.DeserializeObject<List<Review>>(File.ReadAllText(path));
        }
    }
}
