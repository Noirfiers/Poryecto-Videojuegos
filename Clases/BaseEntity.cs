using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VideoGameStoreBackend
{

    public abstract class BaseEntity
    {
        [JsonProperty("Id")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [JsonProperty("CreatedAt")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [JsonProperty("UpdatedAt")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public abstract bool IsValid();
    }

}
