using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Models;

namespace ConsoleApp.Services
{
    public class ImportXmlService
    {
        public ImportXmlService() { }
        public List<Jobs> LoadFormFile(string filePath) 
        {

            var str = System.IO.File.ReadAllText(filePath);

            var xDocument = System.Xml.Linq.XDocument.Parse(str);

            var targets = xDocument.Descendants("Job");

            return targets
                .Select(x =>
                {
                    var item = new Jobs();
                    item.dept_name = x.Element("dept_name").Value;
                    item.title = x.Element("title").Value;
                    item.org_type_Name = x.Element("org_type_Name").Value;
                    item.member_no = x.Element("member_no").Value;
                    return item;
                })
                .ToList();

        }
    }
}
