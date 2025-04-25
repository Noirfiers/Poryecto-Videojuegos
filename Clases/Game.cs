using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VideoGameStoreBackend
{
    public class Game : BaseEntity
    {
        public Guid GameId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string Platform { get; set; }
        public bool IsMultiplayer { get; set; }  
        public int Quantity { get; set; }

        public override bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(Title) && Price >= 0 && Quantity >= 0;
        }

        public static void SaveToFile(List<Game> games, string path)
        {
            var json = JsonConvert.SerializeObject(games, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        public static List<Game> LoadFromFile(string path)
        {
            return JsonConvert.DeserializeObject<List<Game>>(File.ReadAllText(path));
        }
    }
}

