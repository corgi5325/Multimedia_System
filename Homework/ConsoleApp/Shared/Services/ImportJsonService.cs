using ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Services
{
    public class ImportJsonService
    {
        public List<BikePath> LoadFormFile(string filePath)
        {
            
            var str = System.IO.File.ReadAllText(filePath);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<BikePath>>(str);

        }
    }
}
