using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp
{
    public class ImportJsonService
    {
        public List<MountainPathway> LoadFormFile(string filePath)
        {
            
                var str = System.IO.File.ReadAllText(filePath);
                return Newtonsoft.Json.JsonConvert.DeserializeObject<List<MountainPathway>>(str);
            
        }
    }
}
