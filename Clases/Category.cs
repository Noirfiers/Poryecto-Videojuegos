using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VideoGameStoreBackend
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string Slug { get; set; }
        public string CreatedBy { get; set; }
        public bool IsVisible { get; set; }
        public int DisplayOrder { get; set; }
        public string ParentCategory { get; set; }

        public override bool IsValid() => !string.IsNullOrWhiteSpace(Name);

        public static void SaveToFile(List<Category> categories, string path)
        {
            var json = JsonConvert.SerializeObject(categories, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        public static List<Category> LoadFromFile(string path)
        {
            return JsonConvert.DeserializeObject<List<Category>>(File.ReadAllText(path));
        }
    }
}
