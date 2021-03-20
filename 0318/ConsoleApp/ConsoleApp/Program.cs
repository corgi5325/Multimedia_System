using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var XmlService = new ImportXmlService();

            var XmlDatas = XmlService.LoadFormFile(@"C:\Multimedia_System\0318\docs\臺北市政府職缺.xml");

            Console.WriteLine(string.Format("分析完成，共有{0}筆資料", XmlDatas.Count)); ;
            XmlDatas.ForEach(x =>
            {
                Console.WriteLine(string.Format("機關名稱 :{0} 機關類別:{1} 職位:{2} 職缺人數:{3}", x.dept_name, x.org_type_Name, x.title, x.member_no));
            });

            var JsonService = new ImportJsonService();

            var JsonDatas = JsonService.LoadFormFile(@"C:\Multimedia_System\0318\docs\臺中市大坑風景區各登山步道遊客數.TXT");

            Console.WriteLine(string.Format("分析完成，共有{0}筆資料", JsonDatas.Count));
            JsonDatas.ForEach(x =>
            {
                Console.WriteLine(string.Format("時間 :{0} 編號:{1} 人數:{2}", x.DataDate, x.ComplexName,x.FValue));
            });

            Console.ReadKey();

        }
    }
}
