using ConsoleApp.Services;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var XmlService = new ImportXmlService();

            var XmlDatas = XmlService.LoadFormFile(Utils.FilePath.GetFullPath("臺北市政府職缺.xml"));

            Console.WriteLine(string.Format("分析完成，共有{0}筆資料", XmlDatas.Count)); ;
            XmlDatas.ForEach(x =>
            {
                Console.WriteLine(string.Format("機關名稱 :{0} 機關類別:{1} 職位:{2} 職缺人數:{3}", x.dept_name, x.org_type_Name, x.title, x.member_no));
            });

            var JsonService = new ImportJsonService();

            var JsonDatas = JsonService.LoadFormFile(Utils.FilePath.GetFullPath("自行車道.json"));

            Console.WriteLine(string.Format("分析完成，共有{0}筆資料", JsonDatas.Count));
            JsonDatas.ForEach(x =>
            {
                Console.WriteLine(string.Format("自行車道名稱 :{0} 起點地區:{1} 終點地區:{2} 介紹:{3} 地址:{4} 電話:{5} 地圖:{6} 關鍵字:{7}", x.Name, x.S_PlaceDes, x.E_PlaceDes, x.Description, x.Add, x.Tel, x.Map, x.Keyword));
            });

            Console.ReadKey();

        }
    }
}
