using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewBeeProject.Models
{
    class Directory
    {
        [JsonProperty(PropertyName = "area")]
        public string AreaName { get; set; }

        [JsonProperty(PropertyName = "departamento")]
        public string DepartmentName { get; set; }

        [JsonProperty(PropertyName = "descripcion")]
        public string AreaDescription { get; set; }

        [JsonProperty(PropertyName = "edificio")]
        public string AreaBuilding { get; set; }

        [JsonProperty(PropertyName = "encargado")]
        public string AreaSupervisor { get; set; }

        [JsonProperty(PropertyName = "telefono")]
        public string AreaPhonenumber { get; set; }
    }
}
