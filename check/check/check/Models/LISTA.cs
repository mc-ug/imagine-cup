using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace check
{
    [DataTable("chekear")]
    public class LISTA

    {
        [JsonProperty]
        public string Id { get; set; }

        [JsonProperty]
        public string Nombre { get; set; }

        [JsonProperty]
        public string Apellido { get; set; }

        [JsonProperty]
        public string Curso { get; set; }


        [Version]
        public string Version { get; set; }


    }
}
